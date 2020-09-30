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
    public partial class Routine_Check : DevExpress.XtraEditors.XtraUserControl
    {
        
        DataTable dt = new DataTable();
        BL.Cls_Routine_Check rch = new BL.Cls_Routine_Check();
        BL.Cls_Patient p = new BL.Cls_Patient();
        int ID;
        BL.Cls_Git_Max_id_For_Tables gmxid = new BL.Cls_Git_Max_id_For_Tables();


        public Routine_Check()
        {
            InitializeComponent();
            ScreanPriv();
            sub(txtNameRoutinChech);

            dt = rch.SelectAllRoutine_Check();
            dataGridView1.DataSource = dt;
        }

        public void ScreanPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(1, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnPrintRoutineCheck.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                btnAddRoutineCheck.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btnUpdateRoutineCheck.Enabled = false;
            
        }

        private void btnSearchRoutineCheck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))// 
            {
                Search_All_Name();
                MessageBox.Show("قم بكتابة رقم المريض او رقم الملف .. يمكنك استعراض بيانات المرض من صفحة @المرضا@ . ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dt = rch.SelecRoutine_Check(Convert.ToInt32(txtSearch.Text));

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                //string name, note;
                //int id, no;

                //DataTable dtp = new DataTable();
                //BL.Cls_Patient sp = new BL.Cls_Patient();
                //dtp = sp.SelectNamepatient(txtNameRoutinChech.Text);

                //MessageBox.Show(dt.Rows[0][0].ToString() + "   " + dt.Rows[0][1].ToString() + "" + dt.Rows[0][9].ToString() + "" + dt.Rows[0][4].ToString());

                //name = dtp.Rows[0][0].ToString();
                //id = Convert.ToInt32(dtp.Rows[0][0].ToString());
                //note = dtp.Rows[0][10].ToString();
                //no = Convert.ToInt32(dtp.Rows[0][4].ToString());


                //txtNameRoutinChech.Text = name;
                //txtIDRoutinChech.Text = id.ToString();
                //txtNoteRoutinChechNote.Text = note;
                //txtNoFileRoutinChech.Text = no.ToString();
            }
            else
                MessageBox.Show("هذا الرقم ليس موجود تأكد من الرقم بشكل صحيح  ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        public void Search_Name()
        {


            try
            {
                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNameRoutinChech.Text);

                if (dt.Rows.Count > 0)
                {
                    string note;
                    int id, no;


                    int ID;
                    ID = gmxid.Git_Max_id_For_RoutineCheck() + 1;


                    id = Convert.ToInt32(dt.Rows[0][1].ToString());
                    note = dt.Rows[0][10].ToString();
                    no = Convert.ToInt32(dt.Rows[0][4].ToString());


                    txtIDRoutinChech.Text = id.ToString();
                    txtNoteRoutinChechNote.Text = note;
                    txtNoFileRoutinChech.Text = no.ToString();
                    txtIDROT.Text = ID.ToString();


                }

                else
                    MessageBox.Show("هذا الاسم ليس موجود تأكد من كتابته بشكل صحيح او قم بالبحث باستخدام الرقم او العنوان ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch(Exception)
            {

            }
        }

        private void btnAddRoutineCheck_Click(object sender, EventArgs e)
        {

            try
            {

                string D_or_N;
                if (rdioD.Checked)
                    D_or_N = "D";
                else
                    D_or_N = "N";

                string OD_or_OS;
                if (rdioOD.Checked)
                    OD_or_OS = "OD";
                else
                    OD_or_OS = "OS";

                ID = gmxid.Git_Max_id_For_RoutineCheck() + 1;


                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDRoutinChech.Text) || string.IsNullOrEmpty(txtNoFileRoutinChech.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //دالة الاضافة 
                    rch.InsertRoutine_Check(ID, OD_or_OS, txtVA.Text, txtGlass.Text, txtPH.Text, txtIOP.Text, BL.UsersInfo.user_id, Convert.ToInt32(txtIDRoutinChech.Text), txtSph.Text, txtCyl.Text, txtAxis.Text, txtSphAuto.Text, txtCylAuto.Text, txtAxisAuto.Text, D_or_N, txtNoteRoutinChechNote.Text, Convert.ToInt32(txtNoFileRoutinChech.Text));
                    Refrsh();

                    MessageBox.Show("تمت الاضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sub(txtNameRoutinChech);
                    ClearTextAfterAdd();
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
            dt = rch.SelecRoutine_Check(Convert.ToInt32(txtIDRoutinChech.Text));
            this.dataGridView1.DataSource = dt;
        }

        private void btnNumbersRoutineCheck_Click(object sender, EventArgs e)
        {
            //ViewDataForSearch vdfs = new ViewDataForSearch();
            //vdfs.ShowDialog();
            try
            {
                if (string.IsNullOrEmpty(txtNameRoutinChech.Text))
                {
                    MessageBox.Show("قم بإدخال اسم المريض ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Search_Name();
            }
            catch (Exception ms)
            {
                MessageBox.Show("" + ms);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Search_All_Name();
        }

        private void Search_All_Name()
        {

            dt = rch.SelectAllRoutine_Check();
            dataGridView1.DataSource = dt;
        }

        private void btnNewRoutineCheck_Click(object sender, EventArgs e)
        {
            ClearText();
        }


        public void ClearTextAfterAdd()
        {
            //txtIDROT.Clear();
            txtAxis.Clear();
            txtCyl.Clear();
            txtGlass.Clear();
            //txtIDRoutinChech.Clear();
            txtIOP.Clear();
            //txtNameRoutinChech.Clear();
            //txtNoFileRoutinChech.Clear();
            txtNoteRoutinChechNote.Clear();
            txtPH.Clear();
            txtSph.Clear();
            txtVA.Clear();
            txtAxisAuto.Clear();
            txtSphAuto.Clear();
            txtCylAuto.Clear();
        }
        public void ClearText()
        {
            txtIDROT.Clear();
            txtAxis.Clear();
            txtCyl.Clear();
            txtGlass.Clear();
            txtIDRoutinChech.Clear();
            txtIOP.Clear();
            txtNameRoutinChech.Text = "";
            txtNoFileRoutinChech.Clear();
            txtNoteRoutinChechNote.Clear();
            txtPH.Clear();
            txtSph.Clear();
            txtVA.Clear();
            txtAxisAuto.Clear();
            txtSphAuto.Clear();
            txtCylAuto.Clear();
        }

        private void btnUpdateRoutineCheck_Click(object sender, EventArgs e)
        {


            try
            {

                string D_or_N;
                if (rdioD.Checked)
                    D_or_N = "D";
                else
                    D_or_N = "N";

                string OD_or_OS;
                if (rdioOD.Checked)
                    OD_or_OS = "OD";
                else
                    OD_or_OS = "OS";


                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDRoutinChech.Text) || string.IsNullOrEmpty(txtNoFileRoutinChech.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //دالة التعديل 
                    rch.UpdateRoutine_Check(Convert.ToInt32(txtIDROT.Text), OD_or_OS, txtVA.Text, txtGlass.Text, txtPH.Text, txtIOP.Text, BL.UsersInfo.user_id, Convert.ToInt32(txtIDRoutinChech.Text), txtSph.Text, txtCyl.Text, txtAxis.Text, txtSphAuto.Text, txtCylAuto.Text, txtAxisAuto.Text, D_or_N, txtNoteRoutinChechNote.Text, Convert.ToInt32(txtNoFileRoutinChech.Text));
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

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {

        //        string D_or_N;
        //        string OD_or_OS;

        //        ClearText();
        //        OD_or_OS = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //        txtVA.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //        txtGlass.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //        txtPH.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //        txtIOP.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //        txtIDRoutinChech.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        //        txtSph.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        //        txtCyl.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        //        txtAxis.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        //        D_or_N = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        //        txtNoteRoutinChechNote.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        //        txtNoFileRoutinChech.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

        //        if (D_or_N == "D")
        //            rdioD.Checked = true;
        //        else
        //            rdioN.Checked = true;

        //        if (OD_or_OS == "OD")
        //            rdioOD.Checked = true;
        //        else
        //            rdioOS.Checked = true;
        //    }
        //    catch (Exception ms)
        //    {
        //        MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
        //    }
        //}

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //string N;
            //string OD_or_OS;

            try
            {
                ClearText();
                //txtIDROT.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //N = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //txtVA.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //txtGlass.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //txtPH.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //txtIOP.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                //txtSph.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                //txtCyl.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                //txtAxis.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                //OD_or_OS = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                //txtIDRoutinChech.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                //txtNoFileRoutinChech.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                //txtSphAuto.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                //txtCylAuto.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                //txtAxisAuto.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                //txtNoteRoutinChechNote.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();



                //if (OD_or_OS == "OD")
                //    rdioOD.Checked = true;
                //else
                //    rdioOS.Checked = true;


                //rdioD.Checked = false;

                //rdioN.Checked = false;
                ////MessageBox.Show(D);
                //if (N.Equals("N "))
                //    rdioN.Checked = true;
                //else
                //    rdioD.Checked = true;


                /* 00000000000000000000000000000000000000000000

                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNameRoutinChech.Text);

                if (dt.Rows.Count > 0)
                {
                    string name;

                    DataTable dtp = new DataTable();

                    dtp = sp.SearchPatients(txtNameRoutinChech.Text);

                    name = dtp.Rows[0][0].ToString();


                    txtNameRoutinChech.Text = name;
                }
                00000000000000000000000000000000000000000000*/


            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }
        }

        

        private void txtNameRoutinChech_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search_Name();
                
            }
            catch (Exception)
            {

            }
        }

        private void txtNameRoutinChech_Leave(object sender, EventArgs e)
        {
           
        }

        private void btnPrintRoutineCheck_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات فحص البصريات.pdf");

                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات فحص البصريات.pdf";
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

        private void txtNameRoutinChech_SelectedIndexChanged(object sender, EventArgs e)
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

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            string N;
            string OD_or_OS;

            try
            {
                ClearText();
                
                txtIDROT.Text                   = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colRoutineCheckID).ToString();
                N                               = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colD_or_N).ToString();
                txtVA.Text                      = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colVA).ToString();
                txtGlass.Text                   = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colWith_Glasses).ToString();
                txtPH.Text                      = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPH).ToString();
                txtIOP.Text                     = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIOP).ToString();
                txtCyl.Text                     = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCyl).ToString();
                txtSph.Text                     = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colShp).ToString();
                txtAxis.Text                    = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAxis).ToString();
                OD_or_OS                        = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colOD_or_OS).ToString();
                txtIDRoutinChech.Text           = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPatient_id).ToString();
                txtNoFileRoutinChech.Text       = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNoFile).ToString();
                txtSphAuto.Text                 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colShpAuto).ToString();
                txtAxisAuto.Text                = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAxisAuto).ToString();
                txtCylAuto.Text                 = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colCylAuto).ToString();
                txtNoteRoutinChechNote.Text     = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNote1).ToString();


                if (OD_or_OS.Equals("OD"))
                    rdioOD.Checked = true;
                else
                    rdioOS.Checked = true;

                if (N.Equals("N "))
                    rdioN.Checked = true;
                else
                    rdioD.Checked = true;


                /* 00000000000000000000000000000000000000000000

                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNameRoutinChech.Text);

                if (dt.Rows.Count > 0)
                {
                    string name;

                    DataTable dtp = new DataTable();

                    dtp = sp.SearchPatients(txtNameRoutinChech.Text);

                    name = dtp.Rows[0][0].ToString();


                    txtNameRoutinChech.Text = name;
                }
                00000000000000000000000000000000000000000000*/


            }
            catch (Exception ms)
            {
                MessageBox.Show("هناك خطاء في تحويل البيانات" + ms);
            }
        }

    }
}
