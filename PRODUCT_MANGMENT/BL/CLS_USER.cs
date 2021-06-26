using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PRODUCT_MANGMENT.BL
{
    class CLS_USER
    {
        public void ADD_USER(string id, string pwd, string full_name,
                     string user_type)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@full_name", SqlDbType.VarChar, 50);
            param[2].Value = full_name;

            param[3] = new SqlParameter("@user_type", SqlDbType.VarChar, 50);
            param[3].Value = user_type;

            DAL.execute_command("ADD_USER", param);
            DAL.close();
        }
        public DataTable GET_ALL_USER()
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            dt = DAL.select_data("GET_ALL_USER", null);
            DAL.close();
            return (dt);
        }
        public DataTable SEARCH_USER(string searsh)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@searsh", SqlDbType.VarChar, 50);
            param[0].Value = searsh;
            dt = DAL.select_data("SEARCH_USER", param);
            DAL.close();
            return (dt);
        }
        public void DELETE_USER(string id)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            DAL.execute_command("DELETE_USER", param);
            DAL.close();
        }
        public void UPDATE_USER(string id, string pwd, string full_name,string user_type)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@full_name", SqlDbType.VarChar, 50);
            param[2].Value = full_name;

            param[3] = new SqlParameter("@user_type", SqlDbType.VarChar, 50);
            param[3].Value = user_type;

            DAL.execute_command("UPDATE_USER", param);
            DAL.close();
        }
    }
}
