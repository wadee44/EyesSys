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
    public partial class Follow_up : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dt = new DataTable();
        BL.Cls_Follow_up foll = new BL.Cls_Follow_up();
        BL.Cls_Git_Max_id_For_Tables gmxfol = new BL.Cls_Git_Max_id_For_Tables();
        BL.Cls_Patient p = new BL.Cls_Patient();
        int ID;

        public Follow_up()
        {
            InitializeComponent();
            ScreanPriv();
            sub(txtNameFollow_up);
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

        private void txtNameFollow_up_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_Name();
        }

        public void ScreanPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(6, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnPrintFollowUp.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                btnAddSurgery.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btnUpdateSurgery.Enabled = false;
        }

        /// <summary>0
        /// //0000000000000000000//SEARCH NAME\\0000000000000000000000000000000000000000 BIGEN
        /// </summary>        
        public void Search_Name()
        {
            try
            {
                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNameFollow_up.Text);

                if (dt.Rows.Count > 0)
                {
                    string note;
                    int id, no;



                    ID = gmxfol.Git_Max_id_For_Follow_up() + 1;

                    id = Convert.ToInt32(dt.Rows[0][1].ToString());
                    note = dt.Rows[0][10].ToString();
                    no = Convert.ToInt32(dt.Rows[0][4].ToString());


                    txtIDFollow_up.Text = id.ToString();
                    txtNote.Text = note;
                    txtNoFileFollow_up.Text = no.ToString();
                    txtIDFOLL.Text = ID.ToString();
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

            dt = foll.SelectAllFollowUp();
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
            txtIDFOLL.Clear();
            txtIDFollow_up.Clear();
            txtNameFollow_up.Text = "";
            txtNoFileFollow_up.Clear();
            txtNote.Clear();
            txtResultFollow.Clear();
            // txtSearch.Clear();
            txtTreatment.Clear();
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
            dt = foll.SelectFollow_up(Convert.ToInt32(txtIDFollow_up.Text));
            this.dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// //0000000000000000000//REFRSH\\000000000000000000000000000000000000000000000 END
        /// </summary
       
        private void btnNewSurgery_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnSearchSurgery_Click(object sender, EventArgs e)
        {
            try
            {
                ClearText();

                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض او رقم الملف .. يمكنك استعراض بيانات المرض من صفحة @المرضا @  . ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dt = foll.SelectFollow_up(Convert.ToInt32(txtSearch.Text));

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

                    txtNameFollow_up.Text = name;
                    txtIDFollow_up.Text = id.ToString();
                    txtNote.Text = note;
                    txtNoFileFollow_up.Text = no.ToString();*/



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("لا يمكن استخدام الحروف في مربع النص هذا .. تأكد من ادخال رقم المريض او رقم الملف  " + ex, "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnNumbersSurgery_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNameFollow_up.Text))
                {
                    Search_All_Name();
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

        private void btnAddSurgery_Click(object sender, EventArgs e)
        {

            try
            {
                ID = gmxfol.Git_Max_id_For_Follow_up() + 1;// Convert.ToString(dtbDateFollow.Value.Date)

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDFollow_up.Text) || string.IsNullOrEmpty(txtNoFileFollow_up.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //دالة الاضافة 
                    foll.InsertFollow_up(ID, Convert.ToInt32(txtNoFileFollow_up.Text), dtbDateFollow.Value.Date.ToShortDateString(), txtResultFollow.Text, txtTreatment.Text, Convert.ToInt32(txtIDFollow_up.Text), BL.UsersInfo.user_id, txtNote.Text);

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

        
        private void btnUpdateSurgery_Click(object sender, EventArgs e)
        {

            try
            {
                ID = gmxfol.Git_Max_id_For_Follow_up() + 1;

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDFollow_up.Text) || string.IsNullOrEmpty(txtNoFileFollow_up.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                   

                    //دالة التعديل 
                    foll.UpdateFollow_up(Convert.ToInt32(txtIDFOLL.Text), Convert.ToInt32(txtNoFileFollow_up.Text), dtbDateFollow.Value.Date.ToShortDateString(), txtResultFollow.Text, txtTreatment.Text, Convert.ToInt32(txtIDFollow_up.Text), BL.UsersInfo.user_id, txtNote.Text, "");

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

        private void txtNameFollow_up_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search_Name();
            }
            catch (Exception)
            {

            }
        }
        private void btnPrintFollowUp_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات  العودة.pdf");

                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات العودة.pdf";
                pdfExport.Start();
            }
            catch (Exception)
            {

            }
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
            try
            {
                ClearText();
                txtIDFOLL.Text                    = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colFollowUpID).ToString();
                txtNoFileFollow_up.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNoFile).ToString();
                txtIDFollow_up.Text               = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPatient_id).ToString();
                dtbDateFollow.Value               = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colDate).ToString());
                txtResultFollow.Text              = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colResult).ToString();
                txtTreatment.Text                 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colTreatment).ToString();
                txtNote.Text                      = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNote1).ToString();


            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }

            
        }
        //private DataTable getDataTableFromDataGrid(DataGridView _DataGridView)
        //{
        //    try
        //    {
        //        if (_DataGridView.ColumnCount == 0) return null;
        //        DataTable dtSource = new DataTable();
        //        //////create columns
        //        foreach (DataGridViewColumn col in _DataGridView.Columns)
        //        {
        //            if (col.ValueType == null) dtSource.Columns.Add(col.Name, typeof(string));
        //            else dtSource.Columns.Add(col.Name, col.ValueType);
        //            dtSource.Columns[col.Name].Caption = col.HeaderText;
        //        }
        //        ///////insert row data
        //        foreach (DataGridViewRow row in _DataGridView.Rows)
        //        {
        //            DataRow drNewRow = dtSource.NewRow();
        //            foreach (DataColumn col in dtSource.Columns)
        //            {
        //                drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
        //            }
        //            dtSource.Rows.Add(drNewRow);
        //        }
        //        return dtSource;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

    }
}
