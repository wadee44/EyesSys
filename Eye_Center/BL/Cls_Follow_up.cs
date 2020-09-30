using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    
    class Cls_Follow_up
    {
        public void InsertFollow_up(int FollowUpID,int NoFile,string Date, string Result ,string Treatment ,int Patient_id ,int User_id ,string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@Result", SqlDbType.Text);
            param[0].Value = Result;

            param[1] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[1].Value = Patient_id;

            param[2] = new SqlParameter("@Treatment", SqlDbType.Text);
            param[2].Value = Treatment;

            param[3] = new SqlParameter("@User_id", SqlDbType.Int);
            param[3].Value = User_id;

            param[4] = new SqlParameter("@Note1", SqlDbType.Text);
            param[4].Value = Note1;

            param[5] = new SqlParameter("@Date", SqlDbType.NVarChar,30);
            param[5].Value = Date;

            param[6] = new SqlParameter("@FollowUpID", SqlDbType.Int);
            param[6].Value = FollowUpID;

            param[7] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[7].Value = NoFile;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertFollow_up", param);
            Dal.CheckIsClosed();
        }

        public void UpdateFollow_up(int FollowUpID, int NoFile, string Date, string Result, string Treatment, int Patient_id, int User_id, string Note1, string Note2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@Result", SqlDbType.Text);
            param[0].Value = Result;

            param[1] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[1].Value = Patient_id;

            param[2] = new SqlParameter("@Treatment", SqlDbType.Text);
            param[2].Value = Treatment;

            param[3] = new SqlParameter("@User_id", SqlDbType.Int);
            param[3].Value = User_id;

            param[4] = new SqlParameter("@Note1", SqlDbType.Text);
            param[4].Value = Note1;

            param[5] = new SqlParameter("@Date", SqlDbType.NVarChar, 30);
            param[5].Value = Date;

            param[6] = new SqlParameter("@FollowUpID", SqlDbType.Int);
            param[6].Value = FollowUpID;

            param[7] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[7].Value = NoFile;

            param[8] = new SqlParameter("@Note2", SqlDbType.Text);
            param[8].Value = Note2;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateFollow_up", param);
            Dal.CheckIsClosed();
        }


        public DataTable SelectFollow_up(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelecFollow_up", param);
            Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectAllFollowUp()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SelectAllFollowUp");
            Dal.CheckIsClosed();

            return dt;
        }

    }
}
