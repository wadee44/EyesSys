using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Users
    {
        public void InsertUsers(string Name, int User_id, string NameSystem, string Shift, string Pass, string Number_Type_Of_Job, string Phone, string Email, string Sex, string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[0].Value = Name;

            param[1] = new SqlParameter("@User_id", SqlDbType.Int);
            param[1].Value = User_id;

            param[2] = new SqlParameter("@Shift", SqlDbType.NVarChar, 20);
            param[2].Value = Shift;

            param[3] = new SqlParameter("@Pass", SqlDbType.NVarChar, 100);
            param[3].Value = Pass;

            param[4] = new SqlParameter("@Number_Type_Of_Job", SqlDbType.NVarChar, 5);
            param[4].Value = Number_Type_Of_Job;

            param[5] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
            param[5].Value = Phone;

            param[6] = new SqlParameter("@Email", SqlDbType.Text);
            param[6].Value = Email;

            param[7] = new SqlParameter("@Sex", SqlDbType.NVarChar, 10);
            param[7].Value = Sex;

            param[8] = new SqlParameter("@Note1", SqlDbType.Text);
            param[8].Value = Note1;

            param[9] = new SqlParameter("@NameSystem", SqlDbType.Text);
            param[9].Value = NameSystem;


            Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertUsers", param);
            Dal.CheckIsClosed();
        }

        public void UpdateUsers(string Name, int User_id, string NameSystem, string Shift,  string Number_Type_Of_Job, string Phone, string Email, string Sex, string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 100);
            param[0].Value = Name;

            param[1] = new SqlParameter("@User_id", SqlDbType.Int);
            param[1].Value = User_id;

            param[2] = new SqlParameter("@Shift", SqlDbType.NVarChar, 20);
            param[2].Value = Shift;

            param[3] = new SqlParameter("@Number_Type_Of_Job", SqlDbType.NVarChar, 5);
            param[3].Value = Number_Type_Of_Job;

            param[4] = new SqlParameter("@Phone", SqlDbType.NVarChar, 50);
            param[4].Value = Phone;

            param[5] = new SqlParameter("@Email", SqlDbType.Text);
            param[5].Value = Email;

            param[6] = new SqlParameter("@Sex", SqlDbType.NVarChar, 10);
            param[6].Value = Sex;

            param[7] = new SqlParameter("@Note1", SqlDbType.Text);
            param[7].Value = Note1;

            param[8] = new SqlParameter("@NameSystem", SqlDbType.Text);
            param[8].Value = NameSystem;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateUsers", param);
            Dal.CheckIsClosed();
        }

        public DataTable SelecUsers(string data)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@data", SqlDbType.NVarChar,50);
            param[0].Value = data;

            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelecUsers", param);
            Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectAllUsers()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SelectAllUsers");
            Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectPriv(int idList, int userid)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer( );
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@idList", SqlDbType.Int);
            param[0].Value = idList;

            param[1] = new SqlParameter("@userid", SqlDbType.Int);
            param[1].Value = userid;
            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelectPriv",param);
            Dal.CheckIsClosed();

            return dt;
        }

        
        public DataTable ChengPassUsers(string name, string oldpass, string newpass)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@username", SqlDbType.NVarChar, 100);
            param[0].Value = name;

            param[1] = new SqlParameter("@OldPass", SqlDbType.NVarChar, 100);
            param[1].Value = oldpass;

            param[2] = new SqlParameter("@NewPass", SqlDbType.NVarChar, 100);
            param[2].Value = newpass;

            
            dt = Dal.SelectData("ChengPassUsers", param);
            

            return dt;
        }

    }
}
