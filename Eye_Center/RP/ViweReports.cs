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

namespace Eye_Center.RP
{
    public partial class ViweReports : DevExpress.XtraEditors.XtraForm
    {
        
        public ViweReports()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViweReports_Load(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

        }

        DataTable dt = new DataTable();
        BL.Cls_BondBook B = new BL.Cls_BondBook();
        BL.Cls_Patient p = new BL.Cls_Patient();
        BL.SearchPatient srp = new BL.SearchPatient();
        public void PrintBondAfter()
        {
            try
            {
                DateTime fromDate;
                DateTime toDate;
                if (dateFrom.Text == "")
                    fromDate = DateTime.Today;
                else
                    fromDate = Convert.ToDateTime(dateFrom.EditValue);

                if (dateTo.Text == "")
                    toDate = DateTime.Today;
                else
                    toDate = Convert.ToDateTime(dateTo.EditValue);
                this.Cursor = Cursors.WaitCursor;
                // تحديد نوع السند 

                RP.ViweReports frmRep = new RP.ViweReports();

                RP.BondDateRP_After reprot = new RP.BondDateRP_After();

                dt.Clear();
                dt = B.BondDateRP_After(fromDate, toDate);

                reprot.SetDataSource(dt);
                reprot.SetParameterValue(0, fromDate);
                reprot.SetParameterValue(1, toDate);

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
                DateTime fromDate;
                DateTime toDate;
                if (dateFrom.Text == "")
                    fromDate = DateTime.Today;
                else
                    fromDate = Convert.ToDateTime(dateFrom.EditValue);

                if (dateTo.Text == "")
                    toDate = DateTime.Today;
                else
                    toDate = Convert.ToDateTime(dateTo.EditValue);
                this.Cursor = Cursors.WaitCursor;
                // تحديد نوع السند 

                RP.ViweReports frmRep = new RP.ViweReports();

                RP.BondDate reprot = new RP.BondDate();

                dt.Clear();
                dt = B.BondDateRP(fromDate, toDate);


                reprot.SetDataSource(dt);
                reprot.SetParameterValue(0, fromDate);
                reprot.SetParameterValue(1, toDate);

                //frmRep.crystalReportViewer1.Refresh();
                frmRep.crystalReportViewer1.ReportSource = reprot;

                frmRep.Show();

                this.Cursor = Cursors.Default;
            }
            catch (Exception) { }
        }

        public void PrintPatientSearch()
        {
            try
            {
                string name;
                if (txt_name_search.Text == "")
                    name = "";
                else
                    name = txt_name_search.Text;

                this.Cursor = Cursors.WaitCursor;
                // تحديد نوع السند 

                RP.ViweReports frmRep = new RP.ViweReports();

                RP.Patient_data reprot = new RP.Patient_data();

                dt.Clear();
                dt = srp.SearchPatients(name);

                reprot.SetDataSource(dt);
                reprot.SetParameterValue(0, name);

                //frmRep.crystalReportViewer1.Refresh();
                frmRep.crystalReportViewer1.ReportSource = reprot;

                frmRep.Show();

                this.Cursor = Cursors.Default;
            }
            catch (Exception) { }
        }

        private void btn_lod_RP_Click(object sender, EventArgs e)
        {
            PrintBond();
            PrintBondAfter();
        }

        private void btn_name_search_Click(object sender, EventArgs e)
        {
            PrintPatientSearch();
        }
        RP.ViewRP xfr = new RP.ViewRP();
        BL.Cls_BondBook pi = new BL.Cls_BondBook();
        RP.PatientDateL xrp = new RP.PatientDateL();
        DataTable dtpdy = new DataTable();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate;
                DateTime toDate;
                if (dateFrom.Text == "")
                    fromDate = DateTime.Today;
                else
                    fromDate = Convert.ToDateTime(dateFrom.EditValue);

                if (dateTo.Text == "")
                    toDate = DateTime.Today;
                else
                    toDate = Convert.ToDateTime(dateTo.EditValue);
                this.Cursor = Cursors.WaitCursor;
                // تحديد نوع السند 

                RP.ViweReports frmRep = new RP.ViweReports();

                RP.PatientRPDate reprot = new RP.PatientRPDate();

                dt.Clear();
                dt = B.Select_Patient_tody(fromDate, toDate);

                reprot.SetDataSource(dt);
                reprot.SetParameterValue(0, fromDate);
                reprot.SetParameterValue(1, toDate);

                //frmRep.crystalReportViewer1.Refresh();
                frmRep.crystalReportViewer1.ReportSource = reprot;

                frmRep.Show();

                this.Cursor = Cursors.Default;
            }
            catch (Exception) { }
            ////dt = bb.SelectBond_Patient(Convert.ToInt32(txt_id.Text), txt_name.Text.ToString(), txt_noFile.Text.ToString());
            //dtpdy = pi.Select_Patient_tody(dateFrom.EditValue.ToString(), dateTo.EditValue.ToString());
            //xrp.DataSource = dtpdy;

            ////xrp.label1.Text = txt_title.Text;
            //xfr.documentViewer1.DocumentSource = xrp;
            //xfr.ShowDialog();

        
        }
    }
}