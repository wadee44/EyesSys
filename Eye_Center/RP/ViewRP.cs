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
    public partial class ViewRP : DevExpress.XtraEditors.XtraForm
    {
        public ViewRP()
        {
            InitializeComponent();
        }

        //RP.ViewRP xfr = new RP.ViewRP();
        BL.Cls_BondBook pi = new BL.Cls_BondBook();
        RP.PatientDateL xrp = new RP.PatientDateL();
        DataTable dtpdy = new DataTable();
        private void btn_lod_RP_Click(object sender, EventArgs e)
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
            //dt = bb.SelectBond_Patient(Convert.ToInt32(txt_id.Text), txt_name.Text.ToString(), txt_noFile.Text.ToString());
            dtpdy = pi.Select_Patient_tody(fromDate, toDate);
            xrp.DataSource = dtpdy;

            //xrp.label1.Text = txt_title.Text;
            documentViewer1.DocumentSource = xrp;
           // xfr.ShowDialog();
        }
    }
}