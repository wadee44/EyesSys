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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Diagnostics;
using Eye_Center.DAL;

namespace Eye_Center.PL
{
    public partial class Patient : DevExpress.XtraEditors.XtraUserControl
    {

        DataTable dt = new DataTable();
        //DataTable dtCombox;
        BL.Cls_Patient p = new BL.Cls_Patient();
        BL.Cls_BondBook B = new BL.Cls_BondBook();
        BL.Cls_SurgeryPrices sp = new BL.Cls_SurgeryPrices();

       // DataTable dtprice = new DataTable();
        public Patient()
        {
            InitializeComponent();

            //ChekPrice();
            ScreanPriv();
            ScreanPrivBond();
            //لإظهار رقم المريض ورقم الملف بدون تكرار وبشكل متتابع
            BL.Cls_Git_Max_id_For_Tables gitmax = new BL.Cls_Git_Max_id_For_Tables();

            int Id, No;
            Id = gitmax.Git_Max_id() + 1;
            No = gitmax.Git_Max_no() + 1;

            //بجلب ارقام المريض مع مرقم ملفه تلقائياً
            txtIdPatient.Text = Id.ToString();
            txtNoFile.Text = No.ToString();

            //لجلب اسماء العمليات
            surgeryName(cmTypeBond);
            BondType(cmBefor);

            dt = p.SelectAllPatient();
            dataGridView1.DataSource = dt;

            

            //لجلب اسماء المرضى الى الكبوبوكس
            sub(txtNamePatient);
        }
        public void ChekPrice(double pricesurg)
        {
            try
            {
                DataTable dtprice = new DataTable();
                dtprice = sp.search_SurgeryPrices(Convert.ToInt32(cmTypeBond.SelectedValue.ToString()));
                XtraMessageBox.Show(dtprice.Rows[0][2].ToString());
                XtraMessageBox.Show(pricesurg.ToString());
               
                //تحميل سعر المعاينة
                double price;
                price = Convert.ToDouble(dtprice.Rows[0][2]);//Convert.ToDouble(txtAmuont.Text);


                txtDiscount.Text = (price - pricesurg ).ToString();
                
                
            }
            catch(Exception)
            {}
        }
        public void sub(System.Windows.Forms.ComboBox ItemName)
        {//Names.SelectedValue.ToString()
            dt = p.SelectAllPatient();
            ItemName.Items.Clear();
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                ItemName.Items.Add(dt.Rows[i].ItemArray[0]);
            }
        }

