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
    public partial class Surgery : DevExpress.XtraEditors.XtraUserControl
    {

        DataTable dt = new DataTable();
        BL.Cls_Surgery srg = new BL.Cls_Surgery();
        BL.Cls_Git_Max_id_For_Tables gmxsrg = new BL.Cls_Git_Max_id_For_Tables();
        BL.Cls_Patient p = new BL.Cls_Patient();
        int ID;
        
        public Surgery()
        {
            
            InitializeComponent();
            ScreanPriv();

            dt = srg.SelectAllSurgery();
            dataGridView1.DataSource = dt;
            sub(txtNameSurgery);
           // txtNameSurgery.ControlAdded(dt.ToString());

        }

        public void ScreanPriv()
        {
            dt.Clear();
            dt = BL.Cls_Priv.SelectPrivScreen(14, BL.UsersInfo.user_id);

            if (dt.Rows[0][0].ToString() == "False" || dt.Rows[0][0].ToString() == string.Empty)
                btnPrintSurgery.Enabled = false;
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
                dt = sp.SearchPatients(txtNameSurgery.SelectedItem.ToString());

                //MessageBox.Show(dt.Rows.Count.ToString());
                if (dt.Rows.Count > 0)
                {
                    string note;
                    int id, no;

                    //DataTable dtp = new DataTable();

                    //dtp = sp.SearchPatients(txtNameSurgery.SelectedItem.ToString());


                    //ID = gmxsrg.Get_max_id_Surgery() + 1;
                    //dgvName.DataSource = dtp;


                    id = Convert.ToInt32(dt.Rows[0][1].ToString());
                    note = dt.Rows[0][10].ToString();
                    no = Convert.ToInt32(dt.Rows[0][4].ToString());


                    txtIDSurgery.Text = id.ToString();
                    txtNoteSurgery.Text = note;
                    txtNoFileSurgery.Text = no.ToString();
                    txtIDSURG.Text = ID.ToString();
                    

                }
            }
            catch(Exception)
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

            dt = srg.SelectAllSurgery();
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
            txtIDSURG.Clear();
            txtIDSurgery.Clear();
            txtNameAssistantSurgery.Clear();
            txtAxial.Clear();
            //txtNameSurgery1.Clear();
            txtNoFileSurgery.Clear();
            txtNoteSurgery.Clear();
            txtPlaceSurgery.Clear();
            txtTypeSurgery.Clear();
            txtSurgeryName.Clear();
            txtTreatment.Clear();
            txtIoIPower.Clear();
            txtBloodPressure.Clear();
            txtBloodSuger.Clear();
            cmbxAdmit.Text = "";
            cmbxNarcosis.Text = "";
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
            dt = srg.SelectSurgery(Convert.ToInt32(txtIDSurgery.Text));
            this.dataGridView1.DataSource = dt;
        }
        /// <summary>
        /// //0000000000000000000//REFRSH\\000000000000000000000000000000000000000000000 END
        /// </summary

        private void btnViewSurgery_Click(object sender, EventArgs e)
        {
           // grbSurgeryViewData.Visible = true;
            Search_All_Name();
        }

        

        private void btnNewSurgery_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //string L_or_R;
            try
            {
                ClearText();
                //txtIDSURG.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //txtIDSurgery.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //txtNoFileSurgery.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                //txtSurgeryName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //txtNameAssistantSurgery.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //dtbDateSurgery.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                //txtPlaceSurgery.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                //txtTypeSurgery.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                //L_or_R = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                //cmbxAdmit.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                //cmbxNarcosis.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                //txtAxial.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                //txtIoIPower.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                //txtBloodPressure.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                //txtBloodSuger.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                //txtTreatment.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();

                /*00000000000000000000000000000000000000000000

                BL.SearchPatient sp = new BL.SearchPatient();
                dt = sp.SearchPatients(txtNameChecked.Text);

                if (dt.Rows.Count > 0)
                {
                    string name;

                    DataTable dtp = new DataTable();

                    dtp = sp.SearchPatients(txtNameChecked.Text);

                    name = dtp.Rows[0][0].ToString();


                    txtNameChecked.Text = name;
                }
                00000000000000000000000000000000000000000000*/

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

        private void btnAddSurgery_Click(object sender, EventArgs e)
        {

            try
            {

                string L_or_R;
                if (rdioL_Checked.Checked)
                    L_or_R = "L";
                else
                    L_or_R = "R";

                ID = gmxsrg.Get_max_id_Surgery() + 1;//dtbDateSurgery.Value.Date.ToString()


                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDSurgery.Text) || string.IsNullOrEmpty(txtNoFileSurgery.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //دالة الاضافة 
                    srg.InsertSurgery(txtSurgeryName.Text, ID, Convert.ToInt32(txtNoFileSurgery.Text), dtbDateSurgery.Value.Date.ToShortDateString(), txtPlaceSurgery.Text, txtTypeSurgery.Text, Convert.ToChar(L_or_R), cmbxAdmit.Text, cmbxNarcosis.Text, txtTreatment.Text, Convert.ToInt32(txtIDSurgery.Text), BL.UsersInfo.user_id, txtAxial.Text, txtIoIPower.Text, txtBloodPressure.Text, txtBloodSuger.Text, txtNameAssistantSurgery.Text);

                    Refrsh();

                    MessageBox.Show("تمت الاضافة بنجاح", "إضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //ClearText();
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

                string L_or_R;
                if (rdioL_Checked.Checked)
                    L_or_R = "L";
                else
                    L_or_R = "R";



                //التأكد من ان جميع الحقول المطلوبة ممتلئة وليست فارغة
                if (string.IsNullOrEmpty(txtIDSurgery.Text) || string.IsNullOrEmpty(txtNoFileSurgery.Text))
                {
                    MessageBox.Show("قم بكتابة رقم المريض ورقم الملف", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    //دالة التعديل 
                    srg.UpdateSurgery(txtSurgeryName.Text, Convert.ToInt32(txtIDSURG.Text), Convert.ToInt32(txtNoFileSurgery.Text), dtbDateSurgery.Value.Date.ToShortDateString(), txtPlaceSurgery.Text, txtTypeSurgery.Text, Convert.ToChar(L_or_R), cmbxAdmit.Text, cmbxNarcosis.Text, txtTreatment.Text, Convert.ToInt32(txtIDSurgery.Text), BL.UsersInfo.user_id, txtAxial.Text, txtIoIPower.Text, txtBloodPressure.Text, txtBloodSuger.Text, txtNameAssistantSurgery.Text);

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

       

        private void txtNameSurgery_Leave(object sender, EventArgs e)
        {
            //dgvName.Hide();
        }

        private void btnPrintSurgery_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات العمليات.pdf");

                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات العمليات.pdf";
                pdfExport.Start();
            }
            catch(Exception)
            {

            }
        }
        

        private void dataGridView1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {

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

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        


        private void txtNameSurgery_SelectedIndexChanged(object sender, EventArgs e)
        {
                Search_Name();
            
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            

            string L_or_R;
            try
            {
                ClearText();
                txtIDSURG.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSurgery_id).ToString();
                txtIDSurgery.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPatient_id).ToString();
                txtNoFileSurgery.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNoFile).ToString();
                txtSurgeryName.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colName).ToString();
                L_or_R = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colL_or_R_Eye).ToString();
                txtPlaceSurgery.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colPlace).ToString();
                txtTypeSurgery.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colType).ToString();
                dtbDateSurgery.Value = Convert.ToDateTime((gridView1.GetRowCellValue(gridView1.FocusedRowHandle,  colDate)));
                cmbxAdmit.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colAdmit_For).ToString();
                cmbxNarcosis.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colNarcosis).ToString();
                txtTreatment.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colTreatment).ToString();
                txtNameAssistantSurgery.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colName_Assistant).ToString();
                

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

        private void btnSearchSurgery_Click_1(object sender, EventArgs e)
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

                dt = srg.SelectSurgery(Convert.ToInt32(txtSearch.Text));

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

                    txtNameSurgery.Text = name;
                    txtIDSurgery.Text = id.ToString();
                    txtNoteSurgery.Text = note;
                    txtNoFileSurgery.Text = no.ToString();*/

                    

                }
            }
                catch(Exception ex)
            {
                    MessageBox.Show("لا يمكن استخدام الحروف في مربع النص هذا .. تأكد من ادخال رقم المريض او رقم الملف  " + ex,"خطاء",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          }
        }

    }

