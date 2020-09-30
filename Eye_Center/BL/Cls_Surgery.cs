using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{

    /*,[Axial_Length]		                                                                                                                                                                           
      ,[IoI_Power]			                                                                                                                                                                           
      ,[Blood_Pressure]		                                                                                                                                                                           
      ,[Blood_Sugar]		                                                                                                                                                                           
     * 14
     * */
    class Cls_Surgery
    {
        public void InsertSurgery(string Name, int Surgery_id, int NoFile, string Date, string Place, string Type, char L_or_R_Eye, string Admit_For, string Narcosis, string Treatment, int Patient_id, int User_id, string Axial_Length, string IoI_Power, string Blood_Pressure, string Blood_Sugar, string Assistant)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[17];


            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar,50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Date", SqlDbType.NVarChar,30);
            param[1].Value = Date;

            param[2] = new SqlParameter("@Surgery_id", SqlDbType.Int);
            param[2].Value = Surgery_id;

            param[3] = new SqlParameter("@Place", SqlDbType.Text);
            param[3].Value = Place;

            param[4] = new SqlParameter("@Type", SqlDbType.Text);
            param[4].Value = Type;

            param[5] = new SqlParameter("@L_or_R_Eye", SqlDbType.Char,1);
            param[5].Value = L_or_R_Eye;

            param[6] = new SqlParameter("@Admit_For", SqlDbType.Text);
            param[6].Value = Admit_For;

            param[7] = new SqlParameter("@Narcosis", SqlDbType.Text);
            param[7].Value = Narcosis;

            param[8] = new SqlParameter("@Treatment", SqlDbType.Text);
            param[8].Value = Treatment;

            param[9] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[9].Value = Patient_id;

            param[10] = new SqlParameter("@User_id", SqlDbType.Int);
            param[10].Value = User_id;
          
            param[11] = new SqlParameter("@Axial_Length", SqlDbType.Text);
            param[11].Value = Axial_Length;

            param[12] = new SqlParameter("@IoI_Power", SqlDbType.Text);
            param[12].Value = IoI_Power;

            param[13] = new SqlParameter("@Blood_Pressure", SqlDbType.Text);
            param[13].Value = Blood_Pressure;

            param[14] = new SqlParameter("@Blood_Sugar", SqlDbType.Text);
            param[14].Value = Blood_Sugar;

            param[15] = new SqlParameter("@Note1", SqlDbType.Text);
            param[15].Value = Assistant;

            param[16] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[16].Value = NoFile;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertSurgery", param);
            Dal.CheckIsClosed();
        }

        public void UpdateSurgery(string Name, int Surgery_id, int NoFile, string Date, string Place, string Type, char L_or_R_Eye, string Admit_For, string Narcosis, string Treatment, int Patient_id, int User_id, string Axial_Length, string IoI_Power, string Blood_Pressure, string Blood_Sugar, string Assistant)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[17];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Surgery_id", SqlDbType.Int);
            param[1].Value = Surgery_id;

            param[2] = new SqlParameter("@Place", SqlDbType.Text);
            param[2].Value = Place;

            param[3] = new SqlParameter("@Type", SqlDbType.Text);
            param[3].Value = Type;

            param[4] = new SqlParameter("@L_or_R_Eye", SqlDbType.Char, 1);
            param[4].Value = L_or_R_Eye;

            param[5] = new SqlParameter("@Admit_For", SqlDbType.Text);
            param[5].Value = Admit_For;

            param[6] = new SqlParameter("@Narcosis", SqlDbType.Text);
            param[6].Value = Narcosis;

            param[7] = new SqlParameter("@Treatment", SqlDbType.Text);
            param[7].Value = Treatment;

            param[8] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[8].Value = Patient_id;

            param[9] = new SqlParameter("@User_id", SqlDbType.Int);
            param[9].Value = User_id;

            param[10] = new SqlParameter("@Note1", SqlDbType.Text);
            param[10].Value = Assistant;

            param[11] = new SqlParameter("@Axial_Length", SqlDbType.Text);
            param[11].Value = Axial_Length;

            param[12] = new SqlParameter("@IoI_Power", SqlDbType.Text);
            param[12].Value = IoI_Power;

            param[13] = new SqlParameter("@Blood_Pressure", SqlDbType.Text);
            param[13].Value = Blood_Pressure;

            param[14] = new SqlParameter("@Blood_Sugar", SqlDbType.Text);
            param[14].Value = Blood_Sugar;

            param[15] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[15].Value = NoFile;

            param[16] = new SqlParameter("@Date", SqlDbType.NVarChar,30);
            param[16].Value = Date;


            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateSurgery", param);
            Dal.CheckIsClosed();
        }

        public DataTable SelectSurgery(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelecSurgery", param);
            Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectAllSurgery()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SelectAllSurgery");
            Dal.CheckIsClosed();

            return dt;
        }
    }
}
