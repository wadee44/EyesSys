using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using System.Data.SqlClient;

namespace Eye_Center.PL
{
    public partial class SettingSystem : DevExpress.XtraEditors.XtraForm
    {
        BL.Cls_Users us = new BL.Cls_Users();
        BL.Cls_Lists ls = new BL.Cls_Lists();
        BL.Cls_BondBook BBT = new BL.Cls_BondBook();
        BL.Cls_BondBookType BBT1 = new BL.Cls_BondBookType();
        DataTable dt = new DataTable();
        BL.Cls_Git_Max_id_For_Tables gmxus = new BL.Cls_Git_Max_id_For_Tables();
        int ID;

        public SettingSystem()
        {
            InitializeComponent();
            LoadData();
            ScreanPriv();
            ScreanPrivpass();
            ScreanPrivBiscData();
            ScreanMangPriv();
            sub(cmBondTypeName);
            dt.Clear();
            dt = BBT.SelectAllBondBook();
            gridControl1.DataSource = dt;
        }


        public void ScreanPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(8, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                button1.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                btnAddUser.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btnUpdateUser.Enabled = false;
            if (dt.Rows[0][3].ToString() == "False" || dt.Rows[0][3].ToString() == string.Empty)
                btnPrintUser.Enabled = false;
        }

        public void ScreanPrivBiscData()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(15, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
            {
                btnAddBondType.Enabled = false;
                simpleButton1.Enabled = false;
            }
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
            {
                btn_update_bondtype.Enabled = false;
                btn_update_surgeryprice.Enabled = false;
            }
            
        }

        public void ScreanPrivpass()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(10, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnSave.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                txtnewPass.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                txtoldPass.Enabled = false;
        }

        public void ScreanMangPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(11, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                tabMangPriv.Enabled = false;
        }

        public void ScreanBackupPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(12, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                tabBackUP.Enabled = false;
        }

        private void LoadData()
        {
            DataTable dtu = new DataTable();
            dtu = us.SelectAllUsers();
            lstbxUsers.DataSource = dtu;
            /* for (int i = 0; i < dtu.Rows.Count; i++)
             {
                 if (dtu.Rows[i][0].ToString().Contains(lstbxUsers.Text))
                 {
                     lstbxUsers.Items.Add(dtu.Rows[i][0].ToString());
                 }
             }*/

           

            DataTable dtl = new DataTable();
            dtl = ls.selectList();
            lisbxLists.DataSource = dtl;
            /*for (int i = 0; i < dtl.Rows.Count; i++)
            {
                if (dtl.Rows[i][0].ToString().Contains(lisbxLists.Text))
                {
                    lisbxLists.Items.Add(dtl.Rows[i][0].ToString());
                }
            }*/


        }

        /// <summary>0
        /// //0000000000000000000//SEARCH NAME\\0000000000000000000000000000000000000000 BIGEN
        /// </summary>        
        public void Search_Name()
        {
            dt = us.SelecUsers(txtSearch.Text);

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }
        /// <summary>
        /// //000000000000000//SEARCH NAME\\00000000000000000000000000000000000000000000 END
        /// </summary>        

        /// <summary>
        /// //0000000000000000000//SEARCH ALL NAME\\000000000000000000000000000000000000 BIGEN
        /// </summary>
        private void Search_All_Name()
        {

            dt = us.SelectAllUsers();
            dataGridView1.DataSource = dt;
        }
        /// <summary>
        /// //0000000000000000000//SEARCH ALL NAME\\000000000000000000000000000000000000 END
        /// </summary>
        /// 

        /// <summary>
        /// //0000000000000000000//CLEAR TEXT\\00000000000000000000000000000000000000000 BIGEN
        /// </summary>
        public void ClearText()
        {
            txtEmail.Clear();
            txtIDUser.Clear();
            txtNameSystem.Clear();
            txtNameUser.Clear();
            txtNoteUser.Clear();
            txtPass.Clear();
            // txtSearch.Clear();
            txtPhoneUser.Clear();
            cmbxTypeUsers.Text = "";
            cmbxTypeShift.Text = "";

        }
        /// <summary>
        /// //0000000000000000000//CLEAR TEXT\\00000000000000000000000000000000000000000 END
        /// </summary>


