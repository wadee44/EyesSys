using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Eye_Center.BL
{
    class Cls_Post_Operative_Follow_up
    {
        /*         @Post_Oper_FollowID int,
				   @Surgery_id int,
				   @Patient_id int,
				   @NoFile int,
				     */
        public void InsertPost_Operative_Follow_up(int Post_Oper_FollowID,int Surgery_id,int NoFile, string VA, string PH, string Date, string Astigmatism, string Corneal_Cause, string Corneal_Opacity, string C_Odema, string Retinal_Disease, string Glaucoma, string Others, int Patient_id, int User_id,string Note1 )
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[16];


            param[0] = new SqlParameter("@VA", SqlDbType.Text);
            param[0].Value = VA;

            param[1] = new SqlParameter("@Date", SqlDbType.NVarChar,30);
            param[1].Value = Date;

            param[2] = new SqlParameter("@PH", SqlDbType.Text);
            param[2].Value = PH;

            param[3] = new SqlParameter("@Astigmatism", SqlDbType.Text);
            param[3].Value = Astigmatism;

            param[4] = new SqlParameter("@Corneal_Cause", SqlDbType.Text);
            param[4].Value = Corneal_Cause;

            param[5] = new SqlParameter("@Corneal_Opacity", SqlDbType.Text);
            param[5].Value = Corneal_Opacity;

            param[6] = new SqlParameter("@C_Odema", SqlDbType.Text);
            param[6].Value = C_Odema;

            param[7] = new SqlParameter("@Retinal_Disease", SqlDbType.Text);
            param[7].Value = Retinal_Disease;

            param[8] = new SqlParameter("@Glaucoma", SqlDbType.Text);
            param[8].Value = Glaucoma;

            param[9] = new SqlParameter("@Others", SqlDbType.Text);
            param[9].Value = Others;

            param[10] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[10].Value = Patient_id;

            param[11] = new SqlParameter("@User_id", SqlDbType.Int);
            param[11].Value = User_id;

            param[12] = new SqlParameter("@Note1", SqlDbType.Text);
            param[12].Value = Note1;

            param[13] = new SqlParameter("@Post_Oper_FollowID", SqlDbType.Int);
            param[13].Value = Post_Oper_FollowID;

            param[14] = new SqlParameter("@Surgery_id", SqlDbType.Int);
            param[14].Value = Surgery_id;

            param[15] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[15].Value = NoFile;


            Dal.CheckIsOpen();
            Dal.ExecuteCommand("InsertPost_Operative_Follow_up", param);
            Dal.CheckIsClosed();
        }


        public void UpdatePost_Operative_Follow_up(int Post_Oper_FollowID, int Surgery_id, int NoFile, string VA, string PH, string Date, string Astigmatism, string Corneal_Cause, string Corneal_Opacity, string C_Odema, string Retinal_Disease, string Glaucoma, string Others, int Patient_id, int User_id, string Note1)
        {
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@VA", SqlDbType.Text);
            param[0].Value = VA;

            param[1] = new SqlParameter("@Date", SqlDbType.NVarChar,30);
            param[1].Value = Date;

            param[2] = new SqlParameter("@PH", SqlDbType.Text);
            param[2].Value = PH;

            param[3] = new SqlParameter("@Astigmatism", SqlDbType.Text);
            param[3].Value = Astigmatism;

            param[4] = new SqlParameter("@Corneal_Cause", SqlDbType.Text);
            param[4].Value = Corneal_Cause;

            param[5] = new SqlParameter("@Corneal_Opacity", SqlDbType.Text);
            param[5].Value = Corneal_Opacity;

            param[6] = new SqlParameter("@C_Odema", SqlDbType.Text);
            param[6].Value = C_Odema;

            param[7] = new SqlParameter("@Retinal_Disease", SqlDbType.Text);
            param[7].Value = Retinal_Disease;

            param[8] = new SqlParameter("@Glaucoma", SqlDbType.Text);
            param[8].Value = Glaucoma;

            param[9] = new SqlParameter("@Others", SqlDbType.Text);
            param[9].Value = Others;

            param[10] = new SqlParameter("@Patient_id", SqlDbType.Int);
            param[10].Value = Patient_id;

            param[11] = new SqlParameter("@User_id", SqlDbType.Int);
            param[11].Value = User_id;

            param[12] = new SqlParameter("@Note1", SqlDbType.Text);
            param[12].Value = Note1;

            param[13] = new SqlParameter("@Post_Oper_FollowID", SqlDbType.Int);
            param[13].Value = Post_Oper_FollowID;

            param[14] = new SqlParameter("@Surgery_id", SqlDbType.Int);
            param[14].Value = Surgery_id;

            param[15] = new SqlParameter("@NoFile", SqlDbType.Int);
            param[15].Value = NoFile;


            Dal.CheckIsOpen();
            Dal.ExecuteCommand("UpdatePost_Operative_Follow_up", param);
            Dal.CheckIsClosed();
        }


        public DataTable SelecPost_Operative_Follow_up(int id)
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dal.CheckIsOpen();
            dt = Dal.SelectData("SelecPost_Operative_Follow_up", param);
            Dal.CheckIsClosed();

            return dt;
        }

        public DataTable Select_All_Post_Operative_Follow_up()
        {
            DataTable dt = new DataTable();
            DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();
            Dal.CheckIsOpen();
            dt = Dal.SelectDataWithQuery("Select_All_Post_Operative_Follow_up");
            Dal.CheckIsClosed();

            return dt;
        }



    }
}
