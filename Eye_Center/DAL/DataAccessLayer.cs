using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Eye_Center.DAL
{
    class DataAccessLayer
    {
        
            public static string DB_NAME = Eye_Center.Properties.Settings.Default.DatabaseName;
            public static string SERVER_NAME = Eye_Center.Properties.Settings.Default.ServerName;
         //public static string SECURITY = "Integrated Security = false";
        public static string USERNAME = Eye_Center.Properties.Settings.Default.UserName;
        public static string USERPASS = Eye_Center.Properties.Settings.Default.UserPassword;

        public static string SERVER_CONN = @"Server=" + SERVER_NAME + "; Integrated Security = false; USER ID=" + USERNAME + "; password=" + USERPASS + "";
        public static string DB_CONN = @"Server=" + SERVER_NAME + "; Database=" + DB_NAME + "; Integrated Security = false; USER ID=" +  USERNAME + "; password=" + USERPASS +"";

            // new SqlConnection(@"Server=.\; Database=GasOffice_db; Integrated Security = true")
            // new SqlConnection(@"Server=.\; Database=GasOffice_db; user id=root;password=123")
            // new SqlConnection(@"Server=.\; Database=GasOffice_db; uid=root;pwd=123;")

            SqlConnection sqlconnection = new SqlConnection();

            // Initialize database connection
            public DataAccessLayer()
            {
                DB_CONN = @"Server=" + SERVER_NAME + "; Database=" + DB_NAME +"; Integrated Security = false; USER ID=" + USERNAME + "; password=" + USERPASS + "";
            sqlconnection = new SqlConnection(DB_CONN);
            }

            //private SqlConnection Open()
            //{
            //    if (CheckIsClosed())
            //    {
            //        sqlconnection.Open();
            //    }
            //    return sqlconnection;
            //}

            public void CheckConnection()
            {
                Open();
                if (CheckIsOpen())
                    InformationMessage("Connection is : True");
                //else
                //    ErrorMessage("Connection is : False");
            }
            public bool CheckIsOpen()
            {
                if (sqlconnection.State == ConnectionState.Open)
                    return true;
                return false;
            }

            public bool CheckIsClosed()
            {
                if (sqlconnection.State != ConnectionState.Open)
                    return true;
                return false;
            }

            // Open database connection
            private void Open()
            {
                if (CheckIsClosed())
                {
                    try
                    {
                        sqlconnection.Open();
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage("" + ex.Message);
                    }
                }
            }

            // Close database connection
            private void Close()
            {
                if (CheckIsOpen())
                {
                    try
                    {
                        sqlconnection.Close();
                    }
                    catch (Exception ex)
                    {
                        ErrorMessage("" + ex.Message);
                    }
                }
            }

            //Read from database
            public DataTable SelectData(string stored_procedure, SqlParameter[] param)
            {
                //using (Open())
                //{
                try
                {
                    Open();
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.CommandText = stored_procedure;
                    sqlcmd.Connection = sqlconnection;

                    if (param != null)
                    {
                        for (int i = 0; i < param.Length; i++)
                        {
                            sqlcmd.Parameters.Add(param[i]);
                        }
                    }
                    SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    ErrorMessage("Somthing Wrong! " + ex.Message);
                    return null;
                }
                //}

            }
            public DataTable SelectDataWithQuery(string query)
            {
                //using (Open())
                //{
                try
                {
                    Open();
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.CommandType = CommandType.Text;
                    sqlcmd.CommandText = query;
                    sqlcmd.Connection = sqlconnection;

                    SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    ErrorMessage("Somthing Wrong! " + ex.Message);
                    return null;
                }
                //}

            }

            //Insert, update and delete from database
            // return 1 mean all thing is ok
            public int ExecuteCommand(string stored_procedure, SqlParameter[] param)
            {
                try
                {
                    // BL.GlobalFunction gFunc = new BL.GlobalFunction();
                    Open();
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.CommandText = stored_procedure;
                    sqlcmd.Connection = sqlconnection;
                    //MessageBox.Show(param.ToString());
                    if (param != null)
                        sqlcmd.Parameters.AddRange(param);
                    
                    int result = sqlcmd.ExecuteNonQuery();

                    Close();
                    //  gFunc.MessageInfo("result : " + result);
                    return result;
                }
                catch (Exception ex)
                {
                    ErrorMessage("Somthing Wrong In Execute! " + ex.Message);
                    return -1;
                }
            }

            // The MessageBox
            private void InformationMessage(string msg)
            {
                MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void ErrorMessage(string msg)
            {
                MessageBox.Show(msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }
}
