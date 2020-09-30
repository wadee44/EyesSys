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

namespace Eye_Center.PL
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            //BackUpData();
            Application.Exit();
        }
        public void BackUpData()
        {
            try
            {
                string msg = "تم انشاء النسخة الاحتياطية بنجاح";
                string folderPath;
                string dataBaseName = Properties.Settings.Default.DatabaseName; // "The Data Base Name"
                string connectionString = Properties.Settings.Default.Eye_CenterConnectionString1;



                folderPath = Properties.Settings.Default.PathBuckUp;

                BL.Backup_Restore_DB backup = new BL.Backup_Restore_DB(connectionString);

                //// To Test
                // MessageBox.Show("folderPath : " + folderPath);

                Cursor.Current = Cursors.WaitCursor;

                // backup.BackupAllDatabases(folderPath);
                string result = backup.BackupDatabase(dataBaseName, folderPath);

                Cursor.Current = Cursors.Default;

                if (!result.Equals(""))
                    MessageBox.Show(result, "ERROR");
                else
                    MessageBox.Show(msg);

            }
            catch (Exception) { }
        }
        private void btnPatient_Click(object sender, TileItemEventArgs e)
        {
            PL.Patient pi = new Patient();
            pi.surgeryName(pi.cmTypeBond);

            pnlCenter.Controls.Clear();
            Patient pali = new Patient();
            pnlCenter.Controls.Add(pali);
            
        }

        private void btnCheck_Click(object sender, TileItemEventArgs e)
        {

            pnlCenter.Controls.Clear();
            Routine_Check rch = new Routine_Check();
            pnlCenter.Controls.Add(rch);

            
        }

        private void btnFollowUp_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Follow_up fall = new Follow_up();
            pnlCenter.Controls.Add(fall);

            
        }

        private void btnNormalFowllowUp_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Follow_up fall = new Follow_up();
            pnlCenter.Controls.Add(fall);
        }

        private void btnPost_Op_Fowllow_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Post_Operative_Follow_up pofu = new Post_Operative_Follow_up();
            pnlCenter.Controls.Add(pofu);
        }

        private void btnRoutineCheck_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Routine_Check rch = new Routine_Check();
            pnlCenter.Controls.Add(rch);
        }

        private void btnBiomerty_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Biometry chpa = new Biometry();
            pnlCenter.Controls.Add(chpa);
        }

        private void btnChecked_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Checked_Patient chpa = new Checked_Patient();
            pnlCenter.Controls.Add(chpa);
        }

        private void btnOprition_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Surgery surg = new Surgery();
            pnlCenter.Controls.Add(surg);
           
        }

        private void btnOutCheck_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Local_Narcosis locnar = new Local_Narcosis();
            pnlCenter.Controls.Add(locnar);
            
        }

        private void btnLocal_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Local_Narcosis locnar = new Local_Narcosis();
            pnlCenter.Controls.Add(locnar);
        }

        private void btnGlobal_ItemClick(object sender, TileItemEventArgs e)
        {
            pnlCenter.Controls.Clear();
            Global_Narcosis glonar = new Global_Narcosis();
            pnlCenter.Controls.Add(glonar);
        }

        private void btnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            SettingSystem stsy = new SettingSystem();
            stsy.Show();
            

            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                pnlCenter.Controls.Clear();
            Home h = new Home();
            pnlCenter.Controls.Add(tileControl1);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void btnReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void d_Click(object sender, EventArgs e)
        {

        }
        
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RP.ViweReports vr = new RP.ViweReports();
            vr.grob_BondDateRP.Visible = true;
            vr.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RP.ViweReports vr = new RP.ViweReports();
            vr.txt_name_search.Visible = true;
            vr.btn_name_search.Visible = true;
            vr.Show();
        }
        RP.ViewRP xfr = new RP.ViewRP();
        BL.Cls_BondBook pi = new BL.Cls_BondBook();
        RP.PatientDateL xrp = new RP.PatientDateL();
        DataTable dtpdy = new DataTable();
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            RP.ViweReportsSurg vr = new RP.ViweReportsSurg();
            vr.Show();
        }
    }
}