namespace Eye_Center.RP
{
    partial class ViweReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_name_search = new DevExpress.XtraEditors.SimpleButton();
            this.txt_name_search = new DevExpress.XtraEditors.TextEdit();
            this.grob_BondDateRP = new System.Windows.Forms.GroupBox();
            this.btn_lod_RP = new DevExpress.XtraEditors.SimpleButton();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentViewerRibbonController1 = new DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_search.Properties)).BeginInit();
            this.grob_BondDateRP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_name_search);
            this.panelControl1.Controls.Add(this.txt_name_search);
            this.panelControl1.Controls.Add(this.grob_BondDateRP);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1122, 67);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // btn_name_search
            // 
            this.btn_name_search.Location = new System.Drawing.Point(14, 22);
            this.btn_name_search.Name = "btn_name_search";
            this.btn_name_search.Size = new System.Drawing.Size(110, 29);
            this.btn_name_search.TabIndex = 2;
            this.btn_name_search.Text = "تحميل التقرير";
            this.btn_name_search.Visible = false;
            this.btn_name_search.Click += new System.EventHandler(this.btn_name_search_Click);
            // 
            // txt_name_search
            // 
            this.txt_name_search.Location = new System.Drawing.Point(132, 26);
            this.txt_name_search.Name = "txt_name_search";
            this.txt_name_search.Size = new System.Drawing.Size(195, 23);
            this.txt_name_search.TabIndex = 4;
            this.txt_name_search.Visible = false;
            // 
            // grob_BondDateRP
            // 
            this.grob_BondDateRP.Controls.Add(this.simpleButton1);
            this.grob_BondDateRP.Controls.Add(this.btn_lod_RP);
            this.grob_BondDateRP.Controls.Add(this.dateFrom);
            this.grob_BondDateRP.Controls.Add(this.labelControl2);
            this.grob_BondDateRP.Controls.Add(this.dateTo);
            this.grob_BondDateRP.Controls.Add(this.labelControl1);
            this.grob_BondDateRP.Location = new System.Drawing.Point(333, 6);
            this.grob_BondDateRP.Name = "grob_BondDateRP";
            this.grob_BondDateRP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grob_BondDateRP.Size = new System.Drawing.Size(775, 56);
            this.grob_BondDateRP.TabIndex = 3;
            this.grob_BondDateRP.TabStop = false;
            this.grob_BondDateRP.Visible = false;
            // 
            // btn_lod_RP
            // 
            this.btn_lod_RP.Location = new System.Drawing.Point(143, 21);
            this.btn_lod_RP.Name = "btn_lod_RP";
            this.btn_lod_RP.Size = new System.Drawing.Size(110, 29);
            this.btn_lod_RP.TabIndex = 2;
            this.btn_lod_RP.Text = "السندات";
            this.btn_lod_RP.Click += new System.EventHandler(this.btn_lod_RP_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = null;
            this.dateFrom.Location = new System.Drawing.Point(517, 25);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "yyyy/mm/dd";
            this.dateFrom.Size = new System.Drawing.Size(171, 23);
            this.dateFrom.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(459, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "الى تاريخ";
            // 
            // dateTo
            // 
            this.dateTo.EditValue = null;
            this.dateTo.Location = new System.Drawing.Point(281, 25);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "yyyy/mm/dd";
            this.dateTo.Size = new System.Drawing.Size(171, 23);
            this.dateTo.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(696, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "من تاريخ";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.crystalReportViewer1);
            this.panelControl2.Controls.Add(this.ribbonStatusBar1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 67);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1122, 523);
            this.panelControl2.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1118, 499);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(2, 501);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1118, 20);
            // 
            // documentViewerRibbonController1
            // 
            this.documentViewerRibbonController1.RibbonStatusBar = this.ribbonStatusBar1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(6, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 29);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "المرضى";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ViweReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 590);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ViweReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViweReports";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ViweReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_name_search.Properties)).EndInit();
            this.grob_BondDateRP.ResumeLayout(false);
            this.grob_BondDateRP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController documentViewerRibbonController1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        public System.Windows.Forms.GroupBox grob_BondDateRP;
        private DevExpress.XtraEditors.SimpleButton btn_lod_RP;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.SimpleButton btn_name_search;
        public DevExpress.XtraEditors.TextEdit txt_name_search;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}