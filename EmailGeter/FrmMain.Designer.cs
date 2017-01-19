namespace EmailGeter
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xbePSTFile = new DevExpress.XtraEditors.ButtonEdit();
            this.xsbAnalysis = new DevExpress.XtraEditors.SimpleButton();
            this.xgridResult = new DevExpress.XtraGrid.GridControl();
            this.xgridViewResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xbeDirectory = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::EmailGeter.FrmWait), true, true);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xbePSTFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgridResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbeDirectory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xbePSTFile);
            this.layoutControl1.Controls.Add(this.xsbAnalysis);
            this.layoutControl1.Controls.Add(this.xgridResult);
            this.layoutControl1.Controls.Add(this.xbeDirectory);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(606, 419);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xbePSTFile
            // 
            this.xbePSTFile.Location = new System.Drawing.Point(102, 36);
            this.xbePSTFile.Name = "xbePSTFile";
            this.xbePSTFile.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.xbePSTFile.Size = new System.Drawing.Size(492, 20);
            this.xbePSTFile.StyleController = this.layoutControl1;
            this.xbePSTFile.TabIndex = 4;
            this.xbePSTFile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.xbePSTFile_ButtonClick);
            // 
            // xsbAnalysis
            // 
            this.xsbAnalysis.Location = new System.Drawing.Point(507, 385);
            this.xsbAnalysis.Name = "xsbAnalysis";
            this.xsbAnalysis.Size = new System.Drawing.Size(87, 22);
            this.xsbAnalysis.StyleController = this.layoutControl1;
            this.xsbAnalysis.TabIndex = 1;
            this.xsbAnalysis.Text = "Analysis";
            this.xsbAnalysis.Click += new System.EventHandler(this.xsbAnalysis_Click);
            // 
            // xgridResult
            // 
            this.xgridResult.Location = new System.Drawing.Point(102, 60);
            this.xgridResult.MainView = this.xgridViewResult;
            this.xgridResult.Name = "xgridResult";
            this.xgridResult.Size = new System.Drawing.Size(492, 321);
            this.xgridResult.TabIndex = 1;
            this.xgridResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.xgridViewResult});
            // 
            // xgridViewResult
            // 
            this.xgridViewResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn2});
            this.xgridViewResult.GridControl = this.xgridResult;
            this.xgridViewResult.Name = "xgridViewResult";
            this.xgridViewResult.OptionsBehavior.Editable = false;
            this.xgridViewResult.OptionsSelection.MultiSelect = true;
            this.xgridViewResult.OptionsView.ColumnAutoWidth = false;
            this.xgridViewResult.OptionsView.ShowFooter = true;
            this.xgridViewResult.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Our Ref.";
            this.gridColumn3.FieldName = "CaseNo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "FileName", "{0}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 126;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Recipient";
            this.gridColumn4.FieldName = "Recipient";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 168;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Address";
            this.gridColumn5.FieldName = "Address";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 130;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Bcc";
            this.gridColumn6.FieldName = "Bcc";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Email Subject";
            this.gridColumn2.FieldName = "Subject";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 154;
            // 
            // xbeDirectory
            // 
            this.xbeDirectory.Location = new System.Drawing.Point(102, 12);
            this.xbeDirectory.Name = "xbeDirectory";
            this.xbeDirectory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.xbeDirectory.Size = new System.Drawing.Size(492, 20);
            this.xbeDirectory.StyleController = this.layoutControl1;
            this.xbeDirectory.TabIndex = 1;
            this.xbeDirectory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.xbeDirectory_ButtonClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(606, 419);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xbeDirectory;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(586, 24);
            this.layoutControlItem1.Text = "MSG files folder:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.xgridResult;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(586, 325);
            this.layoutControlItem2.Text = "Result:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.xsbAnalysis;
            this.layoutControlItem3.Location = new System.Drawing.Point(495, 373);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(91, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(91, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(91, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 373);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(495, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.xbePSTFile;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(586, 24);
            this.layoutControlItem4.Text = "PST file\'s path:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(87, 14);
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PST File|*.pst";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 419);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmMain";
            this.Text = "Email Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xbePSTFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgridResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xgridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbeDirectory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ButtonEdit xbeDirectory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl xgridResult;
        private DevExpress.XtraGrid.Views.Grid.GridView xgridViewResult;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton xsbAnalysis;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.ButtonEdit xbePSTFile;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

