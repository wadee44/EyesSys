using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{

    class Cls_Global_Narcosis
    {
        public void InsertGlobal_Narcosis(int NoFile,string Urea_and_creation ,string BT_and_CT ,string Liver_functor_test ,string ECG ,string C_X_ray ,string Medical ,string ENT_Dr ,string pediatric,string CBC,string BS ,int Surgery_id ,string Note1 )
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@Urea_and_creation", SqlDbType.Text);
            param[0].Value = Urea_and_creation;

            param[1] = new SqlParameter("@BT_and_CT", SqlDbType.Text);
            param[1].Value = BT_and_CT;

            param[2] = new SqlParameter("@Liver_functor_test", SqlDbType.Text);
            param[2].Value = Liver_functor_test;

            param[3] = new SqlParameter("@ECG", SqlDbType.Text);
            param[3].Value = ECG;

            param[4] = new SqlParameter("@C_X_ray", SqlDbType.Text);
            param[4].Value = C_X_ray;

            param[5] = new SqlParameter("@Medical", SqlDbType.Text);
            param[5].Value = Medical;

            param[6] = new SqlParameter("@ENT_Dr", SqlDbType.Text);
            param[6].Value = ENT_Dr;

            param[7] = new SqlParameter("@pediatric", SqlDbType.Text);
            param[7].Value = pediatric;

            param[8] = new SqlParameter("@Surgery_id", SqlDbType.Int);
            param[8].Value = Surgery_id;

            param[9] = new SqlParameter("@Note1", SqlDbType.Text);
            param[9].Value = Note1;

            param[10] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[10].Value = NoFile;

            param[11] = new SqlParameter("@CBC", SqlDbType.Text);
            param[11].Value = CBC;

            param[12] = new SqlParameter("@BS", SqlDbType.Text);
            param[12].Value = BS;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertGlobal_Narcosis", param);
            Dal.CheckIsClosed();
        }

        public void UpdateGlobal_Narcosis(int NoFile, string Urea_and_creation, string BT_and_CT, string Liver_functor_test, string ECG, string C_X_ray, string Medical, string ENT_Dr, string pediatric, string CBC, string BS, int Surgery_id, string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@Urea_and_creation", SqlDbType.Text);
            param[0].Value = Urea_and_creation;

            param[1] = new SqlParameter("@BT_and_CT", SqlDbType.Text);
            param[1].Value = BT_and_CT;

            param[2] = new SqlParameter("@Liver_functor_test", SqlDbType.Text);
            param[2].Value = Liver_functor_test;

            param[3] = new SqlParameter("@ECG", SqlDbType.Text);
            param[3].Value = ECG;

            param[4] = new SqlParameter("@C_X_ray", SqlDbType.Text);
            param[4].Value = C_X_ray;

            param[5] = new SqlParameter("@Medical", SqlDbType.Text);
            param[5].Value = Medical;

            param[6] = new SqlParameter("@ENT_Dr", SqlDbType.Text);
            param[6].Value = ENT_Dr;

            param[7] = new SqlParameter("@pediatric", SqlDbType.Text);
            param[7].Value = pediatric;

            param[8] = new SqlParameter("@Surgery_id", SqlDbType.Int);
            param[8].Value = Surgery_id;

            param[9] = new SqlParameter("@Note1", SqlDbType.Text);
            param[9].Value = Note1;

            param[10] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[10].Value = NoFile;

            param[11] = new SqlParameter("@CBC", SqlDbType.Text);
            param[11].Value = CBC;

            param[12] = new SqlParameter("@BS", SqlDbType.Text);
            param[12].Value = BS;

            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateGlobal_Narcosis", param);
            Dal.CheckIsClosed();
        }

        public DataTable SelecGlobal_Narcosis(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelecGlobal_Narcosis", param);
            Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectAllGlobal_Narcosis()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SelectAllGlobal_Narcosis");
            Dal.CheckIsClosed();

            return dt;
        }

    }
}
