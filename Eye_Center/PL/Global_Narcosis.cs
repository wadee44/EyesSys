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
    public partial class Global_Narcosis : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dt = new DataTable();
        BL.Cls_Global_Narcosis glonar = new BL.Cls_Global_Narcosis();
        BL.Cls_Patient p = new BL.Cls_Patient();
        public Global_Narcosis()
        {
            InitializeComponent();

            ScreanPriv();
            sub(txtNameGlobal);

            dt = glonar.SelectAllGlobal_Narcosis();
            dataGridView1.DataSource = dt;
        }

        public void sub(System.Windows.Forms.ComboBox ItemName)
        {
            dt = p.NameSurgreyGeneral();
            ItemName.Items.Clear();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                ItemName.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }

        private void txtNameGlobal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_Name();
        }

        public void ScreanPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(4, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnPrintGlobal.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                btnAddGlobal.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btnUpdateGlobal.Enabled = false;
        }

        /// <summary>0
        /// //0000000000000000000//SEARCH NAME\\0000000000000000000000000000000000000000 BIGEN
        /// </summary>        
        public void Search_Name()
        {
            try
            {

                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNameGlobal.Text);

                if (dt.Rows.Count > 0)
                {
                    string note;
                    int no, idsur;

                    DataTable dtp = new DataTable();

                    dtp = sp.SearchPatients(txtNameGlobal.Text);

                    note = dtp.Rows[0][10].ToString();
                    no = Convert.ToInt32(dtp.Rows[0][4].ToString());

                    BL.Cls_Surgery sur = new BL.Cls_Surgery();
                    dtp = sur.SelectSurgery(Convert.ToInt32(no));
                    idsur = Convert.ToInt32(dtp.Rows[0][0].ToString());

                    txtNoteGlobal.Text = note;
                    txtNoFileGlobal.Text = no.ToString();
                    txtIDGLOBNAR.Text = idsur.ToString();
                }
            }
            catch(Exception)
            { }
        }
        /// <summary>
        /// //000000000000000//SEARCH NAME\\00000000000000000000000000000000000000000000 END
        /// </summary>        

        /// <summary>
        /// //0000000000000000000//SEARCH ALL NAME\\000000000000000000000000000000000000 BIGEN
        /// </summary>
        private void Search_All_Name()
        {

            dt = glonar.SelectAllGlobal_Narcosis();
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
            txtIDGLOBNAR.Clear();
            txtCBC.Clear();
            txtNameGlobal.Text = "";
            txtNoFileGlobal.Clear();
            txtNoteGlobal.Clear();
            txtLiver.Clear();
            // txtSearch.Clear();
            txtUrea_reation.Clear();
            txtNote.Clear();
            txtBS.Clear();
            txtBT_CT.Clear();
            txtC_X_ray.Clear();
            txtECG.Clear();

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
            dt = glonar.SelecGlobal_Narcosis(Convert.ToInt32(txtIDGLOBNAR.Text));
            this.dataGridView1.DataSource = dt;
        }
        /// <summary>
        /// //0000000000000000000//REFRSH\\000000000000000000000000000000000000000000000 END
        /// </summary

        private void btnSearchGlobal_Click(object sender, EventArgs e)
        {
            try
            {
                ClearText();

                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض او رقم الملف .. يمكنك استعراض بيانات المرض من صفحة @المرضا @  . ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dt = glonar.SelecGlobal_Narcosis(Convert.ToInt32(txtSearch.Text));

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

        private void btnViewGlobal_Click(object sender, EventArgs e)
        {
            Search_All_Name();
        }

        private void btnNumbersGlobal_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNameGlobal.Text))
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


        private void btnAddGlobal_Click(object sender, EventArgs e)
        {

            try
            {
                string med, ped, ent;
                if (chkMedical.Checked)
                    med = "تم الموافقة";
                else
                    med = "لم تتم الموافقة";

                if (chkPediatric.Checked)
                    ped = "تم الموافقة";
                else
                    ped = "لم تتم الموافقة";

                if (chkENT.Checked)
                    ent = "تم الموافقة";
                else
                    ent = "لم تتم الموافقة";

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDGLOBNAR.Text) || string.IsNullOrEmpty(txtNoFileGlobal.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //دالة الاضافة 
                    glonar.InsertGlobal_Narcosis(Convert.ToInt32(txtNoFileGlobal.Text), txtUrea_reation.Text, txtBT_CT.Text, txtLiver.Text, txtECG.Text, txtC_X_ray.Text, med, ent, ped, txtCBC.Text, txtBS.Text, Convert.ToInt32(txtIDGLOBNAR.Text), txtNote.Text);

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

        private void btnUpdateGlobal_Click(object sender, EventArgs e)
        {
            try
            {

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDGLOBNAR.Text) || string.IsNullOrEmpty(txtNoFileGlobal.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // التأكد من عدم تكرار رقم الملف
                //  if (p.Checking_Repeat_NoFile(Convert.ToInt32(txtNoFileRoutinChech.Text)))
                //  {
                //     MessageBox.Show("رقم الملف  موجود تأكد من صحة الرقم", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //     return;
                //  }


                string med, ped, ent;
                if (chkMedical.Checked)
                    med = "تم الموافقة";
                else
                    med = "لم تتم الموافقة";

                if (chkPediatric.Checked)
                    ped = "تم الموافقة";
                else
                    ped = "لم تتم الموافقة";

                if (chkENT.Checked)
                    ent = "تم الموافقة";
                else
                    ent = "لم تتم الموافقة";

                //دالة الاضافة 
                glonar.UpdateGlobal_Narcosis(Convert.ToInt32(txtNoFileGlobal.Text), txtUrea_reation.Text, txtBT_CT.Text, txtLiver.Text, txtECG.Text, txtC_X_ray.Text, med, ent, ped, txtCBC.Text, txtBS.Text, Convert.ToInt32(txtIDGLOBNAR.Text), txtNote.Text);

                Refrsh();

                MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearText();
                Search_All_Name();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("هناك خطاء تأكد من صحة البيانات" + ex.Message);
            }
        }

        private void btnNewGlobal_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void txtNameGlobal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search_Name();
            }
            catch (Exception)
            {

            }

        }

      

        

        private void btnPrintGlobal_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات   فحص عملية التخدير العام.pdf");

                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات فحص عملية التخدير العام.pdf";
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
                string med, ent, ped;

                ClearText();


                txtNoFileGlobal.Text        = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNoFile).ToString();
                txtUrea_reation.Text        = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colUrea_and_creation).ToString();
                txtBT_CT.Text               = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colBT_and_CT).ToString();
                txtLiver.Text               = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colLiver_functor_test).ToString();
                txtECG.Text                 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colECG).ToString();
                txtC_X_ray.Text             = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colC_X_ray).ToString();
                med                         = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colMedical).ToString();
                ent                         = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colENT_Dr).ToString();
                ped                         = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colpediatric).ToString();
                txtIDGLOBNAR.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSurgery_id).ToString();
                txtCBC.Text                 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCBC).ToString();
                txtBS.Text                  = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colBS).ToString();
                txtNote.Text                = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNote1).ToString();



                if (med == "تم الموافقة")
                    chkMedical.Checked = true;
                else
                    chkMedical.Checked = false;

                if (ped == "تم الموافقة")
                    chkPediatric.Checked = true;
                else
                    chkPediatric.Checked = false;

                if (ent == "تم الموافقة")
                    chkENT.Checked = true;
                else
                    chkENT.Checked = false;

            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }
        }
        

    }
}
