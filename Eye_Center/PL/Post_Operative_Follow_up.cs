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
    public partial class Post_Operative_Follow_up : DevExpress.XtraEditors.XtraUserControl
    {

        DataTable dt = new DataTable();
        BL.Cls_Post_Operative_Follow_up pofu = new BL.Cls_Post_Operative_Follow_up();
        BL.Cls_Git_Max_id_For_Tables gmxpof = new BL.Cls_Git_Max_id_For_Tables();
        BL.Cls_Patient p = new BL.Cls_Patient();
        int ID;

        public Post_Operative_Follow_up()
        {
            InitializeComponent();
            ScreanPriv();
            sub(txtNamePofu);

            dt = pofu.Select_All_Post_Operative_Follow_up();
            dataGridView1.DataSource = dt;
        }

        public void sub(System.Windows.Forms.ComboBox ItemName)
        {
            dt = p.NameSurgery();
            ItemName.Items.Clear();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                ItemName.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }

        private void txtNamePofu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_Name();
        }

          public void ScreanPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(7, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnPrintPostOper.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                btnAddPofu.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btnUpdatePofu.Enabled = false;
        }

        /// <summary>0
        /// //0000000000000000000//SEARCH NAME\\0000000000000000000000000000000000000000 BIGEN
        /// </summary>        
        public void Search_Name()
        {

            try
            {
                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNamePofu.Text);

                if (dt.Rows.Count > 0)
                {

                    int id, no, idsur;

                    DataTable dtp = new DataTable();

                    dtp = sp.SearchPatients(txtNamePofu.Text);


                    ID = gmxpof.Git_Max_id_For_Post_Operative_Follow_up() + 1;
                    


                    id = Convert.ToInt32(dtp.Rows[0][1].ToString());
                    no = Convert.ToInt32(dtp.Rows[0][4].ToString());

                    BL.Cls_Surgery sur = new BL.Cls_Surgery();
                    dtp = sur.SelectSurgery(Convert.ToInt32(no));
                    idsur = Convert.ToInt32(dtp.Rows[0][0].ToString());

                    txtIDPofu.Text = id.ToString();
                    txtIDSurgery.Text = idsur.ToString();
                    txtNoFilePofu.Text = no.ToString();
                    txtID_POSTFollow.Text = ID.ToString();

                }
               
            }
            catch (Exception)
            {

            }

        }
        /// <summary>
        /// //000000000000000//SEARCH NAME\\00000000000000000000000000000000000000000000 END
        /// </summary>        


        /// <summary>0
        /// //0000000000000000000//SEARCH ID SURGERY\\0000000000000000000000000000000000000000 BIGEN
        /// </summary>        
        public void Search_ID_SURGERY()
        {


            BL.Cls_Surgery sp = new BL.Cls_Surgery();
            DataTable dtp = new DataTable();
            dtp = sp.SelectSurgery(Convert.ToInt32(txtIDSurgery.Text));

            if (dtp.Rows.Count > 0)
            {
                int id;
                id = Convert.ToInt32(dtp.Rows[0][1].ToString());
                txtIDSurgery.Text = id.ToString();
            }
            else
                MessageBox.Show("رقم العملية غير صحيح");
        }
        /// <summary>
        /// //000000000000000//SEARCH ID SURGERY\\00000000000000000000000000000000000000000000 END
        /// </summary>        

        /// <summary>
        /// //0000000000000000000//SEARCH ALL NAME\\000000000000000000000000000000000000 BIGEN
        /// </summary>
        private void Search_All_Name()
        {

            dt = pofu.Select_All_Post_Operative_Follow_up();
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
            txtID_POSTFollow.Clear();
            txtIDPofu.Clear();
            txtCornealOpacity.Clear();
            txtRetinal_Disease.Clear();
            txtNamePofu.Text = "";
            txtNoFilePofu.Clear();
            txtIDSurgery.Clear();
            txtPH.Clear();
            //txtSearch.Clear();
            txtVA.Clear();
            txtGlaucoma.Clear();
            txtNote.Clear();
            txtOthers.Clear();
            txtAstigmatism.Clear();
            txtC_Odema.Clear();
            txtCornealCause.Clear();
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
            dt = pofu.SelecPost_Operative_Follow_up(Convert.ToInt32(txtIDPofu.Text));
            this.dataGridView1.DataSource = dt;
        }
         /// <summary>
         /// //0000000000000000000//REFRSH\\000000000000000000000000000000000000000000000 END
         /// </summary
        private void btnSearchPofu_Click(object sender, EventArgs e)
        {
            try
            {
                ClearText();

                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    Search_All_Name();
                    MessageBox.Show("قم بكتابة رقم المريض او رقم الملف .. يمكنك استعراض بيانات المرض من صفحة @المرضا @  . ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dt = pofu.SelecPost_Operative_Follow_up(Convert.ToInt32(txtSearch.Text));

                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;/*
                    string name, note;
                    int id, no;

                    DataTable dtp = new DataTable();
                    BL.Cls_Patient sp = new BL.Cls_Patient();
                    dtp = sp.SelectPatient();

                    //MessageBox.Show(dt.Rows[0][0].ToString() + "   " + dt.Rows[0][1].ToString() + "" + dt.Rows[0][9].ToString() + "" + dt.Rows[0][4].ToString());

                    name = dtp.Rows[0][0].ToString();
                    id = Convert.ToInt32(dtp.Rows[0][1].ToString());
                    note = dtp.Rows[0][10].ToString();
                    no = Convert.ToInt32(dtp.Rows[0][4].ToString());

                    txtNamePofu.Text = name;
                    txtIDPofu.Text = id.ToString();
                    txtIDSurgery.Text = note;
                    txtNoFilePofu.Text = no.ToString();*/



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن استخدام الحروف في مربع النص هذا .. تأكد من ادخال رقم المريض او رقم الملف  " + ex, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewPofu_Click(object sender, EventArgs e)
        {
            Search_All_Name();
        }

        private void btnNumbersPofu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNamePofu.Text))
                {
                    MessageBox.Show("قم بإدخال اسم المريض او رقم الهاتف او عنوان السكن", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Search_Name();
            }
            catch 
            {
                MessageBox.Show("هذا المريض لم يقم بأي عملية لذالك لايمكن ان تضاف بياناته في هذه الصفحة" );
            }
        }

        private void btnNewPofu_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnAddPofu_Click(object sender, EventArgs e)
        {

            try
            {
                ID = gmxpof.Git_Max_id_For_Post_Operative_Follow_up() + 1;

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDPofu.Text) || string.IsNullOrEmpty(txtNoFilePofu.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //دالة الاضافة 
                    pofu.InsertPost_Operative_Follow_up(ID, Convert.ToInt32(txtIDSurgery.Text), Convert.ToInt32(txtNoFilePofu.Text), txtVA.Text, txtPH.Text, dtbDatepofu.Value.Date.ToShortDateString(), txtAstigmatism.Text, txtCornealCause.Text, txtCornealOpacity.Text, txtC_Odema.Text, txtRetinal_Disease.Text, txtGlaucoma.Text, txtOthers.Text, Convert.ToInt32(txtIDPofu.Text), BL.UsersInfo.user_id, txtNote.Text);

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

        

        private void btnUpdatePofu_Click(object sender, EventArgs e)
        {

            try
            {

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDPofu.Text) || string.IsNullOrEmpty(txtNoFilePofu.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //دالة الاضافة 
                    pofu.UpdatePost_Operative_Follow_up(Convert.ToInt32(txtID_POSTFollow.Text), Convert.ToInt32(txtIDSurgery.Text), Convert.ToInt32(txtNoFilePofu.Text), txtVA.Text, txtPH.Text, dtbDatepofu.Value.Date.ToShortDateString(), txtAstigmatism.Text, txtCornealCause.Text, txtCornealOpacity.Text, txtC_Odema.Text, txtRetinal_Disease.Text, txtGlaucoma.Text, txtOthers.Text, Convert.ToInt32(txtIDPofu.Text), BL.UsersInfo.user_id, txtNote.Text);

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

        private void txtNamePofu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search_Name();
            }
            catch(Exception)
            {

            }
        }


        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                ClearText();

               txtID_POSTFollow.Text    = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPost_Oper_FollowID).ToString();
               txtIDSurgery.Text        = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSurgery_id).ToString();
               txtIDPofu.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPatient_id).ToString();
               txtNoFilePofu.Text       = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNoFile).ToString();
               txtVA.Text               = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colVA).ToString();
               txtPH.Text               = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPH).ToString();
               dtbDatepofu.Value        = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colDate).ToString());
               txtAstigmatism.Text      = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAstigmatism).ToString();
               txtCornealCause.Text     = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCorneal_Cause).ToString();
               txtCornealOpacity.Text   = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCorneal_Opacity).ToString();
               txtC_Odema.Text          = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colC_Odema).ToString();
               txtRetinal_Disease.Text  = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colRetinal_Disease).ToString();
               txtGlaucoma.Text         = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colGlaucoma).ToString();
               txtOthers.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colOthers).ToString();
               txtNote.Text             = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNote1).ToString();


            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }
        }

        private void btnPrintPostOper_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات   العودة بعد العملية.pdf");

                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات العودة بعد العملية.pdf";
                pdfExport.Start();
            }
            catch (Exception)
            {

            }
        }
        

    }
}
