using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Patient
    {
        /*
          ([Name]
           ,[Patient_id]
           ,[Date]
           ,[Address]
           ,[No_File]
           ,[Phone]
           ,[Age]
           ,[User_id]
           ,[Clinic_id]
           ,[Sex]
           ,[Note1]
           ,[Note2])
         */
        static public string name;
        static public int    patient_id;
        static public string address;
        static public int    no_file;
        static public string note1;
        static public string age;
        static public string sex;
        public void InsertPatient(string Name, int Patient_id, string Address, int No_File, string Phone, string Age, int User_id, int Clinic_id, string Sex, string Note1)
        {

            name = Name;
            patient_id = Patient_id;
            address = Address;
            no_file = No_File;
            note1 = Note1;
            age = Age;
            sex = Sex;

            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[1].Value = Patient_id;

            param[2] = new SqlParameter("@Address", SqlDbType.Text);
            param[2].Value = Address;

            param[3] = new SqlParameter("@No_File", SqlDbType.Int);
            param[3].Value = No_File;

            param[4] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
            param[4].Value = Phone;

            param[5] = new SqlParameter("@Age", SqlDbType.NVarChar, 50);
            param[5].Value = Age;

            param[6] = new SqlParameter("@User_id", SqlDbType.Int);
            param[6].Value = User_id;

            param[7] = new SqlParameter("@Clinic_id", SqlDbType.Int);
            param[7].Value = Clinic_id;

            param[8] = new SqlParameter("@Sex", SqlDbType.NChar, 10);
            param[8].Value = Sex;

            param[9] = new SqlParameter("@Note1", SqlDbType.Text);
            param[9].Value = Note1;

            Dal.ExecuteCommand("InsertPatient", param);
        }

        public void InsertPatientAfter(string Name, int Patient_id,string Date, string Address, int No_File, string Phone, string Age, int User_id, int Clinic_id, string Sex, string Note1)
        {

            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[1].Value = Patient_id;

            param[2] = new SqlParameter("@Address", SqlDbType.Text);
            param[2].Value = Address;

            param[3] = new SqlParameter("@No_File", SqlDbType.Int);
            param[3].Value = No_File;

            param[4] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
            param[4].Value = Phone;

            param[5] = new SqlParameter("@Age", SqlDbType.NVarChar, 50);
            param[5].Value = Age;

            param[6] = new SqlParameter("@User_id", SqlDbType.Int);
            param[6].Value = User_id;

            param[7] = new SqlParameter("@Clinic_id", SqlDbType.Int);
            param[7].Value = Clinic_id;

            param[8] = new SqlParameter("@Sex", SqlDbType.NChar, 10);
            param[8].Value = Sex;

            param[9] = new SqlParameter("@Note1", SqlDbType.Text);
            param[9].Value = Note1;

            param[10] = new SqlParameter("@Date", SqlDbType.NVarChar, 50);
            param[10].Value = Date;

            Dal.ExecuteCommand("InsertPatientAfter", param);
        }

        public void UpdatePatient(string Name, int Patient_id, string Address, int No_File, string Phone, string Age, int User_id, int Clinic_id, string Sex, string Note1, string Note2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[1].Value = Patient_id;

            param[2] = new SqlParameter("@Address", SqlDbType.Text);
            param[2].Value = Address;

            param[3] = new SqlParameter("@No_File", SqlDbType.Int);
            param[3].Value = No_File;

            param[4] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
            param[4].Value = Phone;

            param[5] = new SqlParameter("@Age", SqlDbType.NVarChar, 50);
            param[5].Value = Age;

            param[6] = new SqlParameter("@User_id", SqlDbType.Int);
            param[6].Value = User_id;

            param[7] = new SqlParameter("@Clinic_id", SqlDbType.Int);
            param[7].Value = Clinic_id;

            param[8] = new SqlParameter("@Sex", SqlDbType.NChar, 10);
            param[8].Value = Sex;

            param[9] = new SqlParameter("@Note1", SqlDbType.Text);
            param[9].Value = Note1;

            param[10] = new SqlParameter("@Note2", SqlDbType.Text);
            param[10].Value = Note2;

            Dal.ExecuteCommand("UpdatePatient", param);
        }

        public DataTable SelectAllPatient()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            dt = Dal.SelectDataWithQuery("SelectAllPatient");

            return dt;
        }

        public DataTable NameSurgery()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            dt = Dal.SelectDataWithQuery("NameSurgery");

            return dt;
        }

        public DataTable NameSurgreyLocal()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            dt = Dal.SelectDataWithQuery("NameSurgreyLocal");

            return dt;
        }

        public DataTable NameSurgreyGeneral()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            dt = Dal.SelectDataWithQuery("NameSurgreyGeneral");

            return dt;
        }

        public DataTable SelectpatientInNum(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = Dal.SelectData("SelectpatientInNum", param);

            return dt;
        }

        public bool Checking_Repeat_NoFile(int chack)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@nofile",SqlDbType.Int);
            param[0].Value = chack;

            dt = Dal.SelectData("Checking_Repeat_NoFile", param);

            if (dt.Rows.Count > 0)
                return true;

            return false;
        }


        public bool Checking_Repeat_ClincID(int chack)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ClincID", SqlDbType.Int);
            param[0].Value = chack;

            dt = Dal.SelectData("Checking_Repeat_ClincID", param);

            if (dt.Rows.Count > 0)
                return true;

            return false;
        }

        public DataTable SelectNamepatient(string data)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@data", SqlDbType.NVarChar, 100);
            param[0].Value = data;

            DataTable dt = new DataTable();
            dt = Dal.SelectData("SelectNamepatient", param);

            return dt;
        }


    }
}