        /// <summary>
        /// //0000000000000000000//REFRSH\\000000000000000000000000000000000000000000000 BIGEN
        /// </summary
        private void Refrsh()
        {

            dt.Clear();
            dt = us.SelectAllUsers();
            this.dataGridView1.DataSource = dt;
        }
        /// <summary>
        /// //0000000000000000000//REFRSH\\000000000000000000000000000000000000000000000 END
        /// </summary

        private void SettingSystem_FormClosed(object sender, FormClosedEventArgs e)
        {

            Home h = new Home();
            h.ShowDialog();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Name();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Search_All_Name();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                gitmaxid();

                //التأكد من ان جميع الحقول ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtNameUser.Text) || string.IsNullOrEmpty(cmbxTypeUsers.Text) || string.IsNullOrEmpty(txtNameSystem.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(cmbxTypeShift.Text))
                {
                    MessageBox.Show("قم بتعبئة جميع الحقول", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    // تحديد جنس المريض
                    string sex;
                    if (rdioFemale.Checked)
                        sex = "انثى";
                    else
                        sex = "ذكر";

                    /* 
                     * انشاء رقم الملف بدون تكرار وبشكل متتابع
                    int No;
                    No = gitmax.Git_Max_no() + 1;
                    txtNoFile.Text = No.ToString() ;
                    */

                    //دالة الاضافة 
                    us.InsertUsers(txtNameUser.Text, ID, txtNameSystem.Text, cmbxTypeShift.Text, txtPass.Text, cmbxTypeUsers.Text, txtPhoneUser.Text, txtEmail.Text, sex, txtNoteUser.Text);
                    Refrsh();
                    MessageBox.Show("تمت الاضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (cmbxTypeUsers.Text == 4.ToString())
                    {

                    }
                }

               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("هناك خطاء تأكد من صحة البيانات" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string sex;
            ClearText();//   dgvPriv

            //txtNameUser.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txtIDUser.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //txtNameSystem.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //cmbxTypeShift.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //// txtPass.Text           = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //cmbxTypeUsers.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //txtPhoneUser.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //txtEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //sex = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //txtNoteUser.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            //if (sex == "انثى")
            //    rdioFemale.Checked = true;        //لعرض نوع المريض في Rido button
            //else
            //    rdioMale.Checked = true;

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {

                //التأكد من ان جميع الحقول ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtNameUser.Text) || string.IsNullOrEmpty(cmbxTypeUsers.Text) || string.IsNullOrEmpty(txtNameSystem.Text) || string.IsNullOrEmpty(cmbxTypeShift.Text))
                {
                    MessageBox.Show("قم بتعبئة جميع الحقول", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    // تحديد جنس المريض
                    string sex;
                    if (rdioFemale.Checked)
                        sex = "انثى";
                    else
                        sex = "ذكر";

                    /* 
                     * انشاء رقم الملف بدون تكرار وبشكل متتابع
                    int No;
                    No = gitmax.Git_Max_no() + 1;
                    txtNoFile.Text = No.ToString() ;
                    */

                    //دالة الاضافة 
                    us.UpdateUsers(txtNameUser.Text, Convert.ToInt32(txtIDUser.Text), txtNameSystem.Text, cmbxTypeShift.Text, cmbxTypeUsers.Text, txtPhoneUser.Text, txtEmail.Text, sex, txtNoteUser.Text);
                    Refrsh();
                    MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("هناك خطاء تأكد من صحة البيانات" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gitmaxid();
        }

        public void gitmaxid()
        {
            if (string.IsNullOrEmpty(txtIDUser.Text))
            {

                ID = gmxus.Git_Max_id_For_Users() + 1;
                txtIDUser.Text = ID.ToString();
            }
        }

        DataTable dtus = new DataTable();
        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {
                dtus = us.SelecUsers(BL.UsersInfo.NameSystem);
                XtraMessageBox.Show(BL.UsersInfo.NameSystem.ToString());
                if (txtnewPass.Text == txtnewPassAgin.Text && BL.UsersInfo.Pass == txtoldPass.Text)
                {
                    //XtraMessageBox.Show(BL.UsersInfo.NameSystem.ToString() + txtoldPass.Text + txtnewPassAgin.Text);
                    us.ChengPassUsers(BL.UsersInfo.NameSystem, txtoldPass.Text, txtnewPassAgin.Text);
                    MessageBox.Show("تم تغيير كلمة المرور بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnewPass.Clear();
                    txtnewPassAgin.Clear();
                    txtoldPass.Clear();
                }
                else
                {
                    MessageBox.Show("تأكد من صحة البيانات!!", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnewPass.Clear();
                    txtnewPassAgin.Clear();
                    txtoldPass.Clear();
                    return;
                }
            }
            catch (Exception) { }

            //if (txtnewPass.Text == txtnewPassAgin.Text)
            //{
            //    us.ChengPassUsers(BL.UsersInfo.NameSystem ,txtoldPass.Text, txtnewPassAgin.Text);
            //    MessageBox.Show("تم تغيير كلمة المرور بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtnewPass.Clear();
            //    txtnewPassAgin.Clear();
            //    txtoldPass.Clear();
            //}
            //else
            //{
            //    MessageBox.Show("كلمة المرور الجديدة غير متطابقة أعد كتابة كلمة المرور الجدية", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtnewPass.Clear();
            //    txtnewPassAgin.Clear();
            //    txtoldPass.Clear();
            //    return;
            //}
        }

        private void txtNameUser_TextChanged(object sender, EventArgs e)
        {
            gitmaxid();
        }

        private void SettingSystem_Load(object sender, EventArgs e)
        {

            lstbxUsers_SelectedIndexChanged(sender, e);
            //// TODO: This line of code loads data into the 'eye_CenterDataSet11.Lists' table. You can move, or remove it, as needed.
            //this.listsTableAdapter.Fill(this.eye_CenterDataSet11.Lists);
            //// TODO: This line of code loads data into the 'eye_CenterDataSet10.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.eye_CenterDataSet10.Users);
            if (BL.UsersInfo.No_type != 1.ToString())
            {
                tabUser.Enabled = false;
                tabMangPriv.Enabled = false;
                tabClinc.Enabled = false;
            }

        }





        private void txtNamePass_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNamePass_Leave(object sender, EventArgs e)
        {

        }

        private void groupBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void dgvName_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lstbxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = us.SelectPriv(Convert.ToInt32(lisbxLists.SelectedValue), Convert.ToInt32(lstbxUsers.SelectedValue));
                dgvPriv.DataSource = dt;
                dgvPriv.Columns[1].HeaderText = "اسم الشاشة";
                dgvPriv.Columns[3].HeaderText = "عرض";
                dgvPriv.Columns[4].HeaderText = "إضافة";
                dgvPriv.Columns[5].HeaderText = "تعديل";
                dgvPriv.Columns[6].HeaderText = "طباعة";
                dgvPriv.Columns[1].Width = 250;
                dgvPriv.Columns[0].Visible = false;
                dgvPriv.Columns[2].Visible = false;
                dgvPriv.Columns[2].ReadOnly = true;
            }
            catch (Exception)
            {
                //throw;
            }

        }

        private void lisbxLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt = us.SelectPriv(Convert.ToInt32(lisbxLists.SelectedValue), Convert.ToInt32(lstbxUsers.SelectedValue));
                dgvPriv.DataSource = dt;
                dgvPriv.Columns[1].HeaderText = "اسم الشاشة";
                dgvPriv.Columns[3].HeaderText = "عرض";
                dgvPriv.Columns[4].HeaderText = "إضافة";
                dgvPriv.Columns[5].HeaderText = "تعديل";
                dgvPriv.Columns[6].HeaderText = "طباعة";
                dgvPriv.Columns[1].Width = 250;
                dgvPriv.Columns[0].Visible = false;
                dgvPriv.Columns[2].Visible = false;
                dgvPriv.Columns[2].ReadOnly = true;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void btnSavePriv_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(lstbxUsers.SelectedValue);

            for (int i = 0; i < dgvPriv.Rows.Count; i++)
            {
                int ScreenID = Convert.ToInt32(dgvPriv.Rows[i].Cells[0].Value);

                Boolean view = dgvPriv.Rows[i].Cells[3].Value.Equals(true || false);
                Boolean add = dgvPriv.Rows[i].Cells[4].Value.Equals(true || false);
                Boolean update = dgvPriv.Rows[i].Cells[5].Value.Equals(true || false);
                Boolean print = dgvPriv.Rows[i].Cells[6].Value.Equals(true || false);

                BL.Cls_Priv priv = new BL.Cls_Priv();
                priv.UpdatePrivm(userid, ScreenID, view, add, update, print);

            }
            MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnPrintUser_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            //    if (view != null)
            //        view.ExportToPdf("بيانات   المستخدمين.pdf");

            //    Process pdfExport = new Process();

            //    pdfExport.StartInfo.FileName = "AcroRd32.exe";
            //    pdfExport.StartInfo.Arguments = "بيانات المستخدمين.pdf";
            //    pdfExport.Start();
            //}
            //catch (Exception)
            //{

            //}

        }
        

        private void pcbxBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "تم انشاء النسخة الاحتياطية بنجاح";
                string folderPath;
                String dataBaseName = Properties.Settings.Default.DatabaseName; // "The Data Base Name"
                string connectionString = Properties.Settings.Default.Eye_CenterConnectionString1;


                FolderBrowserDialog folder = new FolderBrowserDialog();

                if (folder.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folder.SelectedPath;

                    BL.Backup_Restore_DB backup = new BL.Backup_Restore_DB(connectionString);

                    //// To Test
                    // MessageBox.Show("folderPath : " + folderPath);

                    Cursor.Current = Cursors.WaitCursor;

                    // backup.BackupAllDatabases(folderPath);
                    string result = backup.BackupDatabase(dataBaseName, folderPath);

                    Cursor.Current = Cursors.Default;

                    if (!result.Equals(""))
                        MessageBox.Show(result, "ERROR");
                    else
                        MessageBox.Show(msg);

                }
            }
            catch (Exception) { }
        }

        private void pcbxRestored_Click(object sender, EventArgs e)
        {
            try
            {

                string msg = "تم استعادة النسخة الاحتياطية بنجاح";
                string filePath;
                string connectionString = connectionString = Properties.Settings.Default.Eye_CenterConnectionString1;


                OpenFileDialog file = new OpenFileDialog();
                file.Multiselect = false;
                file.Filter = "Text files (*.sql)|*.sql|Text files (*.bak)|*.bak";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    filePath = file.FileName;

                    BL.Backup_Restore_DB restore = new BL.Backup_Restore_DB(connectionString);

                    // To Test
                     //MessageBox.Show("filePath : " + filePath);

                    Cursor.Current = Cursors.WaitCursor;

                    string dataBaseName = restore.GetDatabaseNameFromFileThatWantToRestore(filePath);
                    if (!dataBaseName.Contains("ERROR"))
                    {
                        string result = restore.RestoreDatabase(dataBaseName, filePath);
                        Cursor.Current = Cursors.Default;

                        if (!result.Equals(""))
                            MessageBox.Show(result, "ERROR");
                        else
                            MessageBox.Show(msg);
                    }
                    else
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show(dataBaseName);
                    }

                }
            }
            catch (Exception) { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtnewPass.Text == "wadee" && txtnewPassAgin.Text == "wadee" && txtoldPass.Text == "wadee")
            {
                PL.SettingConnection sc = new PL.SettingConnection();
                sc.ShowDialog();
            }

            if (txtnewPass.Text == "qury" && txtnewPassAgin.Text == "qury" && txtoldPass.Text == "qury")
            {
                PL.My_Selected my = new My_Selected();
                my.Show();
            }

            txtnewPass.Clear();
            txtnewPassAgin.Clear();
            txtoldPass.Clear();

        }

      

        private void btnSavePrice_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.Less_disc = Convert.ToDouble(txtChekPric.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show(Properties.Settings.Default.Less_disc.ToString());

                
            }
            catch (Exception) { }
        }

