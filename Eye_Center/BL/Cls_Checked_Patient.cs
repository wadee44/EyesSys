using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Checked_Patient
    {

        public void InsertChecked_Patient(int Checked_PatientID,int NoFile,string Present_Complaint, string Previous_Ocular_History, string Using_any_Medicine, string Any_Sensitivity, string Ocular_motility, string Slit_lamp_Examination, string Eyelids, string Cornea, string AC, string Lens, string Vitreous, string Fundus, string Gonioscopy, string UltraSound, string Treatment, char L_or_R_Eye, int Patient_id, int User_id, string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[21];

            param[0] = new SqlParameter("@Present_Complaint", SqlDbType.Text);
            param[0].Value = Present_Complaint;

            param[1] = new SqlParameter("@Previous_Ocular_History", SqlDbType.Text);
            param[1].Value = Previous_Ocular_History;

            param[2] = new SqlParameter("@Using_any_Medicine", SqlDbType.Text);
            param[2].Value = Using_any_Medicine;

            param[3] = new SqlParameter("@Any_Sensitivity", SqlDbType.Text);
            param[3].Value = Any_Sensitivity;

            param[4] = new SqlParameter("@Ocular_motility", SqlDbType.Text);
            param[4].Value = Ocular_motility;

            param[5] = new SqlParameter("@Slit_lamp_Examination", SqlDbType.Text);
            param[5].Value = Slit_lamp_Examination;

            param[6] = new SqlParameter("@Eyelids", SqlDbType.Text);
            param[6].Value = Eyelids;

            param[7] = new SqlParameter("@Cornea", SqlDbType.Text);
            param[7].Value = Cornea;

            param[8] = new SqlParameter("@AC", SqlDbType.Text);
            param[8].Value = AC;

            param[9] = new SqlParameter("@Lens", SqlDbType.Text);
            param[9].Value = Lens;

            param[10] = new SqlParameter("@Vitreous", SqlDbType.Text);
            param[10].Value = Vitreous;

            param[11] = new SqlParameter("@Fundus", SqlDbType.Text);
            param[11].Value = Fundus;

            param[12] = new SqlParameter("@Gonioscopy", SqlDbType.Text);
            param[12].Value = Gonioscopy;

            param[13] = new SqlParameter("@UltraSound", SqlDbType.Text);
            param[13].Value = UltraSound;

            param[14] = new SqlParameter("@Treatment", SqlDbType.Text);
            param[14].Value = Treatment;

            param[15] = new SqlParameter("@L_or_R_Eye", SqlDbType.Char,1);
            param[15].Value = L_or_R_Eye;

            param[16] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[16].Value = Patient_id;
            
            param[17] = new SqlParameter("@User_id", SqlDbType.Int);
            param[17].Value = User_id;

            param[18] = new SqlParameter("@Note1", SqlDbType.Text);
            param[18].Value = Note1;

            param[19] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[19].Value = NoFile;

            param[20] = new SqlParameter("@Checked_PatientID", SqlDbType.Int);
            param[20].Value = Checked_PatientID;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertChecked_Patient", param);
            Dal.CheckIsClosed();
           
        }

        public void UpdateChecked_Patient(int Checked_PatientID, int NoFile, string Present_Complaint, string Previous_Ocular_History, string Using_any_Medicine, string Any_Sensitivity, string Ocular_motility, string Slit_lamp_Examination, string Eyelids, string Cornea, string AC, string Lens, string Vitreous, string Fundus, string Gonioscopy, string UltraSound, string Treatment, char L_or_R_Eye, int Patient_id, int User_id, string Note1, string Note2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[22];

            param[0] = new SqlParameter("@Present_Complaint", SqlDbType.Text);
            param[0].Value = Present_Complaint;

            param[1] = new SqlParameter("@Previous_Ocular_History", SqlDbType.Text);
            param[1].Value = Previous_Ocular_History;

            param[2] = new SqlParameter("@Using_any_Medicine", SqlDbType.Text);
            param[2].Value = Using_any_Medicine;

            param[3] = new SqlParameter("@Any_Sensitivity", SqlDbType.Text);
            param[3].Value = Any_Sensitivity;

            param[4] = new SqlParameter("@Ocular_motility", SqlDbType.Text);
            param[4].Value = Ocular_motility;

            param[5] = new SqlParameter("@Slit_lamp_Examination", SqlDbType.Text);
            param[5].Value = Slit_lamp_Examination;

            param[6] = new SqlParameter("@Eyelids", SqlDbType.Text);
            param[6].Value = Eyelids;

            param[7] = new SqlParameter("@Cornea", SqlDbType.Text);
            param[7].Value = Cornea;

            param[8] = new SqlParameter("@AC", SqlDbType.Text);
            param[8].Value = AC;

            param[9] = new SqlParameter("@Lens", SqlDbType.Text);
            param[9].Value = Lens;

            param[10] = new SqlParameter("@Vitreous", SqlDbType.Text);
            param[10].Value = Vitreous;

            param[11] = new SqlParameter("@Fundus", SqlDbType.Text);
            param[11].Value = Fundus;

            param[12] = new SqlParameter("@Gonioscopy", SqlDbType.Text);
            param[12].Value = Gonioscopy;

            param[13] = new SqlParameter("@UltraSound", SqlDbType.Text);
            param[13].Value = UltraSound;

            param[14] = new SqlParameter("@Treatment", SqlDbType.Text);
            param[14].Value = Treatment;

            param[15] = new SqlParameter("@L_or_R_Eye", SqlDbType.Char, 1);
            param[15].Value = L_or_R_Eye;

            param[16] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[16].Value = Patient_id;

            param[17] = new SqlParameter("@User_id", SqlDbType.Int);
            param[17].Value = User_id;

            param[18] = new SqlParameter("@Note1", SqlDbType.Text);
            param[18].Value = Note1;

            param[19] = new SqlParameter("@Note2", SqlDbType.Text);
            param[19].Value = Note2;

            param[20] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[20].Value = NoFile;

            param[21] = new SqlParameter("@Checked_PatientID", SqlDbType.Int);
            param[21].Value = Checked_PatientID;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateChecked_Patient", param);
            Dal.CheckIsClosed();

        }

        public DataTable SelectChecked_Patient(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelecChecked_Patient", param);
            Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectAllChecked_Patient()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SelectAllChecked_Patient");
            Dal.CheckIsClosed();

            return dt;
        }

    }
}
