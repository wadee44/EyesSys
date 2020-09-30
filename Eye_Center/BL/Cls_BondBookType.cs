using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_BondBookType
    {
        BL.UsersInfo usr = new UsersInfo();
        /*
            @Bond_Name nvarchar(100),
      @Bond_Number int,
      @Bond_Code nvarchar(100),
      @col1 nvarchar(50),
      @col2 nvarchar(50)
         */
        public void InsertBondBookType(int Bond_Number, string Bond_Code, string Bond_Name, string col1, string col2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Bond_Number", SqlDbType.Int);
            param[0].Value = Bond_Number;

            param[1] = new SqlParameter("@Bond_Code", SqlDbType.NVarChar,100);
            param[1].Value = Bond_Code;

            param[2] = new SqlParameter("@Bond_Name", SqlDbType.NVarChar,100);
            param[2].Value = Bond_Name;

            param[3] = new SqlParameter("@col1", SqlDbType.NVarChar, 50);
            param[3].Value = col1;

            param[4] = new SqlParameter("@col2", SqlDbType.NVarChar, 50);
            param[4].Value = col2;

            //Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertBondBookType", param);
            //Dal.CheckIsClosed();
        }


        public void UpdateBondBookType(int Bond_Number, string Bond_Code, string Bond_Name, string col1, string col2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Bond_Number", SqlDbType.Int);
            param[0].Value = Bond_Number;

            param[1] = new SqlParameter("@Bond_Code", SqlDbType.NVarChar, 100);
            param[1].Value = Bond_Code;

            param[2] = new SqlParameter("@Bond_Name", SqlDbType.NVarChar, 100);
            param[2].Value = Bond_Name;

            param[3] = new SqlParameter("@col1", SqlDbType.NVarChar, 50);
            param[3].Value = col1;

            param[4] = new SqlParameter("@col2", SqlDbType.NVarChar, 50);
            param[4].Value = col2;

           // Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateBondBookType", param);
            //Dal.CheckIsClosed();
        }

        public DataTable SelectBondBookType(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@BodnNumber", SqlDbType.Int);
            param[0].Value = id;

           // Dal.CheckIsOpen();
            dt = Dal.SelectData("SelectBondBookType", param);
            //Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectAllBondBookType()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
           // Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SelectAllBondBookType");
           // Dal.CheckIsClosed();

            return dt;
        }
    }
}
