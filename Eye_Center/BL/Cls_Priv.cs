using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Priv
    {

        

        public void UpdatePrivm(int UserID, int ScreenID, Boolean view, Boolean add, Boolean update, Boolean print)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@UserID", SqlDbType.Int);
            param[0].Value = UserID;

            param[1] = new SqlParameter("@ScreenID", SqlDbType.Int);
            param[1].Value = ScreenID;

            param[2] = new SqlParameter("@View", SqlDbType.Bit);
            param[2].Value = view;

            param[3] = new SqlParameter("@Add", SqlDbType.Bit);
            param[3].Value = add;

            param[4] = new SqlParameter("@Update", SqlDbType.Bit);
            param[4].Value = update;

            param[5] = new SqlParameter("@Print", SqlDbType.Bit);
            param[5].Value = print;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdatePriv", param);
            Dal.CheckIsClosed();
        }

        public static DataTable SelectPrivScreen(int idscreen,int userid)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@idscreen", SqlDbType.Int);
            param[0].Value = idscreen;

            param[1] = new SqlParameter("@userid", SqlDbType.Int);
            param[1].Value = userid;

            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelectPrivScreen", param);
            Dal.CheckIsClosed();

            return dt;
        } 
    }
}
