using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class SearchPatient
    {
        public DataTable SearchPatients(string data)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@data", SqlDbType.NVarChar, 50);
            param[0].Value = data;

            DataTable dt = new DataTable();
            Dal.CheckIsOpen();
           dt = Dal.SelectData("SearchPatient", param);
            Dal.CheckIsClosed();

            return dt;
        }
    }
}
