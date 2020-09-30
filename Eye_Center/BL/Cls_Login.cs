using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Eye_Center.BL;

namespace Eye_Center.BL
{
    class Cls_Login
    {
        public bool LOGIN(string username, string Password)
        {
            
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@NameSystem", SqlDbType.NVarChar, 100);
            param[0].Value = username;

            param[1] = new SqlParameter("@Pass", SqlDbType.NVarChar, 100);
            param[1].Value = Password;

            DataTable dt = new DataTable();
            dt = Dal.SelectData("Login", param);
            //static string name ;
            if (dt.Rows.Count > 0)
            {
                UsersInfo.name        = dt.Rows[0][0].ToString();
                UsersInfo.user_id     = Convert.ToInt32(dt.Rows[0][1]);
                UsersInfo.NameSystem = dt.Rows[0][2].ToString();
                UsersInfo.shift = dt.Rows[0][3].ToString();
                UsersInfo.Pass = dt.Rows[0][4].ToString();
                UsersInfo.No_type = dt.Rows[0][5].ToString();
                UsersInfo.Phone = dt.Rows[0][6].ToString();
                UsersInfo.Email = dt.Rows[0][7].ToString();
                UsersInfo.Sex         = dt.Rows[0][8].ToString();
                return true;
            }
            

            return false;
        }
    }
}
