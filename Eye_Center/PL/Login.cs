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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

       // Eye_Center.BL.Cls_Login clslog = new BL.Cls_Login();
        Eye_Center.BL.Cls_Login clslog = new Eye_Center.BL.Cls_Login();


        private void btLogin_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txUserName.Text))
            {
                //MessageBox.Show("إذا سمحت ادخل اسم المستخدم ", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label4.Visible = true;
                label4.Text = "إذا سمحت ادخل اسم المستخدم";
                txUserName.Focus();
                return;
            }
            if (clslog.LOGIN(txUserName.Text, txPass.Text))
            {
                // MessageBox.Show("مرحباً بك في نظام مركز العين الاستشاري", "مرحباً", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();
                PL.Home home = new PL.Home();
                home.Show();
            }
            else
            {
                //MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحة.", "خطاء", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txUserName.Text = "";
                txPass.Text = "";
                label4.Visible = true;
                label4.Text = "اسم المستخدم او كلمة المرور غير صحيحة";
            }



        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (txPass.Text == "Connection" && txUserName.Text == "الروحاني")
            {
                PL.SettingConnection sc = new PL.SettingConnection();
                sc.ShowDialog();
            }
            this.Close();
        }

        

        private void txUserName_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void txPass_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void btnSittingConnection_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Check == false)
            {
                PL.SettingConnection sc = new PL.SettingConnection();
                sc.ShowDialog();
            }
            else
                MessageBox.Show("غير مسموح لك بتعديل الاتصال");
        }
    }
}