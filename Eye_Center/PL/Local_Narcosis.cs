using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Eye_Center.PL
{
    public partial class Local_Narcosis : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dt = new DataTable();
        BL.Cls_Local_Narcosis locnar = new BL.Cls_Local_Narcosis();
        BL.Cls_Patient p = new BL.Cls_Patient();

        public Local_Narcosis()
        {
            InitializeComponent();
            ScreanPriv();
            sub(txtNameLocal);

            dt = locnar.SeletAllcLocal_Narcosis();
            dataGridView1.DataSource = dt;
        }

        public void sub(System.Windows.Forms.ComboBox ItemName)
        {
            dt = p.NameSurgreyLocal();
            ItemName.Items.Clear();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                ItemName.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }


        private void txtNameLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_Name();
        }

        public void ScreanPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(5, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnPrintLocal.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                btnAddLocal.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btnUpdateLocal.Enabled = false;
        }


        /// <summary>0
        /// //0000000000000000000//SEARCH NAME\\0000000000000000000000000000000000000000 BIGEN
        /// </summary>        
        public void Search_Name()
        {


            try
            {
                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNameLocal.Text);

                if (dt.Rows.Count > 0)
                {
                    string note;
                    int id, no, idsur;

                    DataTable dtp = new DataTable();

                    dtp = sp.SearchPatients(txtNameLocal.Text);

                    


                    id = Convert.ToInt32(dtp.Rows[0][1].ToString());
                    note = dtp.Rows[0][10].ToString();
                    no = Convert.ToInt32(dtp.Rows[0][4].ToString());

                    BL.Cls_Surgery sur = new BL.Cls_Surgery();
                    dtp = sur.SelectSurgery(Convert.ToInt32(no));
                    idsur = Convert.ToInt32(dtp.Rows[0][0].ToString());

                    txtIDGlobal.Text = id.ToString();
                    txtNoteLocal.Text = note;
                    txtNoFileLocal.Text = no.ToString();
                    txtIDLOCAL.Text = idsur.ToString();


                }
            }
            catch (Exception)
            {

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

            dt = locnar.SeletAllcLocal_Narcosis();
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
            txtIDLOCAL.Clear();
            txtIDGlobal.Clear();
            txtCBC.Clear();
            txtNameLocal.Text = "";
            txtNoFileLocal.Clear();
            txtNoteLocal.Clear();
            // txtSearch.Clear();
            txtViral_Marks_and_HIV.Clear();
            txtNote.Clear();
            txtBS.Clear();
            txtBP.Clear();

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
            dt = locnar.SelecLocal_Narcosis(Convert.ToInt32(txtIDLOCAL.Text));
            this.dataGridView1.DataSource = dt;
        }
        /// <summary>
        /// //0000000000000000000//REFRSH\\000000000000000000000000000000000000000000000 END
        /// </summary

        private void btnSearchLocal_Click(object sender, EventArgs e)
        {
            try
            {
                ClearText();

                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض او رقم الملف .. يمكنك استعراض بيانات المرض من صفحة @المرضا @  . ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dt = locnar.SelecLocal_Narcosis(Convert.ToInt32(txtSearch.Text));

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن استخدام الحروف في مربع النص هذا .. تأكد من ادخال رقم المريض او رقم الملف  " + ex, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btnNumbersLocal_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNameLocal.Text))
                {
                    MessageBox.Show("قم بإدخال اسم المريض او رقم الهاتف او عنوان السكن", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Search_Name();
            }
            catch
            {
                MessageBox.Show("هذا المريض لم يقم بأي عملية لذالك لايمكن ان تضاف بياناته في هذه الصفحة");
            }
        }

        private void btnNewLocal_Click(object sender, EventArgs e)
        {
            ClearText();
        }

       

        private void btnAddLocal_Click(object sender, EventArgs e)
        {
            try
            {

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDLOCAL.Text) || string.IsNullOrEmpty(txtNoFileLocal.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {


                    //دالة الاضافة 
                    locnar.InsertLocal_Narcosis(Convert.ToInt32(txtNoFileLocal.Text), txtBP.Text, txtViral_Marks_and_HIV.Text, txtCBC.Text, txtBS.Text, Convert.ToInt32(txtIDLOCAL.Text), txtNote.Text);

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

        private void btnUpdateLocal_Click(object sender, EventArgs e)
        {
            try
            {

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDLOCAL.Text) || string.IsNullOrEmpty(txtNoFileLocal.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //دالة الاضافة 
                    locnar.UpdateLocal_Narcosis(Convert.ToInt32(txtNoFileLocal.Text), txtBP.Text, txtViral_Marks_and_HIV.Text, txtCBC.Text, txtBS.Text, Convert.ToInt32(txtIDLOCAL.Text), txtNote.Text);

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

        private void txtNameLocal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search_Name();
            }
            catch (Exception)
            {

            }
        }

        

       
        private void btnPrintLocal_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات   فحص عملية التخدير الموضعي.pdf");

                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات فحص عملية التخدير الموضعي.pdf";
                pdfExport.Start();
            }
            catch (Exception)
            {

            }
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {

                ClearText();
               
               txtNoFileLocal.Text                     = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNoFile).ToString();
               txtBP.Text                              = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colBP).ToString();
               txtViral_Marks_and_HIV.Text             = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colViral_Marks_and_HIV).ToString();
               txtIDLOCAL.Text                         = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSurgery_id).ToString();
               txtCBC.Text                             = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCBC).ToString();
               txtBS.Text                              = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colBS).ToString();
               txtNote.Text                            = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNote1).ToString();


            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }
        }
       

    }
}