        public void sub(System.Windows.Forms.ComboBox ItemName)
        {
            dt.Clear();
            dt = BBT1.SelectAllBondBookType();
            ItemName.Items.Clear();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                ItemName.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
       
       

        public void sub()
        {
            try
            {
                DataTable dtcm = new DataTable();
                dtcm = BBT1.SelectAllBondBookType();
                txtBondTypeNumber.Text = dtcm.Rows[cmBondTypeName.SelectedIndex][1].ToString();
                txtBondTypeCode.Text = dtcm.Rows[cmBondTypeName.SelectedIndex][2].ToString();
            }
            catch (Exception) { }
        }

        private void cmBondTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            sub();
        }

        

        

       

        

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //    {
        //        groupBox6.Enabled = true;
        //        btnSavePrice1.Enabled = true;
        //        txtSurgeryName1.Text = Properties.Settings.Default.Name_Surgery1;
        //        txtSurgeryPrice1.Text = Properties.Settings.Default.Price_Surgery1.ToString();
        //    }
        //    else
        //    {
        //        groupBox6.Enabled = false;
        //        btnSavePrice1.Enabled = false;


        //    }
        //}

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //    {
        //        groupBox7.Enabled = true;
        //        btnSavePrice2.Enabled = true;

        //        txtSurgeryCode.Text = Properties.Settings.Default.Name_Surgery2;
        //        txtSurgeryPrice2.Text = Properties.Settings.Default.price_Surgery2.ToString();
        //    }
        //    else
        //    {
        //        groupBox7.Enabled = false;
        //        btnSavePrice2.Enabled = false;
        //    }
        //}

