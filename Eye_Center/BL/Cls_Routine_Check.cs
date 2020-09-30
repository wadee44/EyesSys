using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Routine_Check
    {

        public void InsertRoutine_Check(int RoutineCheckID, string OD_or_OS, string VA, string With_Glasses, string PH, string IOP, int User_id, int Patient_id, string Shp, string Cyl, string Axis, string ShpAuto, string CylAuto, string AxisAuto, string D_or_N, string Note1, int NoFile)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[17];

            param[0] = new SqlParameter("@OD_or_OS", SqlDbType.Text);
            param[0].Value = OD_or_OS;

            param[1] = new SqlParameter("@VA", SqlDbType.Text);
            param[1].Value = VA;

            param[2] = new SqlParameter("@PH", SqlDbType.Text);
            param[2].Value = PH;

            param[3] = new SqlParameter("@With_Glasses", SqlDbType.Text);
            param[3].Value = With_Glasses;

            param[4] = new SqlParameter("@IOP", SqlDbType.Text);
            param[4].Value = IOP;

            param[5] = new SqlParameter("@User_id", SqlDbType.Int);
            param[5].Value = User_id;

            param[6] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[6].Value = Patient_id;

            param[7] = new SqlParameter("@Shp", SqlDbType.Text);
            param[7].Value = Shp;

            param[8] = new SqlParameter("@Cyl", SqlDbType.Text);
            param[8].Value = Cyl;

            param[9] = new SqlParameter("@Axis", SqlDbType.Text);
            param[9].Value = Axis;

            param[10] = new SqlParameter("@D_or_N", SqlDbType.Text);
            param[10].Value = D_or_N;

            param[11] = new SqlParameter("@Note1", SqlDbType.Text);
            param[11].Value = Note1;

            param[12] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[12].Value = NoFile;

            param[13] = new SqlParameter("@RoutineCheckID", SqlDbType.Int);
            param[13].Value = RoutineCheckID;

            param[14] = new SqlParameter("@AxisAuto", SqlDbType.Text);
            param[14].Value = AxisAuto;

            param[15] = new SqlParameter("@CylAuto", SqlDbType.Text);
            param[15].Value = CylAuto;

            param[16] = new SqlParameter("@ShpAuto", SqlDbType.Text);
            param[16].Value = ShpAuto;


            Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertRoutine_Check", param);
            Dal.CheckIsClosed();
        }

        public void UpdateRoutine_Check(int RoutineCheckID, string OD_or_OS, string VA, string With_Glasses, string PH, string IOP, int User_id, int Patient_id, string Shp, string Cyl, string Axis, string ShpAuto, string CylAuto, string AxisAuto, string D_or_N, string Note1,  int NoFile)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[17];

            param[0] = new SqlParameter("@OD_or_OS", SqlDbType.Text);
            param[0].Value = OD_or_OS;

            param[1] = new SqlParameter("@VA", SqlDbType.Text);
            param[1].Value = VA;

            param[2] = new SqlParameter("@PH", SqlDbType.Text);
            param[2].Value = PH;

            param[3] = new SqlParameter("@With_Glasses", SqlDbType.Text);
            param[3].Value = With_Glasses;

            param[4] = new SqlParameter("@IOP", SqlDbType.Text);
            param[4].Value = IOP;

            param[5] = new SqlParameter("@User_id", SqlDbType.Int);
            param[5].Value = User_id;

            param[6] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[6].Value = Patient_id;

            param[7] = new SqlParameter("@Shp", SqlDbType.Text);
            param[7].Value = Shp;

            param[8] = new SqlParameter("@Cyl", SqlDbType.Text);
            param[8].Value = Cyl;

            param[9] = new SqlParameter("@Axis", SqlDbType.Text);
            param[9].Value = Axis;

            param[10] = new SqlParameter("@D_or_N", SqlDbType.Text);
            param[10].Value = D_or_N;

            param[11] = new SqlParameter("@Note1", SqlDbType.Text);
            param[11].Value = Note1;

            param[12] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[12].Value = NoFile;

            param[13] = new SqlParameter("@RoutineCheckID", SqlDbType.Int);
            param[13].Value = RoutineCheckID;

            param[14] = new SqlParameter("@AxisAuto", SqlDbType.Text);
            param[14].Value = AxisAuto;

            param[15] = new SqlParameter("@CylAuto", SqlDbType.Text);
            param[15].Value = CylAuto;

            param[16] = new SqlParameter("@ShpAuto", SqlDbType.Text);
            param[16].Value = ShpAuto;


            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdateRoutine_Check", param);
            Dal.CheckIsClosed();
        }
        
        public DataTable SelecRoutine_Check(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelecRoutine_Check", param);
            Dal.CheckIsClosed();

            return dt;
        }

        public DataTable SelectAllRoutine_Check()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("SelectAllRoutine_Check");
            Dal.CheckIsClosed();

            return dt;
        }


    }
}
