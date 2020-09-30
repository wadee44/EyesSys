using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Clinic
    {

        public void Insert_Clinic(string Name ,int Clinic_id,string Shift,int User_id,string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Name", SqlDbType.NChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Clinic_id",SqlDbType.Int);
            param[1].Value = Clinic_id;

            param[2] = new SqlParameter("@Shift",SqlDbType.NChar,20);
            param[2].Value = Shift;

            param[3] = new SqlParameter("@User_id", SqlDbType.Int);
            param[3].Value = User_id;

            param[4] = new SqlParameter("@Note1", SqlDbType.Text);
            param[4].Value = Note1;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("Insert_Clinic", param);
            Dal.CheckIsClosed();
        }

        public void UpdateClinic(string Name, int Clinic_id, string Shift, int User_id, string Note1, string Note2)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Name", SqlDbType.NChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Clinic_id", SqlDbType.Int);
            param[1].Value = Clinic_id;

            param[2] = new SqlParameter("@Shift", SqlDbType.NChar, 20);
            param[2].Value = Shift;

            param[3] = new SqlParameter("@User_id", SqlDbType.Int);
            param[3].Value = User_id;

            param[4] = new SqlParameter("@Note1", SqlDbType.Text);
            param[4].Value = Note1;

            param[5] = new SqlParameter("@Note2", SqlDbType.Text);
            param[5].Value = Note2;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateClinic", param);
            Dal.CheckIsClosed();
        }
    }
}
