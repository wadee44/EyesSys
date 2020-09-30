namespace Eye_Center.PL
{
    partial class Local_Narcosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Local_Narcosis));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtNameLocal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDLOCAL = new System.Windows.Forms.TextBox();
            this.txtIDGlobal = new System.Windows.Forms.TextBox();
            this.txtNoFileLocal = new System.Windows.Forms.TextBox();
            this.txtNoteLocal = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new DevExpress.XtraGrid.GridControl();
            this.localNarcosisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eye_CenterDataSet8 = new Eye_Center.Eye_CenterDataSet8();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNoFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViral_Marks_and_HIV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurgery_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCBC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtBP = new System.Windows.Forms.TextBox();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.txtViral_Marks_and_HIV = new System.Windows.Forms.TextBox();
            this.txtCBC = new System.Windows.Forms.TextBox();
            this.btnPrintLocal = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewLocal = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateLocal = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchLocal = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddLocal = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.local_NarcosisTableAdapter = new Eye_Center.Eye_CenterDataSet8TableAdapters.Local_NarcosisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localNarcosisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_CenterDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtNameLocal);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label15);
            this.panelControl1.Controls.Add(this.label13);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtIDLOCAL);
            this.panelControl1.Controls.Add(this.txtIDGlobal);
            this.panelControl1.Controls.Add(this.txtNoFileLocal);
            this.panelControl1.Controls.Add(this.txtNoteLocal);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1391, 110);
            this.panelControl1.TabIndex = 0;
            // 
            // txtNameLocal
            // 
            this.txtNameLocal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNameLocal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNameLocal.Font = new System.Drawing.Font("Arial", 17F);
            this.txtNameLocal.FormattingEnabled = true;
            this.txtNameLocal.Location = new System.Drawing.Point(952, 33);
            this.txtNameLocal.Name = "txtNameLocal";
            this.txtNameLocal.Size = new System.Drawing.Size(330, 40);
            this.txtNameLocal.TabIndex = 30;
            this.txtNameLocal.SelectedIndexChanged += new System.EventHandler(this.txtNameLocal_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1288, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "اسم المريض";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(478, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 23);
            this.label15.TabIndex = 26;
            this.label15.Text = "رقم العملية";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(679, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "رقم المريض";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(872, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "رقم الملف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "الملاحظات";
            // 
            // txtIDLOCAL
            // 
            this.txtIDLOCAL.Font = new System.Drawing.Font("Arial", 17F);
            this.txtIDLOCAL.Location = new System.Drawing.Point(386, 33);
            this.txtIDLOCAL.Name = "txtIDLOCAL";
            this.txtIDLOCAL.ReadOnly = true;
            this.txtIDLOCAL.Size = new System.Drawing.Size(86, 40);
            this.txtIDLOCAL.TabIndex = 21;
            this.txtIDLOCAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDGlobal
            // 
            this.txtIDGlobal.Font = new System.Drawing.Font("Arial", 17F);
            this.txtIDGlobal.Location = new System.Drawing.Point(587, 30);
            this.txtIDGlobal.Name = "txtIDGlobal";
            this.txtIDGlobal.ReadOnly = true;
            this.txtIDGlobal.Size = new System.Drawing.Size(86, 40);
            this.txtIDGlobal.TabIndex = 22;
            this.txtIDGlobal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoFileLocal
            // 
            this.txtNoFileLocal.Font = new System.Drawing.Font("Arial", 17F);
            this.txtNoFileLocal.Location = new System.Drawing.Point(784, 33);
            this.txtNoFileLocal.Name = "txtNoFileLocal";
            this.txtNoFileLocal.Size = new System.Drawing.Size(80, 40);
            this.txtNoFileLocal.TabIndex = 23;
            this.txtNoFileLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoteLocal
            // 
            this.txtNoteLocal.Font = new System.Drawing.Font("Arial", 17F);
            this.txtNoteLocal.Location = new System.Drawing.Point(19, 15);
            this.txtNoteLocal.Multiline = true;
            this.txtNoteLocal.Name = "txtNoteLocal";
            this.txtNoteLocal.Size = new System.Drawing.Size(275, 80);
            this.txtNoteLocal.TabIndex = 24;
            this.txtNoteLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dataGridView1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 372);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1391, 490);
            this.panelControl2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.DataSource = this.localNarcosisBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.MainView = this.gridView1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1387, 486);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // localNarcosisBindingSource
            // 
            this.localNarcosisBindingSource.DataMember = "Local_Narcosis";
            this.localNarcosisBindingSource.DataSource = this.eye_CenterDataSet8;
            // 
            // eye_CenterDataSet8
            // 
            this.eye_CenterDataSet8.DataSetName = "Eye_CenterDataSet8";
            this.eye_CenterDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNoFile,
            this.colBP,
            this.colViral_Marks_and_HIV,
            this.colSurgery_id,
            this.colCBC,
            this.colBS,
            this.colNote1});
            this.gridView1.GridControl = this.dataGridView1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            // 
            // colNoFile
            // 
            this.colNoFile.FieldName = "NoFile";
            this.colNoFile.MinWidth = 25;
            this.colNoFile.Name = "colNoFile";
            this.colNoFile.Visible = true;
            this.colNoFile.VisibleIndex = 0;
            this.colNoFile.Width = 94;
            // 
            // colBP
            // 
            this.colBP.FieldName = "BP";
            this.colBP.MinWidth = 25;
            this.colBP.Name = "colBP";
            this.colBP.Visible = true;
            this.colBP.VisibleIndex = 1;
            this.colBP.Width = 94;
            // 
            // colViral_Marks_and_HIV
            // 
            this.colViral_Marks_and_HIV.FieldName = "Viral_Marks_and_HIV";
            this.colViral_Marks_and_HIV.MinWidth = 25;
            this.colViral_Marks_and_HIV.Name = "colViral_Marks_and_HIV";
            this.colViral_Marks_and_HIV.Visible = true;
            this.colViral_Marks_and_HIV.VisibleIndex = 2;
            this.colViral_Marks_and_HIV.Width = 94;
            // 
            // colSurgery_id
            // 
            this.colSurgery_id.FieldName = "Surgery_id";
            this.colSurgery_id.MinWidth = 25;
            this.colSurgery_id.Name = "colSurgery_id";
            this.colSurgery_id.Visible = true;
            this.colSurgery_id.VisibleIndex = 3;
            this.colSurgery_id.Width = 94;
            // 
            // colCBC
            // 
            this.colCBC.FieldName = "CBC";
            this.colCBC.MinWidth = 25;
            this.colCBC.Name = "colCBC";
            this.colCBC.Visible = true;
            this.colCBC.VisibleIndex = 4;
            this.colCBC.Width = 94;
            // 
            // colBS
            // 
            this.colBS.FieldName = "BS";
            this.colBS.MinWidth = 25;
            this.colBS.Name = "colBS";
            this.colBS.Visible = true;
            this.colBS.VisibleIndex = 5;
            this.colBS.Width = 94;
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
            this.panelControl3.Controls.Add(this.label9);
            this.panelControl3.Controls.Add(this.label14);
            this.panelControl3.Controls.Add(this.label10);
            this.panelControl3.Controls.Add(this.label6);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.txtNote);
            this.panelControl3.Controls.Add(this.txtBP);
            this.panelControl3.Controls.Add(this.txtBS);
            this.panelControl3.Controls.Add(this.txtViral_Marks_and_HIV);
            this.panelControl3.Controls.Add(this.txtCBC);
            this.panelControl3.Controls.Add(this.btnPrintLocal);
            this.panelControl3.Controls.Add(this.btnNewLocal);
            this.panelControl3.Controls.Add(this.btnUpdateLocal);
            this.panelControl3.Controls.Add(this.btnSearchLocal);
            this.panelControl3.Controls.Add(this.btnAddLocal);
            this.panelControl3.Controls.Add(this.txtSearch);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 110);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1391, 262);
            this.panelControl3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 23);
            this.label9.TabIndex = 60;
            this.label9.Text = ": Viral Marks/HIV";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(541, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 23);
            this.label14.TabIndex = 61;
            this.label14.Text = ": Note";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(119, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 22);
            this.label10.TabIndex = 62;
            this.label10.Text = ": BS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = ": CBC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 64;
            this.label4.Text = ": BP";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial", 13F);
            this.txtNote.Location = new System.Drawing.Point(610, 49);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(407, 80);
            this.txtNote.TabIndex = 59;
            this.txtNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBP
            // 
            this.txtBP.Font = new System.Drawing.Font("Arial", 13F);
            this.txtBP.Location = new System.Drawing.Point(181, 49);
            this.txtBP.Name = "txtBP";
            this.txtBP.Size = new System.Drawing.Size(354, 32);
            this.txtBP.TabIndex = 56;
            this.txtBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBS
            // 
            this.txtBS.Font = new System.Drawing.Font("Arial", 13F);
            this.txtBS.Location = new System.Drawing.Point(181, 125);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(354, 32);
            this.txtBS.TabIndex = 58;
            this.txtBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtViral_Marks_and_HIV
            // 
            this.txtViral_Marks_and_HIV.Font = new System.Drawing.Font("Arial", 13F);
            this.txtViral_Marks_and_HIV.Location = new System.Drawing.Point(181, 6);
            this.txtViral_Marks_and_HIV.Name = "txtViral_Marks_and_HIV";
            this.txtViral_Marks_and_HIV.Size = new System.Drawing.Size(354, 32);
            this.txtViral_Marks_and_HIV.TabIndex = 55;
            this.txtViral_Marks_and_HIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCBC
            // 
            this.txtCBC.Font = new System.Drawing.Font("Arial", 13F);
            this.txtCBC.Location = new System.Drawing.Point(181, 87);
            this.txtCBC.Name = "txtCBC";
            this.txtCBC.Size = new System.Drawing.Size(354, 32);
            this.txtCBC.TabIndex = 57;
            this.txtCBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrintLocal
            // 
            this.btnPrintLocal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintLocal.ImageOptions.Image")));
            this.btnPrintLocal.Location = new System.Drawing.Point(137, 198);
            this.btnPrintLocal.Name = "btnPrintLocal";
            this.btnPrintLocal.Size = new System.Drawing.Size(226, 38);
            this.btnPrintLocal.TabIndex = 54;
            this.btnPrintLocal.Text = "طباعة البيانات";
            this.btnPrintLocal.Click += new System.EventHandler(this.btnPrintLocal_Click);
            // 
            // btnNewLocal
            // 
            this.btnNewLocal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewLocal.ImageOptions.Image")));
            this.btnNewLocal.Location = new System.Drawing.Point(425, 198);
            this.btnNewLocal.Name = "btnNewLocal";
            this.btnNewLocal.Size = new System.Drawing.Size(226, 40);
            this.btnNewLocal.TabIndex = 53;
            this.btnNewLocal.Text = "إفراغ كل الحقول";
            this.btnNewLocal.Click += new System.EventHandler(this.btnNewLocal_Click);
            // 
            // btnUpdateLocal
            // 
            this.btnUpdateLocal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateLocal.ImageOptions.Image")));
            this.btnUpdateLocal.Location = new System.Drawing.Point(708, 198);
            this.btnUpdateLocal.Name = "btnUpdateLocal";
            this.btnUpdateLocal.Size = new System.Drawing.Size(226, 40);
            this.btnUpdateLocal.TabIndex = 50;
            this.btnUpdateLocal.Text = "تعديل بيانات المريض";
            this.btnUpdateLocal.Click += new System.EventHandler(this.btnUpdateLocal_Click);
            // 
            // btnSearchLocal
            // 
            this.btnSearchLocal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchLocal.ImageOptions.Image")));
            this.btnSearchLocal.Location = new System.Drawing.Point(1275, 48);
            this.btnSearchLocal.Name = "btnSearchLocal";
            this.btnSearchLocal.Size = new System.Drawing.Size(81, 38);
            this.btnSearchLocal.TabIndex = 52;
            this.btnSearchLocal.Text = "بحث";
            this.btnSearchLocal.Click += new System.EventHandler(this.btnSearchLocal_Click);
            // 
            // btnAddLocal
            // 
            this.btnAddLocal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLocal.ImageOptions.Image")));
            this.btnAddLocal.Location = new System.Drawing.Point(984, 198);
            this.btnAddLocal.Name = "btnAddLocal";
            this.btnAddLocal.Size = new System.Drawing.Size(226, 40);
            this.btnAddLocal.TabIndex = 49;
            this.btnAddLocal.Text = "حفظ بيانات المريض";
            this.btnAddLocal.Click += new System.EventHandler(this.btnAddLocal_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1047, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtSearch.Size = new System.Drawing.Size(226, 34);
            this.txtSearch.TabIndex = 51;
            this.txtSearch.ToolTip = "البحث";
            this.txtSearch.ToolTipTitle = "البحث";
            // 
            // local_NarcosisTableAdapter
            // 
            this.local_NarcosisTableAdapter.ClearBeforeFill = true;
            // 
            // Local_Narcosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Local_Narcosis";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1391, 862);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localNarcosisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_CenterDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDLOCAL;
        private System.Windows.Forms.TextBox txtIDGlobal;
        private System.Windows.Forms.TextBox txtNoFileLocal;
        private System.Windows.Forms.TextBox txtNoteLocal;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.ComboBox txtNameLocal;
        private DevExpress.XtraGrid.GridControl dataGridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtBP;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.TextBox txtViral_Marks_and_HIV;
        private System.Windows.Forms.TextBox txtCBC;
        private DevExpress.XtraEditors.SimpleButton btnPrintLocal;
        private DevExpress.XtraEditors.SimpleButton btnNewLocal;
        private DevExpress.XtraEditors.SimpleButton btnUpdateLocal;
        private DevExpress.XtraEditors.SimpleButton btnSearchLocal;
        private DevExpress.XtraEditors.SimpleButton btnAddLocal;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private System.Windows.Forms.BindingSource localNarcosisBindingSource;
        private Eye_CenterDataSet8 eye_CenterDataSet8;
        private DevExpress.XtraGrid.Columns.GridColumn colNoFile;
        private DevExpress.XtraGrid.Columns.GridColumn colBP;
        private DevExpress.XtraGrid.Columns.GridColumn colViral_Marks_and_HIV;
        private DevExpress.XtraGrid.Columns.GridColumn colSurgery_id;
        private DevExpress.XtraGrid.Columns.GridColumn colCBC;
        private DevExpress.XtraGrid.Columns.GridColumn colBS;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private Eye_CenterDataSet8TableAdapters.Local_NarcosisTableAdapter local_NarcosisTableAdapter;
    }
}
