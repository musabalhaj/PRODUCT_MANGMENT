using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PRODUCT_MANGMENT.BL
{
    class CLS_CUSTOMER
    {
        //اضافة عميل جديد
        public void ADD_CUSTOMER(int id_customer, string first_name, string last_name,
                                string phone, string email, byte[] image_customer)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_customer", SqlDbType.Int);
            param[0].Value = id_customer;

            param[1] = new SqlParameter("@first_name", SqlDbType.VarChar, 50);
            param[1].Value = first_name;

            param[2] = new SqlParameter("@last_name", SqlDbType.VarChar, 50);
            param[2].Value = last_name;

            param[3] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[3].Value = phone;

            param[4] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[4].Value = email;

            param[5] = new SqlParameter("@image_customer", SqlDbType.Image);
            param[5].Value = image_customer;
            DAL.execute_command("ADD_CUSTOMER", param);
            DAL.close();
        }

        //لتعبئة الداتا غريد فيو
        public DataTable GET_ALL_CUSTOMER()
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            dt = DAL.select_data("GET_ALL_CUSTOMER", null);
            DAL.close();
            return (dt);
        }
        public void UPDATE_CUSTOMER(int id_customer, string first_name, string last_name,
                                string phone, string email, byte[] image_customer)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_customer", SqlDbType.Int);
            param[0].Value = id_customer;

            param[1] = new SqlParameter("@first_name", SqlDbType.VarChar, 50);
            param[1].Value = first_name;

            param[2] = new SqlParameter("@last_name", SqlDbType.VarChar, 50);
            param[2].Value = last_name;

            param[3] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[3].Value = phone;

            param[4] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[4].Value = email;

            param[5] = new SqlParameter("@image_customer", SqlDbType.Image);
            param[5].Value = image_customer;
            DAL.execute_command("UPDATE_CUSTOMER", param);
            DAL.close();
        }
                public void DELETE_CUSTOMER(int id_customer)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_customer", SqlDbType.Int);
            param[0].Value = id_customer;
            DAL.execute_command("DELETE_CUSTOMER", param);
            DAL.close();
        }
                public DataTable SEARCH_CUSTOMER(string id)
                {
                    DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
                    DataTable dt = new DataTable();
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
                    param[0].Value = id;
                    dt = DAL.select_data("SEARCH_CUSTOMER", param);
                    DAL.close();
                    return (dt);
                }


    }
}
