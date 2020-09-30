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
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {

        BL.Cls_BondBook bb = new BL.Cls_BondBook();
        DataTable dt = new DataTable();
        public XtraForm2()
        {
            InitializeComponent();
        }

        RP.XtraForm1 xfr = new XtraForm1();
        RP.XtraReport1 xrp = new XtraReport1();

        private void btn_print_Click(object sender, EventArgs e)
        {
            //int idp = ;
            dt = bb.SelectBond_Patient(Convert.ToInt32(txt_id.Text), txt_name.Text.ToString(),txt_noFile.Text.ToString());
            xrp.DataSource = dt;
            xrp.label1.Text = txt_title.Text;
            xfr.documentViewer1.DocumentSource = xrp;
            xfr.Show();

        }
    }
}