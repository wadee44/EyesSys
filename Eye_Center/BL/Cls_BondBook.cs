using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_BondBook
    {
        //BL.UsersInfo usr = new UsersInfo();

        public void InsertBondBook(int BondNumber, int BondNumType, int Patient_id,int User_id, double BondAmount, double BondDiscount, string BondCash_or_After, string BondState,string col1,string col2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@BondNumber", SqlDbType.Int);
            param[0].Value = BondNumber;

            param[1] = new SqlParameter("@BondNumType", SqlDbType.Int);
            param[1].Value = BondNumType;

            param[2] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[2].Value = Patient_id;

            param[3] = new SqlParameter("@BondAmount", SqlDbType.Float);
            param[3].Value = BondAmount;

            param[4] = new SqlParameter("@BondDiscount", SqlDbType.Float);
            param[4].Value = BondDiscount;

            param[5] = new SqlParameter("@BondCash_or_After", SqlDbType.NVarChar,10);
            param[5].Value = BondCash_or_After;

            param[6] = new SqlParameter("@BondState", SqlDbType.NVarChar, 50);
            param[6].Value = BondState;

            param[7] = new SqlParameter("@User_id", SqlDbType.Int);
            param[7].Value = User_id;

            param[8] = new SqlParameter("@col1", SqlDbType.NVarChar, 50);
            param[8].Value = col1;

            param[9] = new SqlParameter("@col2", SqlDbType.NVarChar, 50);
            param[9].Value = col2;

           // Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertBondBook", param);
            //Dal.CheckIsClosed();
        }//

        public void InsertDeleted_Bond_Book(int BondNumber, int BondNumType, int Patient_id, int User_id, double BondAmount, double BondDiscount, string BondCash_or_After, string BondState, string col1, string col2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@BondNumber", SqlDbType.Int);
            param[0].Value = BondNumber;

            param[1] = new SqlParameter("@BondNumType", SqlDbType.Int);
            param[1].Value = BondNumType;

            param[2] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[2].Value = Patient_id;

            param[3] = new SqlParameter("@BondAmount", SqlDbType.Float);
            param[3].Value = BondAmount;

            param[4] = new SqlParameter("@BondDiscount", SqlDbType.Float);
            param[4].Value = BondDiscount;

            param[5] = new SqlParameter("@BondCash_or_After", SqlDbType.NVarChar, 10);
            param[5].Value = BondCash_or_After;

            param[6] = new SqlParameter("@BondState", SqlDbType.NVarChar, 50);
            param[6].Value = BondState;

            param[7] = new SqlParameter("@User_id", SqlDbType.Int);
            param[7].Value = User_id;

            param[8] = new SqlParameter("@col1", SqlDbType.NVarChar, 50);
            param[8].Value = col1;

            param[9] = new SqlParameter("@col2", SqlDbType.NVarChar, 50);
            param[9].Value = col2;

            // Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertDeleted_Bond_Book", param);
            //Dal.CheckIsClosed();
        }


        public void UpdateBondBook(int BondNumber, int BondNumType, int Patient_id, int User_id, double BondAmount, double BondDiscount, string BondCash_or_After, string BondState, string col1, string col2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@BondNumber", SqlDbType.Int);
            param[0].Value = BondNumber;

            param[1] = new SqlParameter("@BondNumType", SqlDbType.Int);
            param[1].Value = BondNumType;

            param[2] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[2].Value = Patient_id;

            param[3] = new SqlParameter("@BondAmount", SqlDbType.Float);
            param[3].Value = BondAmount;

            param[4] = new SqlParameter("@BondDiscount", SqlDbType.Float);
            param[4].Value = BondDiscount;

            param[5] = new SqlParameter("@BondCash_or_After", SqlDbType.NVarChar, 10);
            param[5].Value = BondCash_or_After;

            param[6] = new SqlParameter("@BondState", SqlDbType.NVarChar, 50);
            param[6].Value = BondState;

            param[7] = new SqlParameter("@User_id", SqlDbType.Int);
            param[7].Value = User_id;

            param[8] = new SqlParameter("@col1", SqlDbType.NVarChar, 50);
            param[8].Value = col1;

            param[9] = new SqlParameter("@col2", SqlDbType.NVarChar, 50);
            param[9].Value = col2;

            //Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateBondBook", param);
            //Dal.CheckIsClosed();
        }


        public DataTable SelectBondBook(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@data", SqlDbType.Int);
            param[0].Value = id;

            //Dal.CheckIsOpen();
            dt = Dal.SelectData("SelectBondBook", param);
            //Dal.CheckIsClosed();

            return dt;
        }

         public void Delete_Bond(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dal.ExecuteCommand("Delete_Bond", param);
        }
        //SelectBond_Patient

        public DataTable SelectBond_Patient(int id,string name ,string noFile)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            if (id.ToString() == DBNull.Value.ToString())
                param[0] = new SqlParameter("@data", (object)DBNull.Value);
            else
                param[0] = new SqlParameter("@data", id);

            if (name.ToString() == DBNull.Value.ToString())
                param[1] = new SqlParameter("@name", (object)DBNull.Value);
            else
                param[1] = new SqlParameter("@name", name);

            if (noFile.ToString() == DBNull.Value.ToString())
                param[2] = new SqlParameter("@noFile", (object)DBNull.Value);
            else
                param[2] = new SqlParameter("@noFile", noFile);
            

            //param[0] = new SqlParameter("@data", SqlDbType.Int);
            //param[0].Value = id;

            //Dal.CheckIsOpen();
            dt = Dal.SelectData("SelectBond_Patient", param);
            //Dal.CheckIsClosed();

            return dt;//F:\Desktop\سطح المكتب الاخير\مشاريع C#\DXApplication3\Eye_Center\BL\Cls_BondBook.cs
        }

        public DataTable Select_data_Surg_type(string data)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            if (data.ToString() == DBNull.Value.ToString())
                param[0] = new SqlParameter("@data", (object)DBNull.Value);
            else
                param[0] = new SqlParameter("@data", data);


            dt = Dal.SelectData("Select_data_Surg_type", param);

            return dt;
        }
        
        public DataTable BondDateRP(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();//( date, date)
            SqlParameter[] param = new SqlParameter[2];

            if (fromDate.ToString() == DBNull.Value.ToString())
                param[0] = new SqlParameter("@fromDate", (object)DBNull.Value);
            else
                param[0] = new SqlParameter("@fromDate", fromDate);

            if (toDate.ToString() == DBNull.Value.ToString())
                param[1] = new SqlParameter("@toDate", (object)DBNull.Value);
            else
                param[1] = new SqlParameter("@toDate", toDate);

            //param[0] = new SqlParameter("@data", SqlDbType.Int);
            //param[0].Value = id;

            //Dal.CheckIsOpen();
            dt = Dal.SelectData("BondDateRP", param);
            //Dal.CheckIsClosed();

            return dt;
        }//

        public DataTable BondDateRP_After(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();//( date, date)
            SqlParameter[] param = new SqlParameter[2];

            if (fromDate.ToString() == DBNull.Value.ToString())
                param[0] = new SqlParameter("@fromDate", (object)DBNull.Value);
            else
                param[0] = new SqlParameter("@fromDate", fromDate);

            if (toDate.ToString() == DBNull.Value.ToString())
                param[1] = new SqlParameter("@toDate", (object)DBNull.Value);
            else
                param[1] = new SqlParameter("@toDate", toDate);

            //param[0] = new SqlParameter("@data", SqlDbType.Int);
            //param[0].Value = id;

            //Dal.CheckIsOpen();
            dt = Dal.SelectData("BondDateRP_After", param);
            //Dal.CheckIsClosed();

            return dt;
        }

        public DataTable Select_Patient_tody(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();//( date, date)
            SqlParameter[] param = new SqlParameter[2];

            if (fromDate.ToString() == DBNull.Value.ToString())
                param[0] = new SqlParameter("@fromDate", (object)DBNull.Value);
            else
                param[0] = new SqlParameter("@fromDate", fromDate);

            if (toDate.ToString() == DBNull.Value.ToString())
                param[1] = new SqlParameter("@toDate", (object)DBNull.Value);
            else
                param[1] = new SqlParameter("@toDate", toDate);

            //param[0] = new SqlParameter("@data", SqlDbType.Int);
            //param[0].Value = id;

            //Dal.CheckIsOpen();
            dt = Dal.SelectData("Select_Patient_tody", param);
            //Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectAllBondBook()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
           // Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SelectAllBondBook");
           // Dal.CheckIsClosed();

            return dt;
        }

     
    }
}