        public void surgeryName(System.Windows.Forms.ComboBox ItemName)
        {
            try
            {
                DataTable dtpri= new DataTable();
                dtpri = sp.select_all_SurgeryPrices();

                //ItemName.DataSource = dtpri;
                //ItemName.DisplayMember = "SurgeryPrice_name";
                //ItemName.ValueMember = "SurgeryPrice_id";

                ItemName.Items.Clear();
                for (int i = 0; i <= dtpri.Rows.Count - 1; i++)
                {
                    ItemName.Items.Add(dtpri.Rows[i].ItemArray[3]);
                }
            }
            catch (Exception) { }
        }
        BL.Cls_BondBookType by = new BL.Cls_BondBookType();
        public void BondType(System.Windows.Forms.ComboBox ItemName)
        {

            DataTable dtsp = new DataTable();
            dtsp = by.SelectAllBondBookType();
            ItemName.Items.Clear();
            for (int i = 0; i <= dtsp.Rows.Count - 1; i++)
            {
                ItemName.Items.Add(dtsp.Rows[i].ItemArray[0]);
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                // تحديد جنس المريض
                string sex;
                if (rdioFemale.Checked)
                    sex = "انثى";
                else
                    sex = "ذكر";

                //انشاء رقم المريض بدون تكرار وبشكل متتابع
                BL.Cls_Git_Max_id_For_Tables gitmax = new BL.Cls_Git_Max_id_For_Tables();
                int Id;
                Id = gitmax.Git_Max_id() + 1;

                int idBond;
                idBond = gitmax.Git_Max_Bond_Book_id() + 1;
                string open;
                if (chbxBondState.Checked)
                    open = "مقفل";
                else
                    open = "مفتوح";

                //التأكد من ان جميع الحقول ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtNamePatient.Text) || string.IsNullOrEmpty(txtAddressPatient.Text) || string.IsNullOrEmpty(txtPhonePatient.Text) || string.IsNullOrEmpty(txtAgePatient.Text) || string.IsNullOrEmpty(txtClinic_id_Patient.Text) || string.IsNullOrEmpty(cmbxBondAfterOrCash.Text) || string.IsNullOrEmpty(txtDiscount.Text) || string.IsNullOrEmpty(txtAmuont.Text))
                {
                    MessageBox.Show("قم بتعبئة جميع الحقول", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    // التأكد من رقم العيادة
                    if (!p.Checking_Repeat_ClincID(Convert.ToInt32(txtClinic_id_Patient.Text)))
                    {
                        MessageBox.Show("رقم غير صحيح", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    // التأكد من عدم تكرار رقم الملف

                    if (p.Checking_Repeat_NoFile(Convert.ToInt32(txtNoFile.Text)))
                    {
                        MessageBox.Show("رقم الملف موجود تأكد من صحة الرقم", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        double disc = Convert.ToDouble(txtDiscount.Text);
                        if (disc > Properties.Settings.Default.Less_disc)
                        {

                            XtraMessageBox.Show("لايمكن ان يكون التخفيض اكثر من " + Properties.Settings.Default.Less_disc.ToString());
                        }
                        else
                        { 
                                //دالة الاضافة 
                                p.InsertPatient(txtNamePatient.Text, Id, txtAddressPatient.Text, Convert.ToInt32(txtNoFile.Text), txtPhonePatient.Text, txtAgePatient.Text, BL.UsersInfo.user_id, Convert.ToInt32(txtClinic_id_Patient.Text), sex, txtNotePatient.Text);

                                MessageBox.Show("تمت الاضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                                //var ms = MessageBox.Show()
                                B.InsertBondBook(idBond, cmBefor.SelectedIndex + 1, Id, BL.UsersInfo.user_id, Convert.ToDouble(txtAmuont.Text), Convert.ToDouble(txtDiscount.Text), cmbxBondAfterOrCash.Text, open, cmTypeBond.Text, "");
                        
                                PrintBond();
                                PrintFile();
                                sub(txtNamePatient);
                                Refrsh();
                                ClearTextPatient();
                        }
                        
                    }


                   
                }
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("هناك خطاء تأكد من صحة البيانات" + ex.Message);
            }

        }//End/////////////////////////

        //زر تعديل بيانات المريض الشخصية
        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            try
            {

                // تحديد جنس المريض
                string sex;
                if (rdioFemale.Checked)
                    sex = "انثى";
                else
                    sex = "ذكر";
                //التأكد من ان جميع الحقول ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtNamePatient.Text) || string.IsNullOrEmpty(txtAddressPatient.Text) || string.IsNullOrEmpty(txtPhonePatient.Text) || string.IsNullOrEmpty(txtAgePatient.Text) || string.IsNullOrEmpty(txtClinic_id_Patient.Text))
                {
                    MessageBox.Show("قم بتعبئة جميع الحقول", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //دالة التعديل 
                    p.UpdatePatient(txtNamePatient.Text, Convert.ToInt32(txtIdPatient.Text), txtAddressPatient.Text, Convert.ToInt32(txtNoFile.Text), txtPhonePatient.Text, txtAgePatient.Text, BL.UsersInfo.user_id, Convert.ToInt32(txtClinic_id_Patient.Text), sex, txtNotePatient.Text, "Null");
                    MessageBox.Show("تم التعديل بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refrsh();
                }

                
               // int count = gridView1.SelectCell();
                //dt = dataGridView1.DataMember.

               
            }
            catch (SqlException ex)
            {
                MessageBox.Show("هناك خطاء تأكد من صحة البيانات" + ex.Message);
            }
        }//End


        //دالة البحث عن مريض بستخدام الاسم او رقم الهاتف او العنوان
        private void btnSearch_Click(object sender, EventArgs e)
        {
           // grbPatientViewData.Visible = true;

            BL.SearchPatient sp = new BL.SearchPatient();
            dt = sp.SearchPatients(txtSearch.Text);

            if (dt.Rows.Count > 0)
                dataGridView1.DataSource = dt;
            else
                MessageBox.Show("هذا الاسم ليس موجود تأكد من كتابته بشكل صحيح او قم بالبحث باستخدام الرقم او العنوان ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void ClearTextPatient()
        {
            txtNamePatient.Text = "";
            txtAddressPatient.Text = "";
            txtAgePatient.Text = "";
            txtClinic_id_Patient.Text = "1";
            txtNoFile.Text = "";
            txtNotePatient.Text = "";
            txtPhonePatient.Text = "";
            txtIdPatient.Text = "";
            txtAmuont.Text = "";
            txtDiscount.Text = "";
            cmTypeBond.Text = "";
            cmBefor.Text = "";
            cmbxBondAfterOrCash.Text = "";
            chbxBondState.Checked = false;

            //dateCom_in.ResetText();
        }
        void Refrsh()
        {
            dt.Clear();
            dt = p.SelectAllPatient();
            this.dataGridView1.DataSource = dt;
        }

        private void namedatagridview()
        {
            //dataGridView1.ColumnNameChanged[0][0] = "";
        }


        // دالة تصفية الحقول لإضافة مريض جديد


        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            ClearTextPatient();
        }

        private void numNoFile_Click(object sender, EventArgs e)
        {
            txtNoFile.ResetText();
        }



        private void txtNoFile_TextChanged(object sender, EventArgs e)
        {
            BL.Cls_Git_Max_id_For_Tables gitmax = new BL.Cls_Git_Max_id_For_Tables();

            int No;
            No = gitmax.Git_Max_no() + 1;

            //txtNoFile.Text = No.ToString();
        }

        private void txtIdPatient_TextChanged(object sender, EventArgs e)
        {
            BL.Cls_Git_Max_id_For_Tables gitmax = new BL.Cls_Git_Max_id_For_Tables();

            int Id;
            Id = gitmax.Git_Max_id() + 1;

            txtIdPatient.Text = Id.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BL.Cls_Git_Max_id_For_Tables gitmax = new BL.Cls_Git_Max_id_For_Tables();

            int Id, No;
            Id = gitmax.Git_Max_id() + 1;
            No = gitmax.Git_Max_no() + 1;


            txtIdPatient.Text = Id.ToString();
            txtNoFile.Text = No.ToString();
        }

        private void btnNumbersPatient_Click(object sender, EventArgs e)
        {
            gitmax();
        }

        public void gitmax()
        {
            BL.Cls_Git_Max_id_For_Tables gitmax = new BL.Cls_Git_Max_id_For_Tables();
            if (string.IsNullOrEmpty(txtIdPatient.Text) || string.IsNullOrEmpty(txtNoFile.Text))
            {
                int Id, No;
                Id = gitmax.Git_Max_id() + 1;
                No = gitmax.Git_Max_no() + 1;
                txtIdPatient.Text = Id.ToString();
                txtNoFile.Text = No.ToString();
            }


        }

        private void pnl_Patient_List_Left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNamePatient_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //grbPatientViewData.Visible = true;

            BL.SearchPatient sp = new BL.SearchPatient();
            dt = sp.SearchPatients(txtSearch.Text);

            if (dt.Rows.Count > 0)
                dataGridView1.DataSource = dt;
            else
                MessageBox.Show("هذا الاسم ليس موجود تأكد من كتابته بشكل صحيح او قم بالبحث باستخدام الرقم او العنوان ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {/*
            if(e.KeyCode == Keys.Up)
            { 

                BL.Cls_Patient p = new BL.Cls_Patient();
                dt = p.SelectNamepatient(comboBox1.Text);
                //comboBox1.DataSource = dt.;
                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    comboBox1.Items.Add(dt.Rows[i][0].ToString());
                }
                    dataGridView1.DataSource = dt;
               // MessageBox.Show(dt.Rows[0][0].ToString(), "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                */
            /*
            //string txt = comboBox1.SelectedText;
               

            //PL.ViewDataForSearch search = new PL.ViewDataForSearch(txt);
                
            if(search.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Result OK" + PL.ViewDataForSearch.data);
            }
        }*/


        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                BL.Cls_Patient p = new BL.Cls_Patient();
                dtCombox = p.SelectNamepatient(comboBox1.Text);

                //if(comboBox1 != null && comboBox1.Items.Count > 0)
                   // comboBox1.Items.Clear();
                //comboBox1.DataSource = dt.;
                for (int i = 0; i < dtCombox.Rows.Count; i++)
                {
                   // if(dtCombox.Rows[i][0].ToString().Contains(comboBox1.Text))
                   
                        comboBox1.Items.Add(dtCombox.Rows[i][0].ToString());
                        if (comboBox1.Items == dt.Rows[i][0])
                            continue;
                }
                comboBox1.DroppedDown = true;
                // dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void txtNamePatient_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string name = txtNamePatient.Text;
            //BL.Cls_Patient pn = new BL.Cls_Patient();
            //dgvName.DataSource = pn.SelectNamepatient(name);

            //dgvName.Visible = true;
        }

        private void txtNamePatient_Leave(object sender, EventArgs e)
        {
            //dgvName.Hide();
        }

        private void dgvName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // txtNamePatient.Text = dgvName.CurrentRow.Cells[0].Value.ToString();
        }
        //Bitmap bmp;

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
        private void btnPrint_Click(object sender, EventArgs e)
        {

            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات المرضى.pdf");
                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات المرضى.pdf";
                pdfExport.Start();
            }
            catch(Exception)
            { }

            //RP.FormPatientReport fr = new RP.FormPatientReport();
            //fr.ShowDialog();
            //using (
            //      SaveFileDialog ofd = new SaveFileDialog() { FileName = "My_Export.xlsx", Filter = "Excel Workbook|*.xlsx", ValidateNames = true }
            //   )
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        this.Cursor = Cursors.WaitCursor;

            //        string filePath = ofd.FileName;

            //         get the sheet page and set it to the dataTable
            //        BL.ExcelFile excel = new BL.ExcelFile();
            //        DataTable theDT = excel.GetSheetTable(excel.currentSheetIndex);


            //        DataTable theDT = new DataTable();

            //        theDT = (DataTable)dataGridView1.DataSource;

            //        if (theDT == null || theDT.Columns.Count == 0)
            //            theDT = getDataTableFromDataGrid(dataGridView1);


            //        BL.ExcelFile excel = new BL.ExcelFile();
            //        excel.ExportToExcel(theDT, filePath);

            //        this.Cursor = Cursors.Default;
            //    }
            //}

            /*
            int height = dataGridView1.Height ;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;

            bmp = new Bitmap(dataGridView1.Width * 10, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width * 10, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();*/
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {



            // RP.CrystalReport1 cr = new RP.CrystalReport1();
            //cr.Refresh();
            /*
            report1.Load(@"C:\Program Files (x86)\FastReports\FastReport.Net Trial\Demos\Reports\Text.frx");
            report1.Prepare();
            report1.Show();*/
        }

        public void ScreanPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(13, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnPrint.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                btnAddPatient.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btnUpdatePatient.Enabled = false;
           
        }

        public void ScreanPrivBond()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(16, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnBond.Enabled = false;
            if (dt.Rows[0][1].ToString() == "False" || dt.Rows[0][1].ToString() == string.Empty)
                simpleButton1.Enabled = false;
            if (dt.Rows[0][2].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                simpleButton2.Enabled = false;
            if (dt.Rows[0][3].ToString() == "False" || dt.Rows[0][2].ToString() == string.Empty)
                btn_delete_bond.Enabled = false;

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    BL.Cls_Patient p = new BL.Cls_Patient();
                    dt = p.SelectpatientInNum(Convert.ToInt32(txtSearch.Text));
                    dataGridView1.DataSource = dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("ادخل رقم المريض للبحث او قم بالضغط على زر البحث ");
                }
            }
        }

        

        private void dataGridView1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if(e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (MessageBox.Show("هل تريد حذف بيانات المريص", "نافذة الحذف", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Handled = true;
            }
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                string sex;
                ClearTextPatient();

                txtNamePatient.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colName).ToString();
                txtIdPatient.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPatient_id).ToString();
                txtAddressPatient.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAddress).ToString();
                txtAgePatient.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAge).ToString();
                sex = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSex).ToString();
                txtNoFile.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNo_File).ToString();
                txtNotePatient.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNote1).ToString();
                txtPhonePatient.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPhone).ToString();
                date_check.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colDate).ToString();

                if (sex == "انثى      ")
                    rdioFemale.Checked = true;        //لعرض نوع المريض في Rido button
                else
                    rdioMale.Checked = true;
            }
            catch(Exception)
            {

            }
        }

        

        private void txtNamePatient_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void txtNamePatient_TextChanged(object sender, EventArgs e)
        {
            gitmax();
        }

        public void cmBondTypefun()
        {
           // cmTypeBond.Items.Add(Properties.Settings.Default.Price_Chek);
           
        }

        public RP.ViweReports frm = new RP.ViweReports();

        public void InsertBond()
        {
            

            //انشاء رقم السند بدون تكررا وبشكل متتابع
           
            string open;
            if (chbxBondState.Checked)
                open = "مقفل";
            else
                open = "مفتوح";

            double disc = Convert.ToDouble(txtDiscount.Text);
            if (disc > Properties.Settings.Default.Less_disc)
            {

                XtraMessageBox.Show("لايمكن ان يكون التخفيض اكثر من " + Properties.Settings.Default.Less_disc.ToString());
            }
            else
            {
                B.InsertDeleted_Bond_Book(Convert.ToInt32(txtBondNumber.Text), cmBefor.SelectedIndex + 1, Convert.ToInt32(txtIdPatient.Text), BL.UsersInfo.user_id, Convert.ToDouble(txtAmuont.Text), Convert.ToDouble(txtDiscount.Text), cmbxBondAfterOrCash.Text, open, cmTypeBond.Text, "");
                //PrintBond();

            }
        }
        private void btnBond_Click(object sender, EventArgs e)
        {
            try
            {

                BL.Cls_Git_Max_id_For_Tables gitmax = new BL.Cls_Git_Max_id_For_Tables();
                int id;
                string user_name;

                id = Convert.ToInt32(txtIdPatient.Text);
                user_name = txtNamePatient.Text;


                //انشاء رقم السند بدون تكررا وبشكل متتابع
                int idBond;
                idBond = gitmax.Git_Max_Bond_Book_id() + 1;
                string open;
                if (chbxBondState.Checked)
                    open = "مقفل";
                else
                    open = "مفتوح";

                double disc = Convert.ToDouble(txtDiscount.Text);
                if (disc > Properties.Settings.Default.Less_disc)
                {

                    XtraMessageBox.Show("لايمكن ان يكون التخفيض اكثر من " + Properties.Settings.Default.Less_disc.ToString());
                }
                else
                {
                    B.InsertBondBook(idBond, cmBefor.SelectedIndex + 1, id, BL.UsersInfo.user_id, Convert.ToDouble(txtAmuont.Text), Convert.ToDouble(txtDiscount.Text), cmbxBondAfterOrCash.Text, open, cmTypeBond.Text, "");
                    PrintBond();

                }

                //B.InsertBondBook(idBond, bond, Convert.ToInt32(txtIdPatient.Text), BL.UsersInfo.user_id, Convert.ToDouble(txtAmuont.Text), Convert.ToDouble(txtDiscount.Text), cmbxBondAfterOrCash.Text, open);
                //MessageBox.Show("تم حفظ بيانات السند بنجاح");
                /*
                vr.documentViewer1.Refresh();
                rp.Parameters["Patient"].Value = Convert.ToInt32(txtIdPatient.Text);
               // rp.RequestParameters = false;

                if (rdbtnCheck.Checked)
                    rp.txtResun.Text = "معايتة";
                else
                    rp.txtResun.Text = "عملية";
                vr.Show();
                */
              


            }
            catch (Exception) { }
        }
        public void PrintFile()
        {
            try
            {
                BL.Cls_Patient pit = new BL.Cls_Patient();
                int id;
                if (txtIdPatient.Text == "")
                {
                    XtraMessageBox.Show("افرغ الحقول ثم قم بإضافة بيانات المريض");
                    id = Convert.ToInt32(txtIdPatient.Text);
                }
                else
                    id = Convert.ToInt32(txtIdPatient.Text);
                this.Cursor = Cursors.WaitCursor;

                // تحديد نوع السند 

                RP.ViweReports frmRep = new RP.ViweReports();

                RP.File_Patient reprot = new RP.File_Patient();

                dt.Clear();
                dt = p.SelectpatientInNum(id);

                reprot.SetDataSource(dt);
                reprot.SetParameterValue(0, id);

                //frmRep.crystalReportViewer1.Refresh();
                frmRep.crystalReportViewer1.ReportSource = reprot;

                frmRep.Show();

                this.Cursor = Cursors.Default;
            }
            catch (Exception) { }
        }
        public void PrintBond()
        {
            try
            {
                int id = 0;
                string user_name;
                string noFile;
                if (txtIdPatient.Text == "")
                    XtraMessageBox.Show("افرغ الحقول ثم قم بإضافة بيانات المريض");
                else
                    id = Convert.ToInt32(txtIdPatient.Text);
                this.Cursor = Cursors.WaitCursor;

                user_name = txtNamePatient.Text;
                noFile = txtNoFile.Text;
                // تحديد نوع السند 

                RP.ViweReports frmRep = new RP.ViweReports();

                RP.BONDCR reprot = new RP.BONDCR();

                dt.Clear();
                dt = B.SelectBond_Patient(id, user_name,noFile);

                reprot.SetDataSource(dt);
                reprot.SetParameterValue(0, id);
                reprot.SetParameterValue(1, user_name);
                reprot.SetParameterValue(2, noFile);

                //frmRep.crystalReportViewer1.Refresh();
                frmRep.crystalReportViewer1.ReportSource = reprot;

                frmRep.Show();

                this.Cursor = Cursors.Default;
            }
            catch (Exception) { }
        }

        private void txtAmuont_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtAmuont_EditValueChanged(object sender, EventArgs e)
        {
            //ChekPrice(135000);
                
        }

        private void cmTypeBond_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                DataTable dtprice = new DataTable();
                dtprice = sp.select_all_SurgeryPrices();
                for (int i = 0; i <= dtprice.Rows.Count - 1; i++)
                {
                    string namesurgery = dtprice.Rows[i][3].ToString();
                    if (cmTypeBond.Text == namesurgery)
                    {
                        txtAmuont.Text = dtprice.Rows[i][2].ToString();
                        cmbxBondAfterOrCash.Text = "نقداً";
                        //cmBefor.Text = namesurgery;
                        cmTypeBond.Text = namesurgery;
                        ChekPrice(Convert.ToDouble(txtAmuont.Text));
                        chbxBondState.Checked = true;
                        txtDiscount.Text = "0";
                    }

                }
            }
            catch (Exception) { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt_pit = new DataTable();
            try
            {
               

                int id;
                string user_name;
                if (txtIdPatient.Text == "")
                    id = 1;
                else
                    id = Convert.ToInt32(txtBondNumber.Text);
                this.Cursor = Cursors.WaitCursor;


                dt.Clear();
                dt = B.SelectBondBook(id);

                dt_pit = p.SelectpatientInNum(Convert.ToInt32(dt.Rows[0][2]));
                int id_p = Convert.ToInt32(dt_pit.Rows[0][1]);
                user_name = dt_pit.Rows[0][0].ToString();

                string open;
                if (chbxBondState.Checked)
                    open = "مقفل";
                else
                    open = "مفتوح";
                double disc = Convert.ToDouble(txtDiscount.Text);
                if (disc > Properties.Settings.Default.Less_disc)
                {

                    XtraMessageBox.Show("لايمكن ان يكون التخفيض اكثر من " + Properties.Settings.Default.Less_disc.ToString());
                }
                else
                { 
                    B.UpdateBondBook(id, cmBefor.SelectedIndex + 1, id_p, BL.UsersInfo.user_id, Convert.ToDouble(txtAmuont.Text), Convert.ToDouble(txtDiscount.Text), cmbxBondAfterOrCash.Text, open, cmTypeBond.Text, "");
                    MessageBox.Show("تم تعديل السند بنجاح");
                    PrintBond();
                }
            }
            catch (Exception) { }
        }

        private void txtBondNumber_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DataTable dtbond = new DataTable();
                dtbond = B.SelectBondBook(Convert.ToInt32(txtBondNumber.Text));
                if (e.KeyCode == Keys.Up)
                {
                    string befor;
                    if (dtbond.Rows[0][8].ToString() == "مقفل")
                        chbxBondState.Checked = true;
                    else
                        chbxBondState.Checked = false;

                    if (Convert.ToInt32(dtbond.Rows[0][1]) == 1)
                        befor = "معاينة";
                    else
                        befor = "عملية";
                    //XtraMessageBox.Show(dtbond.Rows[0][1].ToString());
                    

                    
                    //txtbon.Text = dtbond.Rows[0][0].ToString();
                    cmBefor.Text = befor;
                    txtIdPatient.Text = dtbond.Rows[0][2].ToString();
                    //txtAmuont.Text = dtbond.Rows[0][4].ToString();
                    txtDiscount.Text = dtbond.Rows[0][5].ToString();
                    cmbxBondAfterOrCash.Text = dtbond.Rows[0][6].ToString();
                    cmTypeBond.Text = dtbond.Rows[0][9].ToString();
                    txtAmuont.Text = dtbond.Rows[0][4].ToString();
                    dt.Clear();
                    dt = p.SelectpatientInNum(Convert.ToInt32(txtIdPatient.Text));
                    txtNamePatient.Text = dt.Rows[0][0].ToString();
                    txtNoFile.Text = dt.Rows[0][4].ToString();
                    txtIdPatient.Text = dt.Rows[0][1].ToString();
                }
            }
            catch (Exception) { XtraMessageBox.Show("تأكد من صحة رقم السند"); }
        }

        

        private void btnPrintBond_Click(object sender, EventArgs e)
        {
            PrintBond();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void cmBefor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtprice = new DataTable();
                DataTable dttype = new DataTable();
                dttype = by.SelectAllBondBookType();
                dtprice = sp.select_all_SurgeryPrices();
                for (int i = 0; i <= dttype.Rows.Count - 1; i++)
                {
                    string namesurgery = dtprice.Rows[i][3].ToString();
                    if (cmBefor.Text == namesurgery )
                    {
                        txtAmuont.Text = dtprice.Rows[i][2].ToString();
                        cmbxBondAfterOrCash.Text = "نقداً";
                        cmBefor.Text = namesurgery;
                        cmTypeBond.Text = namesurgery;
                        ChekPrice(Convert.ToDouble(txtAmuont.Text));
                        chbxBondState.Checked = true;
                    }

                }
            }catch(Exception){}

           
            //else if (cmBefor.Text == "سند عملية")
            //{
            //    txtAmuont.Text = dtprice.Rows[0][2].ToString();
            //    cmbxBondAfterOrCash.Text = "نقداً";
            //    cmBefor.Text = dtprice.Rows[0][3].ToString();
            //    cmTypeBond.Text = "ازالة المياه البيضاء";
            //    ChekPrice();
            //    chbxBondState.Checked = true;
            //}
            //else if (cmBefor.Text == "سند كشافة")
            //{
            //    txtAmuont.Text = dtprice.Rows[0][2].ToString();
            //    cmbxBondAfterOrCash.Text = "نقداً";
            //    cmBefor.Text = dtprice.Rows[0][3].ToString();
            //    cmTypeBond.Text = "كشافة";
            //    ChekPrice();
            //    chbxBondState.Checked = true;
            //}
            //else if (cmBefor.Text == "سند تقرير")
            //{
            //    txtAmuont.Text = dtprice.Rows[0][2].ToString();
            //    cmbxBondAfterOrCash.Text = "نقداً";
            //    cmBefor.Text = dtprice.Rows[0][3].ToString();
            //    cmTypeBond.Text = "تقرير";
            //    ChekPrice();
            //    chbxBondState.Checked = true;
            //}


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                btn_save_after.Visible = true;
                date_check.Visible = true;
                lab_date.Visible = true;
                lab_date_star.Visible = true;

                btnAddPatient.Enabled = false;
            }
            else
            {
                btn_save_after.Visible = false;
                date_check.Visible = false;
                lab_date.Visible = false;
                lab_date_star.Visible = false;

                btnAddPatient.Enabled = true;
            }
        }

        private void btn_save_after_Click(object sender, EventArgs e)
        {
            try
            {
                // تحديد جنس المريض
                string sex;
                if (rdioFemale.Checked)
                    sex = "انثى";
                else
                    sex = "ذكر";

                //انشاء رقم المريض بدون تكرار وبشكل متتابع
                BL.Cls_Git_Max_id_For_Tables gitmax = new BL.Cls_Git_Max_id_For_Tables();
                int Id;
                Id = gitmax.Git_Max_id() + 1;

                

                //التأكد من ان جميع الحقول ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtNamePatient.Text) || string.IsNullOrEmpty(txtAddressPatient.Text) || string.IsNullOrEmpty(txtPhonePatient.Text) || string.IsNullOrEmpty(txtAgePatient.Text) || string.IsNullOrEmpty(txtClinic_id_Patient.Text) || string.IsNullOrEmpty(date_check.Text))
                {
                    MessageBox.Show("قم بتعبئة جميع الحقول", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    // التأكد من رقم العيادة
                    if (!p.Checking_Repeat_ClincID(Convert.ToInt32(txtClinic_id_Patient.Text)))
                    {
                        MessageBox.Show("رقم غير صحيح", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    // التأكد من عدم تكرار رقم الملف

                    if (p.Checking_Repeat_NoFile(Convert.ToInt32(txtNoFile.Text)))
                    {
                        MessageBox.Show("رقم الملف موجود تأكد من صحة الرقم", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        //دالة الاضافة 
                        p.InsertPatientAfter(txtNamePatient.Text, Id,date_check.Value.Date.ToShortDateString(), txtAddressPatient.Text, Convert.ToInt32(txtNoFile.Text), txtPhonePatient.Text, txtAgePatient.Text, BL.UsersInfo.user_id, Convert.ToInt32(txtClinic_id_Patient.Text), sex, txtNotePatient.Text);

                        MessageBox.Show("تمت الاضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //var ms = MessageBox.Show()
                        //B.InsertBondBook(idBond, cmBefor.SelectedIndex + 1, Id, BL.UsersInfo.user_id, Convert.ToDouble(txtAmuont.Text), Convert.ToDouble(txtDiscount.Text), cmbxBondAfterOrCash.Text, open, cmTypeBond.Text, "");
                        //PrintBond();
                        Refrsh();
                        ClearTextPatient();
                        //sub(txtNamePatient);

                    }



                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("هناك خطاء تأكد من صحة البيانات" + ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(txtIdPatient.Text))
           {
               XtraMessageBox.Show("ادخل رقم المريض!"); 
           }
            else
           {
               PrintFile();
           }
        }

        private void txtDiscount_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ChekPrice(Convert.ToDouble(txtAmuont.Text));
            }
        }

        private void chk_data_tody_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_data_tody.Checked)
            {
                dt.Clear();
                dt = B.Select_Patient_tody(DateTime.Today, DateTime.Today);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dt.Clear();
                dt = p.SelectAllPatient();
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_delete_bond_Click(object sender, EventArgs e)
        {
            var ms = XtraMessageBox.Show("هل تريد حذف هذا السند؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (!string.IsNullOrEmpty(txtBondNumber.Text) && ms == DialogResult.Yes)
            {
                InsertBond();
                B.Delete_Bond(Convert.ToInt32(txtBondNumber.Text));
                XtraMessageBox.Show( "تم حذف السند بنجاح");
                ClearTextPatient();
            }
            else
            {
                 XtraMessageBox.Show( "تأكد من اختيار رقم السند للحذف");
            }
        }


    }
}
