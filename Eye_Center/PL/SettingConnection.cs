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
    public partial class SettingConnection : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public SettingConnection()
        {
            InitializeComponent();
            
        }

        public DataTable SelectAllUsers()
        {

            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            dt = Dal.SelectDataWithQuery("SelectAllUsers");

            return dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
                SelectAllUsers();
                Properties.Settings.Default.ServerName = txtServerName.Text;
                Properties.Settings.Default.DatabaseName = txtDatabaseName.Text;
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.UserPassword = txtUserPassword.Text;
                if (check.Checked == false)
                    Properties.Settings.Default.Check = false;
                else
                    Properties.Settings.Default.Check = true;

                Properties.Settings.Default.Save();


                DevExpress.XtraEditors.XtraMessageBox.Show("تمت عملية الاتصال بنجاح ^_^ \n" + dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

            }
        }

        private void btnBuckUp_Click(object sender, EventArgs e)
        {

            string msg = "تم حفظ مسار النسخة الاحتياطية بنجاح";

            //String dataBaseName = Properties.Settings.Default.DatabaseName; // "The Data Base Name"
            //string connectionString = @"Server=" + Properties.Settings.Default.ServerName + "; Database=" + Properties.Settings.Default.DatabaseName + ";Integrated Security = false; USER ID=" + Properties.Settings.Default.UserName + ";password=" + Properties.Settings.Default.UserPassword + "";


            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PathBuckUp = folder.SelectedPath;
                Properties.Settings.Default.Save();
                DevExpress.XtraEditors.XtraMessageBox.Show(msg);
                //Eyes_Center.BL.Backup_Restore_DB backup = new Eyes_Center.BL.Backup_Restore_DB(connectionString);

                //// To Test
                // MessageBox.Show("folderPath : " + folderPath);

                //Cursor.Current = Cursors.WaitCursor;

                // backup.BackupAllDatabases(folderPath);
                //string result = backup.BackupDatabase(dataBaseName, Properties.Settings.Default.PathBuckUp);

                //Cursor.Current = Cursors.Default;

                //if (!result.Equals(""))
                //    DevExpress.XtraEditors.XtraMessageBox.Show(result, "ERROR");
                //else
                //    DevExpress.XtraEditors.XtraMessageBox.Show(msg);

            }

        }
        

        private void SettingConnection_Load(object sender, EventArgs e)
        {
            txtServerName.Text = Properties.Settings.Default.ServerName;
            txtDatabaseName.Text = Properties.Settings.Default.DatabaseName;
            txtUserName.Text = Properties.Settings.Default.UserName;
            txtUserPassword.Text = Properties.Settings.Default.UserPassword;

            if (Properties.Settings.Default.Check == false)
                check.Checked = false;
            else
                check.Checked = true;
        }

    }
}