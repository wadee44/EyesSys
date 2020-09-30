using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Git_Max_id_For_Tables
    {
        DataTable dt = new DataTable();
        public int Git_Max_id()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
           

            int id;
            Dal.CheckIsOpen();
            dt =  Dal.SelectDataWithQuery("Git_Max_id");
            Dal.CheckIsClosed();
            id = Convert.ToInt32( dt.Rows[0][0]);
            return id;
        }
        public int Git_Max_no()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Git_Max_no");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int Git_Max_id_For_RoutineCheck()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Git_Max_id_For_RoutineCheck");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int Git_Max_id_Clinc()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Git_Max_id_Clinc");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int Git_Max_id_For_Biometry()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Git_Max_id_For_Biometry");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int Git_Max_id_For_Checked_Patient()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Git_Max_id_For_Checked_Patient");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int Get_max_id_Surgery()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Get_max_id_Surgery");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int Git_Max_id_For_Follow_up()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Git_Max_id_For_Follow_up");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int Git_Max_id_For_Post_Operative_Follow_up()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Git_Max_id_For_Post_Operative_Follow_up");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int Git_Max_id_For_Users()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Git_Max_id_For_Users");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int Git_Max_Bond_Book_id()
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


            int id;
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Git_Max_Bond_Book_id");
            Dal.CheckIsClosed();
            id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }
    }
}