        //private void checkBox3_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //    {
        //        groupBox8.Enabled = true;
        //        btnSavePrice3.Enabled = true;
        //        txtSurgeryName3.Text = Properties.Settings.Default.Name_Surgery3;
        //        txtSurgeryPrice3.Text = Properties.Settings.Default.price_Surgery3.ToString();
        //    }
        //    else
        //    {
        //        groupBox8.Enabled = false;
        //        btnSavePrice3.Enabled = false;

        //    }
        //}

        //private void checkBox4_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //    {
        //        groupBox9.Enabled = true;
        //        btnSavePrice4.Enabled = true;

        //        txtSurgeryName4.Text = Properties.Settings.Default.Name_Surgery4;
        //        txtSurgeryPrice4.Text = Properties.Settings.Default.price_Surgery4.ToString();
        //    }
        //    else
        //    {
        //        groupBox9.Enabled = false;
        //        btnSavePrice4.Enabled = false;

        //    }
        //}

        //private void checkBox5_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBox1.Checked)
        //    {
        //        groupBox10.Enabled = true;
        //        btnSavePrice5.Enabled = true;

        //        txtSurgeryName5.Text = Properties.Settings.Default.Name_Surgery5;
        //        txtSurgeryPrice5.Text = Properties.Settings.Default.price_Surgery5.ToString();
        //    }
        //    else
        //    {
        //        groupBox10.Enabled = false;
        //        btnSavePrice5.Enabled = true;

