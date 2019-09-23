using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Aspose.Email;
using Aspose.Email.Mapi;
using Aspose.Email.Storage.Pst;

namespace EmailAnalyzer
{
    public partial class FrmMain : Form
    {
        private List<ExpandoObject> listEmail;
        public FrmMain()
        {
            InitializeComponent();
            LicenseHelper.ModifyInMemory.ActivateMemoryPatching();
        }

        private void xsbAnalysis_Click(object sender, EventArgs e)
        {

            try
            {
                splashScreenManager.ShowWaitForm();
                listEmail = new List<ExpandoObject>();
                xgridResult.DataSource = null;
                if (Directory.Exists(xbeDirectory.Text))
                {
                    splashScreenManager.SetWaitFormDescription("Loading email files...");
                    var listEmailFiles =
                        Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.msg", SearchOption.AllDirectories)
                            .ToList();
                    splashScreenManager.SetWaitFormDescription("Analysing emails...");
                    listEmailFiles.ForEach(f =>
                    {
                        var mailMessage = MailMessage.Load(f);
                        if (radioGroup1.SelectedIndex == 1)
                            AnalysisMailForPMD(mailMessage);
                        else
                            AnalysisBounceMail(mailMessage);
                    });
                }
                else if (File.Exists(xbePSTFile.Text))
                {
                    splashScreenManager.SetWaitFormDescription("Loading email files...");
                    var personalStorage = PersonalStorage.FromFile(xbePSTFile.Text);
                    var listMessageInfo = new List<MessageInfo>();
                    GetMessageInfo(ref listMessageInfo, personalStorage.RootFolder);
                    splashScreenManager.SetWaitFormDescription("Analysing emails...");
                    listMessageInfo.ForEach(m =>
                    {
                        try
                        {
                            var mailMessage =
                                personalStorage.ExtractMessage(m)
                                    .ToMailMessage(new MailConversionOptions());
                            if (radioGroup1.SelectedIndex == 1)
                                AnalysisMailForPMD(mailMessage);
                            else
                                AnalysisBounceMail(mailMessage);
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                        }

                    });
                    personalStorage.Dispose();
                }

                xgridResult.DataSource = listEmail;
                xgridViewResult.RefreshData();
                xgridViewResult.BestFitColumns();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message + "\r\n" + exception.StackTrace);
            }
            finally
            {
                splashScreenManager.CloseWaitForm();
            }


        }

        private void AnalysisBounceMail(MailMessage mailMessage)
        {
            mailMessage.ToList().ForEach(a =>
            {
                Regex.Matches(mailMessage.Body,
                        @"[\w!#$%&'*+/?^_`{|}~-]+(?:\.[\w!#$%&'*+/?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?",
                        RegexOptions.Multiline).Cast<Match>().Where(m => m.Success).Select(m => m.Value).Distinct()
                    .ToList()
                    .ForEach(
                        e =>
                        {
                            dynamic emailInfo = new ExpandoObject();
                            emailInfo.MsgEmailAddress = e;
                            emailInfo.Date = mailMessage.Date;
                            emailInfo.Subject = mailMessage.Subject;
                            emailInfo.From = mailMessage.From.Address;
                            listEmail.Add(emailInfo);
                        });
            });
        }

        private void AnalysisMailForPMD(MailMessage mailMessage)
        {
            var sCaseNo = GetOurRefFromSubject(mailMessage.Subject);
            //if (string.IsNullOrWhiteSpace(sCaseNo)) return;

            var listRecipients = mailMessage.To.ToList();
            if (mailMessage.CC.Count > 0)
                listRecipients.AddRange(mailMessage.CC);
            if (mailMessage.From != null)
                listRecipients.Add(mailMessage.From);

            listRecipients.Where(a => !a.Address.Contains("@beijingeastip.com") && !a.Address.Contains("@longriver.com.tw")).ToList().ForEach(a =>
              {
                  dynamic emailInfo = new ExpandoObject();
                  emailInfo.CaseNo = sCaseNo;
                  emailInfo.Subject = mailMessage.Subject;
                  emailInfo.Recipient = GetName(a.DisplayName, a.Address);
                  emailInfo.Address = a.Address;
                  emailInfo.Bcc = false;
                  listEmail.Add(emailInfo);
              });

            if (mailMessage.Bcc.Count > 0)
            {
                mailMessage.Bcc.Where(a => !a.Address.Contains("@beijingeastip.com") && !a.Address.Contains("@longriver.com.tw")).ToList().ForEach(a =>
                {
                    dynamic emailInfo = new ExpandoObject();
                    emailInfo.CaseNo = sCaseNo;
                    emailInfo.Subject = mailMessage.Subject;
                    emailInfo.Recipient = GetName(a.DisplayName, a.Address);
                    emailInfo.Address = a.Address;
                    emailInfo.Bcc = true;
                    listEmail.Add(emailInfo);
                });
            }
        }

        private void xbeDirectory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;
            xbeDirectory.Text = folderBrowserDialog.SelectedPath;
        }

        private void xbePSTFile_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            xbePSTFile.Text = openFileDialog.FileName;
        }

        private void GetMessageInfo(ref List<MessageInfo> listMessageInfo, FolderInfo folderInfo)
        {
            listMessageInfo.AddRange(folderInfo.EnumerateMessages());
            if (!folderInfo.HasSubFolders) return;
            foreach (var subFolder in folderInfo.GetSubFolders())
            {
                GetMessageInfo(ref listMessageInfo, subFolder);
            }
        }

        private string GetOurRefFromSubject(string sSubject)
        {
            var match = Regex.Match(sSubject, @"((\d|[A-Za-z])+-\d+-[A-Za-z]+)|(\d{2}[A-Za-z]{1,2}\d{4})");
            return match.Success ? match.Value : string.Empty;
        }

        private string GetName(string sDisplayName, string sAddress)
        {
            if (string.IsNullOrWhiteSpace(sDisplayName))
                sDisplayName = sAddress;
            sDisplayName = sDisplayName.Trim().Trim('\'');
            sDisplayName = Regex.Replace(sDisplayName, @"(\(.*@.*\))|(\<.*@.*\>)", string.Empty);
            if (sDisplayName.Contains("@"))
                sDisplayName = sDisplayName.Substring(0, sDisplayName.IndexOf('@'));
            return sDisplayName.Trim().Trim('\'');
        }
    }
}
