namespace Eye_Center.PL
{
    partial class Follow_up
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Follow_up));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtNameFollow_up = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDFOLL = new System.Windows.Forms.TextBox();
            this.txtIDFollow_up = new System.Windows.Forms.TextBox();
            this.txtNoFileFollow_up = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new DevExpress.XtraGrid.GridControl();
            this.followupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eye_CenterDataSet6 = new Eye_Center.Eye_CenterDataSet6();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFollowUpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatient_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTreatment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrintFollowUp = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewSurgery = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateSurgery = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchSurgery = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddSurgery = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.dtbDateFollow = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.txtResultFollow = new System.Windows.Forms.TextBox();
            this.follow_upTableAdapter = new Eye_Center.Eye_CenterDataSet6TableAdapters.Follow_upTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.followupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_CenterDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtNameFollow_up);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label15);
            this.panelControl1.Controls.Add(this.label13);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtIDFOLL);
            this.panelControl1.Controls.Add(this.txtIDFollow_up);
            this.panelControl1.Controls.Add(this.txtNoFileFollow_up);
            this.panelControl1.Controls.Add(this.txtNote);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1391, 117);
            this.panelControl1.TabIndex = 0;
            // 
            // txtNameFollow_up
            // 
            this.txtNameFollow_up.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNameFollow_up.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNameFollow_up.Font = new System.Drawing.Font("Arial", 17F);
            this.txtNameFollow_up.FormattingEnabled = true;
            this.txtNameFollow_up.Location = new System.Drawing.Point(896, 40);
            this.txtNameFollow_up.Name = "txtNameFollow_up";
            this.txtNameFollow_up.Size = new System.Drawing.Size(299, 40);
            this.txtNameFollow_up.TabIndex = 30;
            this.txtNameFollow_up.SelectedIndexChanged += new System.EventHandler(this.txtNameFollow_up_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1201, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "اسم الريض";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(433, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 23);
            this.label15.TabIndex = 26;
            this.label15.Text = "رقم العودة";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(608, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "رقم المريض";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(801, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "رقم الملف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "الملاحظات";
            // 
            // txtIDFOLL
            // 
            this.txtIDFOLL.Font = new System.Drawing.Font("Arial", 17F);
            this.txtIDFOLL.Location = new System.Drawing.Point(341, 40);
            this.txtIDFOLL.Name = "txtIDFOLL";
            this.txtIDFOLL.ReadOnly = true;
            this.txtIDFOLL.Size = new System.Drawing.Size(86, 40);
            this.txtIDFOLL.TabIndex = 21;
            this.txtIDFOLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDFollow_up
            // 
            this.txtIDFollow_up.Font = new System.Drawing.Font("Arial", 17F);
            this.txtIDFollow_up.Location = new System.Drawing.Point(516, 37);
            this.txtIDFollow_up.Name = "txtIDFollow_up";
            this.txtIDFollow_up.ReadOnly = true;
            this.txtIDFollow_up.Size = new System.Drawing.Size(86, 40);
            this.txtIDFollow_up.TabIndex = 22;
            this.txtIDFollow_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoFileFollow_up
            // 
            this.txtNoFileFollow_up.Font = new System.Drawing.Font("Arial", 17F);
            this.txtNoFileFollow_up.Location = new System.Drawing.Point(713, 40);
            this.txtNoFileFollow_up.Name = "txtNoFileFollow_up";
            this.txtNoFileFollow_up.Size = new System.Drawing.Size(80, 40);
            this.txtNoFileFollow_up.TabIndex = 23;
            this.txtNoFileFollow_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial", 17F);
            this.txtNote.Location = new System.Drawing.Point(5, 19);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(245, 80);
            this.txtNote.TabIndex = 24;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dataGridView1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 374);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1391, 488);
            this.panelControl2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.DataSource = this.followupBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.MainView = this.gridView1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1387, 484);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // followupBindingSource
            // 
            this.followupBindingSource.DataMember = "Follow_up";
            this.followupBindingSource.DataSource = this.eye_CenterDataSet6;
            // 
            // eye_CenterDataSet6
            // 
            this.eye_CenterDataSet6.DataSetName = "Eye_CenterDataSet6";
            this.eye_CenterDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFollowUpID,
            this.colNoFile,
            this.colPatient_id,
            this.colDate,
            this.colResult,
            this.colTreatment,
            this.colNote1});
            this.gridView1.GridControl = this.dataGridView1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.ShownEditor += new System.EventHandler(this.gridView1_ShownEditor);
            // 
            // colFollowUpID
            // 
            this.colFollowUpID.FieldName = "FollowUpID";
            this.colFollowUpID.MinWidth = 25;
            this.colFollowUpID.Name = "colFollowUpID";
            this.colFollowUpID.Visible = true;
            this.colFollowUpID.VisibleIndex = 0;
            this.colFollowUpID.Width = 94;
            // 
            // colNoFile
            // 
            this.colNoFile.FieldName = "NoFile";
            this.colNoFile.MinWidth = 25;
            this.colNoFile.Name = "colNoFile";
            this.colNoFile.Visible = true;
            this.colNoFile.VisibleIndex = 1;
            this.colNoFile.Width = 94;
            // 
            // colPatient_id
            // 
            this.colPatient_id.FieldName = "Patient_id";
            this.colPatient_id.MinWidth = 25;
            this.colPatient_id.Name = "colPatient_id";
            this.colPatient_id.Visible = true;
            this.colPatient_id.VisibleIndex = 2;
            this.colPatient_id.Width = 94;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            this.colDate.Width = 94;
            // 
            // colResult
            // 
            this.colResult.FieldName = "Result";
            this.colResult.MinWidth = 25;
            this.colResult.Name = "colResult";
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 4;
            this.colResult.Width = 94;
            // 
            // colTreatment
            // 
            this.colTreatment.FieldName = "Treatment";
            this.colTreatment.MinWidth = 25;
            this.colTreatment.Name = "colTreatment";
            this.colTreatment.Visible = true;
            this.colTreatment.VisibleIndex = 5;
            this.colTreatment.Width = 94;
            // 
            // colNote1
            // 
            this.colNote1.FieldName = "Note1";
            this.colNote1.MinWidth = 25;
            this.colNote1.Name = "colNote1";
            this.colNote1.Visible = true;
            this.colNote1.VisibleIndex = 6;
            this.colNote1.Width = 94;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnPrintFollowUp);
            this.panelControl3.Controls.Add(this.btnNewSurgery);
            this.panelControl3.Controls.Add(this.btnUpdateSurgery);
            this.panelControl3.Controls.Add(this.btnSearchSurgery);
            this.panelControl3.Controls.Add(this.btnAddSurgery);
            this.panelControl3.Controls.Add(this.txtSearch);
            this.panelControl3.Controls.Add(this.dtbDateFollow);
            this.panelControl3.Controls.Add(this.label14);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.txtTreatment);
            this.panelControl3.Controls.Add(this.txtResultFollow);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 117);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1391, 257);
            this.panelControl3.TabIndex = 2;
            // 
            // btnPrintFollowUp
            // 
            this.btnPrintFollowUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintFollowUp.ImageOptions.Image")));
            this.btnPrintFollowUp.Location = new System.Drawing.Point(15, 204);
            this.btnPrintFollowUp.Name = "btnPrintFollowUp";
            this.btnPrintFollowUp.Size = new System.Drawing.Size(222, 38);
            this.btnPrintFollowUp.TabIndex = 29;
            this.btnPrintFollowUp.Text = "طباعة البيانات";
            this.btnPrintFollowUp.Click += new System.EventHandler(this.btnPrintFollowUp_Click);
            // 
            // btnNewSurgery
            // 
            this.btnNewSurgery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewSurgery.ImageOptions.Image")));
            this.btnNewSurgery.Location = new System.Drawing.Point(282, 202);
            this.btnNewSurgery.Name = "btnNewSurgery";
            this.btnNewSurgery.Size = new System.Drawing.Size(226, 40);
            this.btnNewSurgery.TabIndex = 28;
            this.btnNewSurgery.Text = "إفراغ كل الحقول";
            this.btnNewSurgery.Click += new System.EventHandler(this.btnNewSurgery_Click);
            // 
            // btnUpdateSurgery
            // 
            this.btnUpdateSurgery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSurgery.ImageOptions.Image")));
            this.btnUpdateSurgery.Location = new System.Drawing.Point(572, 202);
            this.btnUpdateSurgery.Name = "btnUpdateSurgery";
            this.btnUpdateSurgery.Size = new System.Drawing.Size(226, 40);
            this.btnUpdateSurgery.TabIndex = 27;
            this.btnUpdateSurgery.Text = "تعديل بيانات المريض";
            this.btnUpdateSurgery.Click += new System.EventHandler(this.btnUpdateSurgery_Click);
            // 
            // btnSearchSurgery
            // 
            this.btnSearchSurgery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchSurgery.ImageOptions.Image")));
            this.btnSearchSurgery.Location = new System.Drawing.Point(1307, 197);
            this.btnSearchSurgery.Name = "btnSearchSurgery";
            this.btnSearchSurgery.Size = new System.Drawing.Size(81, 38);
            this.btnSearchSurgery.TabIndex = 31;
            this.btnSearchSurgery.Text = "بحث";
            this.btnSearchSurgery.Click += new System.EventHandler(this.btnSearchSurgery_Click);
            // 
            // btnAddSurgery
            // 
            this.btnAddSurgery.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSurgery.ImageOptions.Image")));
            this.btnAddSurgery.Location = new System.Drawing.Point(823, 202);
            this.btnAddSurgery.Name = "btnAddSurgery";
            this.btnAddSurgery.Size = new System.Drawing.Size(226, 40);
            this.btnAddSurgery.TabIndex = 26;
            this.btnAddSurgery.Text = "حفظ بيانات المريض";
            this.btnAddSurgery.Click += new System.EventHandler(this.btnAddSurgery_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1079, 199);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtSearch.Size = new System.Drawing.Size(226, 34);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.ToolTip = "البحث";
            this.txtSearch.ToolTipTitle = "البحث";
            // 
            // dtbDateFollow
            // 
            this.dtbDateFollow.CustomFormat = "yyyy-mm-dd hh:mm:ss";
            this.dtbDateFollow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtbDateFollow.Location = new System.Drawing.Point(209, 60);
            this.dtbDateFollow.Name = "dtbDateFollow";
            this.dtbDateFollow.ShowUpDown = true;
            this.dtbDateFollow.Size = new System.Drawing.Size(354, 32);
            this.dtbDateFollow.TabIndex = 20;
            this.dtbDateFollow.Value = new System.DateTime(2019, 12, 17, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(606, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 23);
            this.label14.TabIndex = 23;
            this.label14.Text = ": Treatment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = ": Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = ": Date Follow";
            // 
            // txtTreatment
            // 
            this.txtTreatment.Font = new System.Drawing.Font("Arial", 13F);
            this.txtTreatment.Location = new System.Drawing.Point(743, 67);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(407, 80);
            this.txtTreatment.TabIndex = 22;
            this.txtTreatment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultFollow
            // 
            this.txtResultFollow.Font = new System.Drawing.Font("Arial", 13F);
            this.txtResultFollow.Location = new System.Drawing.Point(209, 121);
            this.txtResultFollow.Name = "txtResultFollow";
            this.txtResultFollow.Size = new System.Drawing.Size(354, 32);
            this.txtResultFollow.TabIndex = 21;
            this.txtResultFollow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // follow_upTableAdapter
            // 
            this.follow_upTableAdapter.ClearBeforeFill = true;
            // 
            // Follow_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Follow_up";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1391, 862);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.followupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_CenterDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox txtNameFollow_up;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDFOLL;
        private System.Windows.Forms.TextBox txtIDFollow_up;
        private System.Windows.Forms.TextBox txtNoFileFollow_up;
        private System.Windows.Forms.TextBox txtNote;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dataGridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.DateTimePicker dtbDateFollow;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.TextBox txtResultFollow;
        private DevExpress.XtraEditors.SimpleButton btnPrintFollowUp;
        private DevExpress.XtraEditors.SimpleButton btnNewSurgery;
        private DevExpress.XtraEditors.SimpleButton btnUpdateSurgery;
        private DevExpress.XtraEditors.SimpleButton btnSearchSurgery;
        private DevExpress.XtraEditors.SimpleButton btnAddSurgery;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private System.Windows.Forms.BindingSource followupBindingSource;
        private Eye_CenterDataSet6 eye_CenterDataSet6;
        private DevExpress.XtraGrid.Columns.GridColumn colFollowUpID;
        private DevExpress.XtraGrid.Columns.GridColumn colNoFile;
        private DevExpress.XtraGrid.Columns.GridColumn colPatient_id;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraGrid.Columns.GridColumn colTreatment;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private Eye_CenterDataSet6TableAdapters.Follow_upTableAdapter follow_upTableAdapter;
    }
}
