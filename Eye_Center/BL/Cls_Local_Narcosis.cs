using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Local_Narcosis
    {
        /*
         *      @ text,
				@ text,
				@ int,
				@ text,
				@Note2 text
         */
        public void InsertLocal_Narcosis(int NoFile,string BP, string Viral_Marks_and_HIV, string CBC, string BS, int Surgery_id, string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@BP", SqlDbType.Text);
            param[0].Value = BP;

            param[1] = new SqlParameter("@Viral_Marks_and_HIV", SqlDbType.Text);
            param[1].Value = Viral_Marks_and_HIV;

            param[2] = new SqlParameter("@Surgery_id", SqlDbType.Int);
            param[2].Value = Surgery_id;

            param[3] = new SqlParameter("@Note1", SqlDbType.Text);
            param[3].Value = Note1;

            param[4] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[4].Value = NoFile;

            param[5] = new SqlParameter("@CBC", SqlDbType.Text);
            param[5].Value = CBC;

            param[6] = new SqlParameter("@BS", SqlDbType.Text);
            param[6].Value = BS;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertLocal_Narcosis", param);
            Dal.CheckIsClosed();

        }

        public void UpdateLocal_Narcosis(int NoFile,string BP, string Viral_Marks_and_HIV, string CBC, string BS, int Surgery_id, string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@BP", SqlDbType.Text);
            param[0].Value = BP;

            param[1] = new SqlParameter("@Viral_Marks_and_HIV", SqlDbType.Text);
            param[1].Value = Viral_Marks_and_HIV;

            param[2] = new SqlParameter("@Surgery_id", SqlDbType.Int);
            param[2].Value = Surgery_id;

            param[3] = new SqlParameter("@Note1", SqlDbType.Text);
            param[3].Value = Note1;

            param[4] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[4].Value = NoFile;

            param[5] = new SqlParameter("@CBC", SqlDbType.Text);
            param[5].Value = CBC;

            param[6] = new SqlParameter("@BS", SqlDbType.Text);
            param[6].Value = BS;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateLocal_Narcosis", param);
            Dal.CheckIsClosed();

        }

        public DataTable SelecLocal_Narcosis(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelecLocal_Narcosis", param);
            Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SeletAllcLocal_Narcosis()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SeletAllcLocal_Narcosis");
            Dal.CheckIsClosed();

            return dt;
        }

    }
}