        //    }
        //}

        //private void btnSavePrice1_Click(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.Name_Surgery1 = txtSurgeryName1.Text;
        //    Properties.Settings.Default.Price_Surgery1 = Convert.ToDouble(txtSurgeryPrice1.Text);
        //    Properties.Settings.Default.Save();
        //    MessageBox.Show(Properties.Settings.Default.Name_Surgery1.ToString() + "<<>>" + Properties.Settings.Default.Price_Surgery1.ToString());
        //}

        //private void btnSavePrice2_Click(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.Name_Surgery2 = txtSurgeryCode.Text;
        //    Properties.Settings.Default.price_Surgery2 = Convert.ToDouble(txtSurgeryPrice2.Text);
        //    Properties.Settings.Default.Save();
        //    MessageBox.Show(Properties.Settings.Default.Name_Surgery2.ToString() + "<<>>" + Properties.Settings.Default.price_Surgery2.ToString());

        //}

        //private void btnSavePrice3_Click(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.Name_Surgery3 = txtSurgeryName3.Text;
        //    Properties.Settings.Default.price_Surgery3 = Convert.ToDouble(txtSurgeryPrice3.Text);
        //    Properties.Settings.Default.Save();
        //    MessageBox.Show(Properties.Settings.Default.Name_Surgery3.ToString() + "<<>>" + Properties.Settings.Default.price_Surgery3.ToString());
        //}

        //private void btnSavePrice4_Click(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.Name_Surgery4 = txtSurgeryName4.Text;
        //    Properties.Settings.Default.price_Surgery4 = Convert.ToDouble(txtSurgeryPrice4.Text);
        //    Properties.Settings.Default.Save();
        //    MessageBox.Show(Properties.Settings.Default.Name_Surgery4.ToString() + "<<>>" + Properties.Settings.Default.price_Surgery4.ToString());

