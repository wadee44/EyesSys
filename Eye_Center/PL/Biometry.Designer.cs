namespace Eye_Center.PL
{
    partial class Biometry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biometry));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtNameBiometry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDBIO = new System.Windows.Forms.TextBox();
            this.txtIDBiometry = new System.Windows.Forms.TextBox();
            this.txtNoFileBiometry = new System.Windows.Forms.TextBox();
            this.txtNoteBiometry = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new DevExpress.XtraGrid.GridControl();
            this.biometryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eye_CenterDataSet4 = new Eye_Center.Eye_CenterDataSet4();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBiometryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOD_or_OS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colK2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAxial_length = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colA_Constant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAC_and_IOL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPC_and_IOL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colB_Scan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPatient_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdioODBiometry = new System.Windows.Forms.RadioButton();
            this.rdioOSBiometry = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC_ScanBiometry = new System.Windows.Forms.TextBox();
            this.txtKtwoBiometry = new System.Windows.Forms.TextBox();
            this.txtAXIABiometry = new System.Windows.Forms.TextBox();
            this.txtKoneBiometry = new System.Windows.Forms.TextBox();
            this.txtAandC_iolBiometry = new System.Windows.Forms.TextBox();
            this.txtPandC_iolBiometry = new System.Windows.Forms.TextBox();
            this.txtA_CONBiometry = new System.Windows.Forms.TextBox();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewBiometry = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateBiometry = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchBiometry = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddBiometry = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.biometryTableAdapter = new Eye_Center.Eye_CenterDataSet4TableAdapters.BiometryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biometryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_CenterDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtNameBiometry);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label15);
            this.panelControl1.Controls.Add(this.label13);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtIDBIO);
            this.panelControl1.Controls.Add(this.txtIDBiometry);
            this.panelControl1.Controls.Add(this.txtNoFileBiometry);
            this.panelControl1.Controls.Add(this.txtNoteBiometry);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1391, 109);
            this.panelControl1.TabIndex = 0;
            // 
            // txtNameBiometry
            // 
            this.txtNameBiometry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNameBiometry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNameBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtNameBiometry.FormattingEnabled = true;
            this.txtNameBiometry.Location = new System.Drawing.Point(886, 27);
            this.txtNameBiometry.Name = "txtNameBiometry";
            this.txtNameBiometry.Size = new System.Drawing.Size(339, 40);
            this.txtNameBiometry.TabIndex = 30;
            this.txtNameBiometry.SelectedIndexChanged += new System.EventHandler(this.txtNameBiometry_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1242, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "اسم المريض";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(406, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 23);
            this.label15.TabIndex = 26;
            this.label15.Text = "رقم الفحص";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(607, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "رقم المريض";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(800, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "رقم الملف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "الملاحظات";
            // 
            // txtIDBIO
            // 
            this.txtIDBIO.Font = new System.Drawing.Font("Arial", 17F);
            this.txtIDBIO.Location = new System.Drawing.Point(314, 27);
            this.txtIDBIO.Name = "txtIDBIO";
            this.txtIDBIO.ReadOnly = true;
            this.txtIDBIO.Size = new System.Drawing.Size(86, 40);
            this.txtIDBIO.TabIndex = 21;
            this.txtIDBIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDBiometry
            // 
            this.txtIDBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtIDBiometry.Location = new System.Drawing.Point(515, 24);
            this.txtIDBiometry.Name = "txtIDBiometry";
            this.txtIDBiometry.ReadOnly = true;
            this.txtIDBiometry.Size = new System.Drawing.Size(86, 40);
            this.txtIDBiometry.TabIndex = 22;
            this.txtIDBiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoFileBiometry
            // 
            this.txtNoFileBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtNoFileBiometry.Location = new System.Drawing.Point(712, 27);
            this.txtNoFileBiometry.Name = "txtNoFileBiometry";
            this.txtNoFileBiometry.Size = new System.Drawing.Size(80, 40);
            this.txtNoFileBiometry.TabIndex = 23;
            this.txtNoFileBiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoteBiometry
            // 
            this.txtNoteBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtNoteBiometry.Location = new System.Drawing.Point(5, 3);
            this.txtNoteBiometry.Multiline = true;
            this.txtNoteBiometry.Name = "txtNoteBiometry";
            this.txtNoteBiometry.Size = new System.Drawing.Size(220, 98);
            this.txtNoteBiometry.TabIndex = 24;
            this.txtNoteBiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dataGridView1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 433);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1391, 429);
            this.panelControl2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.DataSource = this.biometryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.MainView = this.gridView1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1387, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // biometryBindingSource
            // 
            this.biometryBindingSource.DataMember = "Biometry";
            this.biometryBindingSource.DataSource = this.eye_CenterDataSet4;
            // 
            // eye_CenterDataSet4
            // 
            this.eye_CenterDataSet4.DataSetName = "Eye_CenterDataSet4";
            this.eye_CenterDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBiometryID,
            this.colOD_or_OS,
            this.colK1,
            this.colK2,
            this.colAxial_length,
            this.colA_Constant,
            this.colAC_and_IOL,
            this.colPC_and_IOL,
            this.colB_Scan,
            this.colPatient_id,
            this.colNoFile,
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
            // colBiometryID
            // 
            this.colBiometryID.FieldName = "BiometryID";
            this.colBiometryID.MinWidth = 25;
            this.colBiometryID.Name = "colBiometryID";
            this.colBiometryID.Visible = true;
            this.colBiometryID.VisibleIndex = 0;
            this.colBiometryID.Width = 94;
            // 
            // colOD_or_OS
            // 
            this.colOD_or_OS.FieldName = "OD_or_OS";
            this.colOD_or_OS.MinWidth = 25;
            this.colOD_or_OS.Name = "colOD_or_OS";
            this.colOD_or_OS.Visible = true;
            this.colOD_or_OS.VisibleIndex = 1;
            this.colOD_or_OS.Width = 94;
            // 
            // colK1
            // 
            this.colK1.FieldName = "K1";
            this.colK1.MinWidth = 25;
            this.colK1.Name = "colK1";
            this.colK1.Visible = true;
            this.colK1.VisibleIndex = 2;
            this.colK1.Width = 94;
            // 
            // colK2
            // 
            this.colK2.FieldName = "K2";
            this.colK2.MinWidth = 25;
            this.colK2.Name = "colK2";
            this.colK2.Visible = true;
            this.colK2.VisibleIndex = 3;
            this.colK2.Width = 94;
            // 
            // colAxial_length
            // 
            this.colAxial_length.FieldName = "Axial_length";
            this.colAxial_length.MinWidth = 25;
            this.colAxial_length.Name = "colAxial_length";
            this.colAxial_length.Visible = true;
            this.colAxial_length.VisibleIndex = 4;
            this.colAxial_length.Width = 94;
            // 
            // colA_Constant
            // 
            this.colA_Constant.FieldName = "A_Constant";
            this.colA_Constant.MinWidth = 25;
            this.colA_Constant.Name = "colA_Constant";
            this.colA_Constant.Visible = true;
            this.colA_Constant.VisibleIndex = 5;
            this.colA_Constant.Width = 94;
            // 
            // colAC_and_IOL
            // 
            this.colAC_and_IOL.FieldName = "AC_and_IOL";
            this.colAC_and_IOL.MinWidth = 25;
            this.colAC_and_IOL.Name = "colAC_and_IOL";
            this.colAC_and_IOL.Visible = true;
            this.colAC_and_IOL.VisibleIndex = 6;
            this.colAC_and_IOL.Width = 94;
            // 
            // colPC_and_IOL
            // 
            this.colPC_and_IOL.FieldName = "PC_and_IOL";
            this.colPC_and_IOL.MinWidth = 25;
            this.colPC_and_IOL.Name = "colPC_and_IOL";
            this.colPC_and_IOL.Visible = true;
            this.colPC_and_IOL.VisibleIndex = 7;
            this.colPC_and_IOL.Width = 94;
            // 
            // colB_Scan
            // 
            this.colB_Scan.FieldName = "B_Scan";
            this.colB_Scan.MinWidth = 25;
            this.colB_Scan.Name = "colB_Scan";
            this.colB_Scan.Visible = true;
            this.colB_Scan.VisibleIndex = 8;
            this.colB_Scan.Width = 94;
            // 
            // colPatient_id
            // 
            this.colPatient_id.FieldName = "Patient_id";
            this.colPatient_id.MinWidth = 25;
            this.colPatient_id.Name = "colPatient_id";
            this.colPatient_id.Visible = true;
            this.colPatient_id.VisibleIndex = 9;
            this.colPatient_id.Width = 94;
            // 
            // colNoFile
            // 
            this.colNoFile.FieldName = "NoFile";
            this.colNoFile.MinWidth = 25;
            this.colNoFile.Name = "colNoFile";
            this.colNoFile.Visible = true;
            this.colNoFile.VisibleIndex = 10;
            this.colNoFile.Width = 94;
            // 
            // colNote1
            // 
            this.colNote1.FieldName = "Note1";
            this.colNote1.MinWidth = 25;
            this.colNote1.Name = "colNote1";
            this.colNote1.Visible = true;
            this.colNote1.VisibleIndex = 11;
            this.colNote1.Width = 94;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label9);
            this.panelControl3.Controls.Add(this.label11);
            this.panelControl3.Controls.Add(this.label8);
            this.panelControl3.Controls.Add(this.groupBox4);
            this.panelControl3.Controls.Add(this.label7);
            this.panelControl3.Controls.Add(this.label6);
            this.panelControl3.Controls.Add(this.label5);
            this.panelControl3.Controls.Add(this.label4);
            this.panelControl3.Controls.Add(this.txtC_ScanBiometry);
            this.panelControl3.Controls.Add(this.txtKtwoBiometry);
            this.panelControl3.Controls.Add(this.txtAXIABiometry);
            this.panelControl3.Controls.Add(this.txtKoneBiometry);
            this.panelControl3.Controls.Add(this.txtAandC_iolBiometry);
            this.panelControl3.Controls.Add(this.txtPandC_iolBiometry);
            this.panelControl3.Controls.Add(this.txtA_CONBiometry);
            this.panelControl3.Controls.Add(this.btnPrint);
            this.panelControl3.Controls.Add(this.btnNewBiometry);
            this.panelControl3.Controls.Add(this.btnUpdateBiometry);
            this.panelControl3.Controls.Add(this.btnSearchBiometry);
            this.panelControl3.Controls.Add(this.btnAddBiometry);
            this.panelControl3.Controls.Add(this.txtSearch);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 109);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1391, 324);
            this.panelControl3.TabIndex = 2;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(562, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "AC/IOL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(331, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "B-SCAN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "A-CONSTANT";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdioODBiometry);
            this.groupBox4.Controls.Add(this.rdioOSBiometry);
            this.groupBox4.Location = new System.Drawing.Point(196, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(674, 75);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eys";
            // 
            // rdioODBiometry
            // 
            this.rdioODBiometry.AutoSize = true;
            this.rdioODBiometry.Location = new System.Drawing.Point(37, 26);
            this.rdioODBiometry.Name = "rdioODBiometry";
            this.rdioODBiometry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdioODBiometry.Size = new System.Drawing.Size(49, 21);
            this.rdioODBiometry.TabIndex = 1;
            this.rdioODBiometry.TabStop = true;
            this.rdioODBiometry.Text = "OD";
            this.rdioODBiometry.UseVisualStyleBackColor = true;
            // 
            // rdioOSBiometry
            // 
            this.rdioOSBiometry.AutoSize = true;
            this.rdioOSBiometry.Location = new System.Drawing.Point(553, 26);
            this.rdioOSBiometry.Name = "rdioOSBiometry";
            this.rdioOSBiometry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdioOSBiometry.Size = new System.Drawing.Size(47, 21);
            this.rdioOSBiometry.TabIndex = 0;
            this.rdioOSBiometry.TabStop = true;
            this.rdioOSBiometry.Text = "OS";
            this.rdioOSBiometry.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "K1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "PC/IOL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "AXIALLENGTH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "K2";
            // 
            // txtC_ScanBiometry
            // 
            this.txtC_ScanBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtC_ScanBiometry.Location = new System.Drawing.Point(421, 254);
            this.txtC_ScanBiometry.Name = "txtC_ScanBiometry";
            this.txtC_ScanBiometry.Size = new System.Drawing.Size(257, 40);
            this.txtC_ScanBiometry.TabIndex = 31;
            this.txtC_ScanBiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKtwoBiometry
            // 
            this.txtKtwoBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtKtwoBiometry.Location = new System.Drawing.Point(198, 145);
            this.txtKtwoBiometry.Name = "txtKtwoBiometry";
            this.txtKtwoBiometry.Size = new System.Drawing.Size(260, 40);
            this.txtKtwoBiometry.TabIndex = 26;
            this.txtKtwoBiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAXIABiometry
            // 
            this.txtAXIABiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtAXIABiometry.Location = new System.Drawing.Point(198, 208);
            this.txtAXIABiometry.Name = "txtAXIABiometry";
            this.txtAXIABiometry.Size = new System.Drawing.Size(260, 40);
            this.txtAXIABiometry.TabIndex = 27;
            this.txtAXIABiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKoneBiometry
            // 
            this.txtKoneBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtKoneBiometry.Location = new System.Drawing.Point(198, 88);
            this.txtKoneBiometry.Name = "txtKoneBiometry";
            this.txtKoneBiometry.Size = new System.Drawing.Size(260, 40);
            this.txtKoneBiometry.TabIndex = 25;
            this.txtKoneBiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAandC_iolBiometry
            // 
            this.txtAandC_iolBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtAandC_iolBiometry.Location = new System.Drawing.Point(653, 138);
            this.txtAandC_iolBiometry.Name = "txtAandC_iolBiometry";
            this.txtAandC_iolBiometry.Size = new System.Drawing.Size(265, 40);
            this.txtAandC_iolBiometry.TabIndex = 29;
            this.txtAandC_iolBiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPandC_iolBiometry
            // 
            this.txtPandC_iolBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtPandC_iolBiometry.Location = new System.Drawing.Point(653, 205);
            this.txtPandC_iolBiometry.Name = "txtPandC_iolBiometry";
            this.txtPandC_iolBiometry.Size = new System.Drawing.Size(265, 40);
            this.txtPandC_iolBiometry.TabIndex = 30;
            this.txtPandC_iolBiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA_CONBiometry
            // 
            this.txtA_CONBiometry.Font = new System.Drawing.Font("Arial", 17F);
            this.txtA_CONBiometry.Location = new System.Drawing.Point(653, 81);
            this.txtA_CONBiometry.Name = "txtA_CONBiometry";
            this.txtA_CONBiometry.Size = new System.Drawing.Size(265, 40);
            this.txtA_CONBiometry.TabIndex = 28;
            this.txtA_CONBiometry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(1017, 276);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(226, 40);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "طباعة البيانات";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNewBiometry
            // 
            this.btnNewBiometry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewBiometry.ImageOptions.Image")));
            this.btnNewBiometry.Location = new System.Drawing.Point(1017, 211);
            this.btnNewBiometry.Name = "btnNewBiometry";
            this.btnNewBiometry.Size = new System.Drawing.Size(226, 40);
            this.btnNewBiometry.TabIndex = 21;
            this.btnNewBiometry.Text = "إفراغ كل الحقول";
            this.btnNewBiometry.Click += new System.EventHandler(this.btnNewBiometry_Click);
            // 
            // btnUpdateBiometry
            // 
            this.btnUpdateBiometry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateBiometry.ImageOptions.Image")));
            this.btnUpdateBiometry.Location = new System.Drawing.Point(1017, 145);
            this.btnUpdateBiometry.Name = "btnUpdateBiometry";
            this.btnUpdateBiometry.Size = new System.Drawing.Size(226, 40);
            this.btnUpdateBiometry.TabIndex = 20;
            this.btnUpdateBiometry.Text = "تعديل بيانات المريض";
            this.btnUpdateBiometry.Click += new System.EventHandler(this.btnUpdateBiometry_Click);
            // 
            // btnSearchBiometry
            // 
            this.btnSearchBiometry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchBiometry.ImageOptions.Image")));
            this.btnSearchBiometry.Location = new System.Drawing.Point(1211, 17);
            this.btnSearchBiometry.Name = "btnSearchBiometry";
            this.btnSearchBiometry.Size = new System.Drawing.Size(81, 38);
            this.btnSearchBiometry.TabIndex = 24;
            this.btnSearchBiometry.Text = "بحث";
            this.btnSearchBiometry.Click += new System.EventHandler(this.btnSearchBiometry_Click);
            // 
            // btnAddBiometry
            // 
            this.btnAddBiometry.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBiometry.ImageOptions.Image")));
            this.btnAddBiometry.Location = new System.Drawing.Point(1017, 75);
            this.btnAddBiometry.Name = "btnAddBiometry";
            this.btnAddBiometry.Size = new System.Drawing.Size(226, 40);
            this.btnAddBiometry.TabIndex = 19;
            this.btnAddBiometry.Text = "حفظ بيانات المريض";
            this.btnAddBiometry.Click += new System.EventHandler(this.btnAddBiometry_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(983, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Arial", 15F);
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtSearch.Size = new System.Drawing.Size(226, 34);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.ToolTip = "البحث";
            this.txtSearch.ToolTipTitle = "البحث";
            // 
            // biometryTableAdapter
            // 
            this.biometryTableAdapter.ClearBeforeFill = true;
            // 
            // Biometry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Biometry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1391, 862);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biometryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eye_CenterDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dataGridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnNewBiometry;
        private DevExpress.XtraEditors.SimpleButton btnUpdateBiometry;
        private DevExpress.XtraEditors.SimpleButton btnSearchBiometry;
        private DevExpress.XtraEditors.SimpleButton btnAddBiometry;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private System.Windows.Forms.ComboBox txtNameBiometry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDBIO;
        private System.Windows.Forms.TextBox txtIDBiometry;
        private System.Windows.Forms.TextBox txtNoFileBiometry;
        private System.Windows.Forms.TextBox txtNoteBiometry;
        private System.Windows.Forms.BindingSource biometryBindingSource;
        private Eye_CenterDataSet4 eye_CenterDataSet4;
        private DevExpress.XtraGrid.Columns.GridColumn colBiometryID;
        private DevExpress.XtraGrid.Columns.GridColumn colOD_or_OS;
        private DevExpress.XtraGrid.Columns.GridColumn colK1;
        private DevExpress.XtraGrid.Columns.GridColumn colK2;
        private DevExpress.XtraGrid.Columns.GridColumn colAxial_length;
        private DevExpress.XtraGrid.Columns.GridColumn colA_Constant;
        private DevExpress.XtraGrid.Columns.GridColumn colAC_and_IOL;
        private DevExpress.XtraGrid.Columns.GridColumn colPC_and_IOL;
        private DevExpress.XtraGrid.Columns.GridColumn colB_Scan;
        private DevExpress.XtraGrid.Columns.GridColumn colPatient_id;
        private DevExpress.XtraGrid.Columns.GridColumn colNoFile;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdioODBiometry;
        private System.Windows.Forms.RadioButton rdioOSBiometry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC_ScanBiometry;
        private System.Windows.Forms.TextBox txtKtwoBiometry;
        private System.Windows.Forms.TextBox txtAXIABiometry;
        private System.Windows.Forms.TextBox txtKoneBiometry;
        private System.Windows.Forms.TextBox txtAandC_iolBiometry;
        private System.Windows.Forms.TextBox txtPandC_iolBiometry;
        private System.Windows.Forms.TextBox txtA_CONBiometry;
        private Eye_CenterDataSet4TableAdapters.BiometryTableAdapter biometryTableAdapter;
    }
}
