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
    public partial class Checked_Patient : DevExpress.XtraEditors.XtraUserControl
    {
        DataTable dt = new DataTable();
        BL.Cls_Checked_Patient chpa = new BL.Cls_Checked_Patient();
        BL.Cls_Git_Max_id_For_Tables gmxchk = new BL.Cls_Git_Max_id_For_Tables();
        BL.Cls_Patient p = new BL.Cls_Patient();
        int ID;
        public Checked_Patient()
        {
            InitializeComponent();
            ScreanPriv();
            sub(txtNameChecked);

            dt = chpa.SelectAllChecked_Patient();
            dataGridView1.DataSource = dt;
        }

        private void txtNameChecked_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_Name();
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
            dt = BL.Cls_Priv.SelectPrivScreen(3, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnPrintChekedPatient.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                btnAddChecked.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btnUpdateChecked.Enabled = false;
            
        }



        private void btnSearchChecked_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))// 
            {
                Search_All_Name();
                MessageBox.Show("قم بكتابة رقم المريض او رقم الملف .. يمكنك استعراض بيانات المرض من صفحة @المرضا @  . ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dt = chpa.SelectChecked_Patient(Convert.ToInt32(txtSearch.Text));

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;/*
                string name, note;
                int id, no;

                DataTable dtp = new DataTable();
                BL.Cls_Patient sp = new BL.Cls_Patient();
                dtp = sp.SelectpatientInNum(Convert.ToInt32(dt.Rows[0][2].ToString()));

                //MessageBox.Show(dt.Rows[0][0].ToString() + "   " + dt.Rows[0][1].ToString() + "" + dt.Rows[0][9].ToString() + "" + dt.Rows[0][4].ToString());

                name = dtp.Rows[0][0].ToString();
                id = Convert.ToInt32(dtp.Rows[0][1].ToString());
                note = dtp.Rows[0][10].ToString();
                no = Convert.ToInt32(dtp.Rows[0][4].ToString());


                txtNameChecked.Text = name;
                txtIDChecked.Text = id.ToString();
                txtNoteChecked.Text = note;
                txtNoFileChecked.Text = no.ToString();*/
            }
            else
                MessageBox.Show("هذا الرقم ليس موجود تأكد من الرقم بشكل صحيح  ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void Search_Name()
        {
            try
            {
                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNameChecked.Text);

                if (dt.Rows.Count > 0)
                {
                    string note;
                    int id, no;



                    int ID;
                    ID = gmxchk.Git_Max_id_For_Checked_Patient() + 1;

                    id = Convert.ToInt32(dt.Rows[0][1].ToString());
                    note = dt.Rows[0][10].ToString();
                    no = Convert.ToInt32(dt.Rows[0][4].ToString());


                    txtIDChecked.Text = id.ToString();
                    txtNoteChecked.Text = note;
                    txtNoFileChecked.Text = no.ToString();
                    txtIDCHED.Text = ID.ToString();


                }
            }
            catch(Exception)
            { }
        }//end Search Name

        private void btnNumbersChecked_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNameChecked.Text))
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

        private void btnViewChecked_Click(object sender, EventArgs e)
        {
            Search_All_Name();
        }
        private void Search_All_Name()
        {

            dt = chpa.SelectAllChecked_Patient();
            dataGridView1.DataSource = dt;
        }

        private void btnNewChecked_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        public void ClearText()
        {
            txtAC.Clear();
            txtCornea.Clear();
            txtEyeLids.Clear();
            txtFundus.Clear();
            txtGonios.Clear();
            txtIDChecked.Clear();
            txtIDCHED.Clear();
            txtLens.Clear();
            txtNameChecked.Text = "";
            txtNoFileChecked.Clear();
            txtNoteChecked.Clear();
            txtOculr.Clear();
            txtPr_Comp.Clear();
            txtPrevOcuHist.Clear();
            txtPupil.Clear();
            txtSlitExamin.Clear();
            txtTreatment.Clear();
            txtUltraSound.Clear();
            txtUsAnyMedic.Clear();
            txtVitreous.Clear();
            cmbxAntSens.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // string L_or_R;
            try
            {
                ClearText();
                //txtIDCHED.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //txtIDChecked.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //txtNoFileChecked.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //L_or_R = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //txtPr_Comp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //txtPrevOcuHist.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                //txtUsAnyMedic.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                //cmbxAntSens.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                //txtOculr.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                //txtSlitExamin.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                //txtEyeLids.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                //txtCornea.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                //txtAC.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                //txtLens.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                //txtVitreous.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                //txtFundus.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                //txtGonios.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                //txtUltraSound.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                //txtTreatment.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                //txtNoteChecked.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();

                //txtNoteRoutinChechNote.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();


                //if (L_or_R == "L")
                //    rdioL_Checked.Checked = true;
                //else
                //    rdioR_Checked.Checked = true;
            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }
        }

        private void btnAddChecked_Click(object sender, EventArgs e)
        {

            try
            {


                string L_or_R;
                if (rdioL_Checked.Checked)
                    L_or_R = "L";
                else
                    L_or_R = "R";

                ID = gmxchk.Git_Max_id_For_Checked_Patient() + 1;

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDChecked.Text) || string.IsNullOrEmpty(txtNoFileChecked.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //دالة الاضافة 
                    chpa.InsertChecked_Patient(ID, Convert.ToInt32(txtNoFileChecked.Text), txtPr_Comp.Text, txtPrevOcuHist.Text, txtUsAnyMedic.Text, cmbxAntSens.Text, txtOculr.Text, txtSlitExamin.Text, txtEyeLids.Text, txtCornea.Text, txtAC.Text, txtLens.Text, txtVitreous.Text, txtFundus.Text, txtGonios.Text, txtUltraSound.Text, txtTreatment.Text, Convert.ToChar(L_or_R), Convert.ToInt32(txtIDChecked.Text), BL.UsersInfo.user_id, txtNoteChecked.Text);

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

        private void Refrsh()
        {

            dt.Clear();
            dt = chpa.SelectChecked_Patient(Convert.ToInt32(txtIDChecked.Text));
            this.dataGridView1.DataSource = dt;
        }

        private void btnUpdateChecked_Click(object sender, EventArgs e)
        {

            try
            {

                string L_or_R;
                if (rdioL_Checked.Checked)
                    L_or_R = "L";
                else
                    L_or_R = "R";

                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDChecked.Text) || string.IsNullOrEmpty(txtNoFileChecked.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //دالة الاضافة 
                    chpa.UpdateChecked_Patient(Convert.ToInt32(txtIDCHED.Text), Convert.ToInt32(txtNoFileChecked.Text), txtPr_Comp.Text, txtPrevOcuHist.Text, txtUsAnyMedic.Text, cmbxAntSens.Text, txtOculr.Text, txtSlitExamin.Text, txtEyeLids.Text, txtCornea.Text, txtAC.Text, txtLens.Text, txtVitreous.Text, txtFundus.Text, txtGonios.Text, txtUltraSound.Text, txtTreatment.Text, Convert.ToChar(L_or_R), Convert.ToInt32(txtIDChecked.Text), BL.UsersInfo.user_id, txtNoteChecked.Text, "");

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

        private void txtNameChecked_TextChanged(object sender, EventArgs e)
        {
            Search_Name();
        }

        

       

        

        private void btnPrintChekedPatient_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات فحص المريض.pdf");

                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات فحص المريض.pdf";
                pdfExport.Start();
            }
            catch (Exception)
            {

            }
           

            //using (
            //      SaveFileDialog ofd = new SaveFileDialog() { FileName = "My_Export.xlsx", Filter = "Excel Workbook|*.xlsx", ValidateNames = true }
            //   )
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        this.Cursor = Cursors.WaitCursor;

            //        string filePath = ofd.FileName;

            //        /// get the sheet page and set it to the dataTable
            //        //BL.ExcelFile excel = new BL.ExcelFile();
            //        //DataTable theDT = excel.GetSheetTable(excel.currentSheetIndex);


            //        DataTable theDT = new DataTable();

            //        theDT = (DataTable)dataGridView1.DataSource;

            //        if (theDT == null || theDT.Columns.Count == 0)
            //            theDT = getDataTableFromDataGrid(dataGridView1);


            //        BL.ExcelFile excel = new BL.ExcelFile();
            //        excel.ExportToExcel(theDT, filePath);

            //        this.Cursor = Cursors.Default;
            //    }
            //}

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

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            string L_or_R;
            try
            {
                ClearText();

                txtIDCHED.Text            = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colChecked_PatientID).ToString();
                txtIDChecked.Text         = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPatient_id).ToString();
                txtNoFileChecked.Text     = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNoFile).ToString();
                L_or_R                    = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colL_or_R_Eye).ToString();
                txtPr_Comp.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPresent_Complaint).ToString();
                txtPrevOcuHist.Text       = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPrevious_Ocular_History).ToString();
                txtUsAnyMedic.Text        = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colUsing_any_Medicine).ToString();
                cmbxAntSens.Text          = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAny_Sensitivity).ToString();
                txtOculr.Text             = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colOcular_motility).ToString();
                txtSlitExamin.Text        = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSlit_lamp_Examination).ToString();
                txtEyeLids.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colEyelids).ToString();
                txtCornea.Text            = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCornea).ToString();
                txtAC.Text                = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAC).ToString();
                txtLens.Text              = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colLens).ToString();
                txtVitreous.Text          = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colVitreous).ToString();
                txtFundus.Text            = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colFundus).ToString();
                txtGonios.Text            = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colGonioscopy).ToString();
                txtUltraSound.Text        = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colUltraSound).ToString();
                txtTreatment.Text         = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colTreatment).ToString();
                txtNoteChecked.Text       = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNote1).ToString();


                if (L_or_R == "L")
                    rdioL_Checked.Checked = true;
                else
                    rdioR_Checked.Checked = true;
            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }
        }

    }
}