        //}

        //private void btnSavePrice5_Click(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.Name_Surgery5 = txtSurgeryName5.Text;
        //    Properties.Settings.Default.price_Surgery5 = Convert.ToDouble(txtSurgeryPrice5.Text);
        //    Properties.Settings.Default.Save();
        //    MessageBox.Show(Properties.Settings.Default.Name_Surgery5.ToString() + "<<>>" + Properties.Settings.Default.price_Surgery5.ToString());
        //}

        private void btnAddBondType_Click(object sender, EventArgs e)
        {
            try
            {
                BL.Cls_BondBookType bty = new BL.Cls_BondBookType();
                DataTable dtby = new DataTable();

                bty.InsertBondBookType(Convert.ToInt32(txtBondTypeNumber.Text), txtBondTypeCode.Text, cmBondTypeName.Text, "", "");
                XtraMessageBox.Show("تم إضافة نوع السند بنجاح");
            }
            catch (Exception) { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                BL.Cls_SurgeryPrices sp = new BL.Cls_SurgeryPrices();
                DataTable dtsp = new DataTable();
                dtsp = sp.git_max_SurgeryPrices();
                int idsp = Convert.ToInt32(dtsp.Rows[0][0]);
                sp.insert_SurgeryPrices(idsp, txtSurgeryCode.Text, Convert.ToInt32(txtSurgeryPrice1.Text), cmbxSurgeryName.Text, "");
                XtraMessageBox.Show("تم إضافة البيانات بنجاح");
            }
            catch (Exception) { }
        }

        private void SettingSystem_Load_1(object sender, EventArgs e)
        {
            BL.Cls_BondBookType bt = new BL.Cls_BondBookType();
            DataTable dty = new DataTable();
            dty = bt.SelectAllBondBookType();
            cmBondTypeName.DataSource = dty;
            cmBondTypeName.DisplayMember = "Bond_Name";
            cmBondTypeName.ValueMember = "Bond_Number";

            BL.Cls_SurgeryPrices sp = new BL.Cls_SurgeryPrices();
            DataTable dts = new DataTable();
            dts = sp.select_all_SurgeryPrices();
            cmbxSurgeryName.DataSource = dts;
            cmbxSurgeryName.DisplayMember = "SurgeryPrice_name";
            cmbxSurgeryName.ValueMember = "SurgeryPrice_id";
        }

        public void cleartext()
        {
            cmBondTypeName.Text = "";
            cmbxSurgeryName.Text = "";
            txtBondTypeCode.Text = "";
            txtBondTypeNumber.Text = "";
            txtSurgeryCode.Text = "";
            txtSurgeryPrice1.Text = "";
        }

        private void cmbxSurgeryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BL.Cls_SurgeryPrices sp = new BL.Cls_SurgeryPrices();
                DataTable dts = new DataTable();
                dts = sp.select_all_SurgeryPrices();
                txtSurgeryPrice1.Text = dts.Rows[cmbxSurgeryName.SelectedIndex][2].ToString();
                txtSurgeryCode.Text = dts.Rows[cmbxSurgeryName.SelectedIndex][1].ToString();
            }
            catch (Exception) { }
        }

        private void btn_update_bondtype_Click(object sender, EventArgs e)
        {
            BL.Cls_BondBookType bt = new BL.Cls_BondBookType();
            bt.UpdateBondBookType(Convert.ToInt32(txtBondTypeNumber.Text), txtBondTypeCode.Text, cmBondTypeName.Text, "", "");
            XtraMessageBox.Show("تعم التعديل بنجاح");
        }

        private void btn_update_surgeryprice_Click(object sender, EventArgs e)
        {
            BL.Cls_SurgeryPrices sp = new BL.Cls_SurgeryPrices();
            DataTable dts = new DataTable();
            sp.update_SurgeryPrices(Convert.ToInt32(cmbxSurgeryName.SelectedValue.ToString()), txtSurgeryCode.Text, Convert.ToInt32(txtSurgeryPrice1.Text), cmbxSurgeryName.Text, "");
            XtraMessageBox.Show("تعم التعديل بنجاح");
        }

        private void btn_clear_Bond_Surgery_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void txtoldPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnewPassAgin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}