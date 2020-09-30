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
    public partial class ViweReportsSurg : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        BL.Cls_SurgeryPrices sp = new BL.Cls_SurgeryPrices();
        BL.Cls_BondBook B = new BL.Cls_BondBook();
        public ViweReportsSurg()
        {
            InitializeComponent();
        }

        private void ViweReportsSurg_Load(object sender, EventArgs e)
        {
            dt = sp.select_all_SurgeryPrices();

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SurgeryPrice_name";
            comboBox1.ValueMember = "SurgeryPrice_name";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string nameBond;
                if (comboBox1.Text == "")
                    nameBond = "معاينة";
                else
                    nameBond = comboBox1.SelectedValue.ToString();

                this.Cursor = Cursors.WaitCursor;
                // تحديد نوع السند 

                RP.ViweReportsSurg frmRep = new RP.ViweReportsSurg();

                RP.Patient_data_Surg_type reprot = new RP.Patient_data_Surg_type();

                dt.Clear();
                dt = B.Select_data_Surg_type(nameBond);

                reprot.SetDataSource(dt);
                reprot.SetParameterValue(0, nameBond);

                //frmRep.crystalReportViewer1.Refresh();
                frmRep.crystalReportViewer2.ReportSource = reprot;

                frmRep.Show();
                this.Hide();

                this.Cursor = Cursors.Default;
            }
            catch (Exception) { }
        }
    }
}