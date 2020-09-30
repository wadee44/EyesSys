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
using System.Diagnostics;

namespace Eye_Center.PL
{
    public partial class My_Selected : DevExpress.XtraEditors.XtraForm
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        DataTable dt = new DataTable();
        

        public My_Selected()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = dataGridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                    view.ExportToPdf("بيانات   فحص عملية التخدير العام.pdf");

                Process pdfExport = new Process();

                pdfExport.StartInfo.FileName = "AcroRd32.exe";
                pdfExport.StartInfo.Arguments = "بيانات فحص عملية التخدير العام.pdf";
                pdfExport.Start();
            }
            catch (Exception)
            {

            }
        }

        private void btnNewQuory_Click(object sender, EventArgs e)
        {
            txtqury.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string qury = txtqury.Text;
            dt = dal.SelectDataWithQuery(qury);
            dataGridView1.DataSource = dt;
        }
    }
}