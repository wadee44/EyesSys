using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_SurgeryPrices
    {
        DataTable dt = new DataTable();

        public void insert_SurgeryPrices(int SurgeryPrice_id, string SurgeryPrice_code, int SurgeryPrice, string SurgeryPrice_name, string SurgeryPrice_note)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("@SurgeryPrice_id", SqlDbType.Int);
            pr[0].Value = SurgeryPrice_id;
            pr[1] = new SqlParameter("@SurgeryPrice_code", SqlDbType.VarChar);
            pr[1].Value = SurgeryPrice_code;
            pr[2] = new SqlParameter("@SurgeryPrice", SqlDbType.Int);
            pr[2].Value = SurgeryPrice;
            pr[3] = new SqlParameter("@SurgeryPrice_name", SqlDbType.VarChar);
            pr[3].Value = SurgeryPrice_name;
            pr[4] = new SqlParameter("@SurgeryPrice_note", SqlDbType.VarChar);
            pr[4].Value = SurgeryPrice_note;
            Dal.ExecuteCommand("insert_SurgeryPrices", pr);
        }
        public DataTable select_all_SurgeryPrices()
        {

            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
         // dt = Dal.SelectDataWithQuery("SelectAllBondBookType");
            dt = Dal.SelectDataWithQuery("select_all_SurgeryPrices");
            return dt;
        }
        public void update_SurgeryPrices(int SurgeryPrice_id, string SurgeryPrice_code, int SurgeryPrice, string SurgeryPrice_name, string SurgeryPrice_note)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] pr = new SqlParameter[5];
            pr[0] = new SqlParameter("@SurgeryPrice_id", SqlDbType.Int);
            pr[0].Value = SurgeryPrice_id;
            pr[1] = new SqlParameter("@SurgeryPrice_code", SqlDbType.VarChar);
            pr[1].Value = SurgeryPrice_code;
            pr[2] = new SqlParameter("@SurgeryPrice", SqlDbType.Int);
            pr[2].Value = SurgeryPrice;
            pr[3] = new SqlParameter("@SurgeryPrice_name", SqlDbType.VarChar);
            pr[3].Value = SurgeryPrice_name;
            pr[4] = new SqlParameter("@SurgeryPrice_note", SqlDbType.VarChar);
            pr[4].Value = SurgeryPrice_note;
            Dal.ExecuteCommand("update_SurgeryPrices", pr);
        }
        public DataTable git_max_SurgeryPrices()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            DataTable dt = new DataTable();
            dt = Dal.SelectDataWithQuery("git_max_SurgeryPrices");
            return dt;
        }
        public void delete_SurgeryPrices(int SurgeryPrice_id)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@SurgeryPrice_id", SqlDbType.Int);
            pr[0].Value = SurgeryPrice_id;
            Dal.ExecuteCommand("delete_SurgeryPrices", pr);
        }
        public DataTable search_SurgeryPrices(int SurgeryPrice_id)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@SurgeryPrice_id", SqlDbType.Int);
            pr[0].Value = SurgeryPrice_id;
            Dal.ExecuteCommand("search_SurgeryPrices", pr);
            return dt;
        }
    }
}
