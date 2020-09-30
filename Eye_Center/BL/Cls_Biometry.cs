using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Biometry
    {

        public void Insert_Biometry(int BiometryID, int NoFile, string OD_or_OS, string K1, string K2, string Axial_length, string A_Constant, string AC_and_IOL, string PC_and_IOL, string B_Scan, int Patient_id, int User_id, string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@OD_or_OS", SqlDbType.Text);
            param[0].Value = OD_or_OS;

            param[1] = new SqlParameter("@K1", SqlDbType.Text);
            param[1].Value = K1;

            param[2] = new SqlParameter("@K2", SqlDbType.Text);
            param[2].Value = K2;

            param[3] = new SqlParameter("@Axial_length", SqlDbType.Text);
            param[3].Value = Axial_length;

            param[4] = new SqlParameter("@A_Constant", SqlDbType.Text);
            param[4].Value = A_Constant;

            param[5] = new SqlParameter("@AC_and_IOL", SqlDbType.Text);
            param[5].Value = AC_and_IOL;

            param[6] = new SqlParameter("@PC_and_IOL", SqlDbType.Text);
            param[6].Value = PC_and_IOL;

            param[7] = new SqlParameter("@B_Scan", SqlDbType.Text);
            param[7].Value = B_Scan;                         

            param[8] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[8].Value = Patient_id;

            param[9] = new SqlParameter("@User_id", SqlDbType.Int);
            param[9].Value = User_id;

            param[10] = new SqlParameter("@Note1", SqlDbType.Text);
            param[10].Value = Note1;

            param[11] = new SqlParameter("@BiometryID", SqlDbType.Int);
            param[11].Value = BiometryID;

            param[12] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[12].Value = NoFile;

            //Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertBiometry", param);
           // Dal.CheckIsClosed();

        }


        public void Update_Biometry(int BiometryID,int NoFile ,string OD_or_OS, string K1, string K2, string Axial_length, string A_Constant, string AC_and_IOL, string PC_and_IOL, string B_Scan, int Patient_id, int User_id, string Note1, string Note2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@OD_or_OS", SqlDbType.Char, 2);
            param[0].Value = OD_or_OS;

            param[1] = new SqlParameter("@K1", SqlDbType.Text);
            param[1].Value = K1;

            param[2] = new SqlParameter("@K2", SqlDbType.Text);
            param[2].Value = K2;

            param[3] = new SqlParameter("@Axial_length", SqlDbType.Text);
            param[3].Value = Axial_length;

            param[4] = new SqlParameter("@A_Constant", SqlDbType.Text);
            param[4].Value = A_Constant;

            param[5] = new SqlParameter("@AC_and_IOL", SqlDbType.Text);
            param[5].Value = AC_and_IOL;

            param[6] = new SqlParameter("@PC_and_IOL", SqlDbType.Text);
            param[6].Value = PC_and_IOL;

            param[7] = new SqlParameter("@B_Scan", SqlDbType.Text);
            param[7].Value = B_Scan;

            param[8] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[8].Value = Patient_id;

            param[9] = new SqlParameter("@User_id", SqlDbType.Int);
            param[9].Value = User_id;

            param[10] = new SqlParameter("@Note1", SqlDbType.Text);
            param[10].Value = Note1;

            param[11] = new SqlParameter("@Note2", SqlDbType.Text);
            param[11].Value = Note2;

            param[12] = new SqlParameter("@BiometryID", SqlDbType.Int);
            param[12].Value = BiometryID;

            param[13] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[13].Value = NoFile;

           // Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateBiometry", param);
            //Dal.CheckIsClosed();
        }

        public DataTable SelecBiometry(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

           // Dal.CheckIsOpen();
            dt = Dal.SelectData("SelecBiometry", param);
            //Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectAllBiometry()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            //Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SelectAllBiometry");
            //Dal.CheckIsClosed();

            return dt;
        }
    }
}
