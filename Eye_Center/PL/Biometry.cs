using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;

namespace Eye_Center.PL
{
    public partial class Biometry : DevExpress.XtraEditors.XtraUserControl
    {

        DataTable dt = new DataTable();
        BL.Cls_Biometry Bio = new BL.Cls_Biometry();
        BL.Cls_Git_Max_id_For_Tables gmxbio = new BL.Cls_Git_Max_id_For_Tables();
        BL.Cls_Patient p = new BL.Cls_Patient();
        int ID;
        Home h = new Home();

        public Biometry()
        {
            InitializeComponent();
            ScreanPriv();

            dt = Bio.SelectAllBiometry();
            dataGridView1.DataSource = dt;

            sub(txtNameBiometry);
        }

        public void sub(System.Windows.Forms.ComboBox ItemName)
        {
            dt = p.SelectAllPatient();
            ItemName.Items.Clear();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                ItemName.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }
        public void ScreanPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(2, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnPrint.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                btnAddBiometry.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btnUpdateBiometry.Enabled = false;
        }

        private void btnSearchBiometry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))// 
            {
                Search_All_Name();
                MessageBox.Show("قم بكتابة رقم المريض او رقم الملف .. يمكنك استعراض بيانات المرض من صفحة @المرضا @  . ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                dt = Bio.SelecBiometry(Convert.ToInt32(txtSearch.Text));

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                

                //MessageBox.Show("هذا الرقم ليس موجود تأكد من الرقم بشكل صحيح  ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="How to Search the BIOMETRY Of The Name Patient"></param>
        /// <param name="e"></param>


        public void Search_Name()
        {

            try
            {

                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNameBiometry.Text);

                if (dt.Rows.Count > 0)
                {
                    string note;
                    int id, no;



                    int ID;
                    ID = gmxbio.Git_Max_id_For_Biometry() + 1;

                    id = Convert.ToInt32(dt.Rows[0][1].ToString());
                    note = dt.Rows[0][10].ToString();
                    no = Convert.ToInt32(dt.Rows[0][4].ToString());

                    txtIDBiometry.Text = id.ToString();
                    txtNoteBiometry.Text = note;
                    txtNoFileBiometry.Text = no.ToString();
                    txtIDBIO.Text = ID.ToString();
                }
            }
            catch (Exception)
            {

            }

            //MessageBox.Show("هذا الاسم ليس موجود تأكد من كتابته بشكل صحيح او قم بالبحث باستخدام الرقم او العنوان ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }//end Search Name
        private void btnNumbersBiometry_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNameBiometry.Text))
                {
                    MessageBox.Show("قم بإدخال اسم المريض او رقم الهاتف او عنوان السكن", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Search_Name();
            }
            catch (Exception ms)
            {
                MessageBox.Show("" + ms);
            }
        }

        

        private void Search_All_Name()
        {

            dt = Bio.SelectAllBiometry();
            dataGridView1.DataSource = dt;
        }

        private void btnNewBiometry_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtA_CONBiometry.Clear();
            txtAandC_iolBiometry.Clear();
            txtAXIABiometry.Clear();
            txtC_ScanBiometry.Clear();
            txtIDBIO.Clear();
            txtIDBiometry.Clear();
            txtKoneBiometry.Clear();
            txtKtwoBiometry.Clear();
           
            txtNoFileBiometry.Clear();
            txtNoteBiometry.Clear();
            txtPandC_iolBiometry.Clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //string OD_or_OS;

                ClearText();
                //txtIDBIO.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //txtIDBiometry.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //txtNoFileBiometry.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //OD_or_OS = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //txtKoneBiometry.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //txtKtwoBiometry.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                //txtAXIABiometry.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                //txtA_CONBiometry.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                //txtAandC_iolBiometry.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                //txtPandC_iolBiometry.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                //txtC_ScanBiometry.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

                //txtNoteRoutinChechNote.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

                /*00000000000000000000000000000000000000000000
                
            BL.SearchPatient sp = new BL.SearchPatient();
            dt = sp.SearchPatients(txtNameBiometry.Text);

            if (dt.Rows.Count > 0)
            {
                string name;

                DataTable dtp = new DataTable();

                dtp = sp.SearchPatients(txtNameBiometry.Text);

                name = dtp.Rows[0][0].ToString();


                txtNameBiometry.Text = name;
            }
                00000000000000000000000000000000000000000000*/



                //if (OD_or_OS == "OD")
                //    rdioODBiometry.Checked = true;
                //else
                //    rdioOSBiometry.Checked = true;
            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }
        }

        private void btnAddBiometry_Click(object sender, EventArgs e)
        {

            try
            {

                string OD_or_OS;
                if (rdioODBiometry.Checked)
                    OD_or_OS = "OD";
                else
                    OD_or_OS = "OS";

                ID = gmxbio.Git_Max_id_For_Biometry() + 1;

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDBiometry.Text) || string.IsNullOrEmpty(txtNoFileBiometry.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //دالة الاضافة 
                    Bio.Insert_Biometry(ID, Convert.ToInt32(txtNoFileBiometry.Text), OD_or_OS, txtKoneBiometry.Text, txtKtwoBiometry.Text, txtAXIABiometry.Text, txtA_CONBiometry.Text, txtAandC_iolBiometry.Text, txtPandC_iolBiometry.Text, txtC_ScanBiometry.Text, Convert.ToInt32(txtIDBiometry.Text), BL.UsersInfo.user_id, txtNoteBiometry.Text);

                    Refrsh();

                    MessageBox.Show("تمت الاضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearText();
                    Search_All_Name();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("هناك خطاء تأكد من صحة البيانات" + ex.Message);
            }
        }

        void Refrsh()
        {
            dt.Clear();
            dt = Bio.SelecBiometry(Convert.ToInt32(txtIDBiometry.Text));
            this.dataGridView1.DataSource = dt;
        }

        private void btnUpdateBiometry_Click(object sender, EventArgs e)
        {


            try
            {
                string OD_or_OS;
                if (rdioODBiometry.Checked)
                    OD_or_OS = "OD";
                else
                    OD_or_OS = "OS";

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDBiometry.Text) || string.IsNullOrEmpty(txtNoFileBiometry.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //دالة الاضافة 
                    Bio.Update_Biometry(Convert.ToInt32(txtIDBIO.Text), Convert.ToInt32(txtNoFileBiometry.Text), OD_or_OS, txtKoneBiometry.Text, txtKtwoBiometry.Text, txtAXIABiometry.Text, txtA_CONBiometry.Text, txtAandC_iolBiometry.Text, txtPandC_iolBiometry.Text, txtC_ScanBiometry.Text, Convert.ToInt32(txtIDBiometry.Text), BL.UsersInfo.user_id, txtNoteBiometry.Text, "");

                    Refrsh();

                    MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearText();
                    Search_All_Name();
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show("هناك خطاء تأكد من صحة البيانات" + ex.Message);
            }
        }

        private void txtNameBiometry_TextChanged(object sender, EventArgs e)
        {
            Search_Name();
           
        }

        private void txtNameBiometry_Leave(object sender, EventArgs e)
        {
            
        }

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات فحص العدسة.pdf");

                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات فحص العدسة.pdf";
                pdfExport.Start();
            }
            catch (Exception)
            {

            }
        }
        private DataTable getDataTableFromDataGrid(DataGridView _DataGridView)
        {
            try
            {
                if (_DataGridView.ColumnCount == 0) return null;
                DataTable dtSource = new DataTable();
                //////create columns
                foreach (DataGridViewColumn col in _DataGridView.Columns)
                {
                    if (col.ValueType == null) dtSource.Columns.Add(col.Name, typeof(string));
                    else dtSource.Columns.Add(col.Name, col.ValueType);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                ///////insert row data
                foreach (DataGridViewRow row in _DataGridView.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch
            {
                return null;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Up)
                {
                    
                    dt = Bio.SelecBiometry(Convert.ToInt32(txtSearch.Text));

                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    //MessageBox.Show("هذا الرقم ليس موجود تأكد من الرقم بشكل صحيح  ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
        }

        private void txtNameBiometry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_Name();
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            try
            {
                string OD_or_OS;

                ClearText();
              

                txtIDBIO.Text                  = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colBiometryID).ToString();
                txtIDBiometry.Text             = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPatient_id).ToString();
                txtNoFileBiometry.Text         = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNoFile).ToString();
                OD_or_OS                       = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colOD_or_OS).ToString();
                txtKoneBiometry.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colK1).ToString();
                txtKtwoBiometry.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colK2).ToString();
                txtAXIABiometry.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAxial_length).ToString();
                txtA_CONBiometry.Text          = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,  colA_Constant).ToString();
                txtAandC_iolBiometry.Text      = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAC_and_IOL).ToString();
                txtPandC_iolBiometry.Text      = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPC_and_IOL).ToString();
                txtC_ScanBiometry.Text         = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colB_Scan).ToString();
                txtNoteBiometry.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNote1).ToString();




                if (OD_or_OS == "OD")
                    rdioODBiometry.Checked = true;
                else
                    rdioOSBiometry.Checked = true;
            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }
        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
