using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PRODUCT_MANGMENT.BL
{
    class CLS_ORDER
    {
        public DataTable GET_LAST_ORDER_ID()
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            dt = DAL.select_data("GET_LAST_ORDER_ID", null);
            DAL.close();
            return (dt);
        }
        public void ADD_ORDER(int id_order, DateTime date_order, int id_customer,
                        string des_order, string selman)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_order", SqlDbType.Int);
            param[0].Value = id_order;

            param[1] = new SqlParameter("@date_order", SqlDbType.Date);
            param[1].Value = date_order;

            param[2] = new SqlParameter("@id_customer", SqlDbType.Int);
            param[2].Value = id_customer;

            param[3] = new SqlParameter("@des_order", SqlDbType.VarChar, 50);
            param[3].Value = des_order;

            param[4] = new SqlParameter("@selman", SqlDbType.VarChar, 50);
            param[4].Value = selman;

            DAL.execute_command("ADD_ORDER", param);
            DAL.close();
        }



        public void ADD_ORDER_DELAILS(string id_product, int id_order, int qte,
                string price, float descount,string amount,string total_amount)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@id_order", SqlDbType.Int);
            param[1].Value = id_order;

            param[2] = new SqlParameter("@qte", SqlDbType.Int);
            param[2].Value = qte;

            param[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[3].Value = price;

            param[4] = new SqlParameter("@descount", SqlDbType.Float);
            param[4].Value = descount;

            param[5] = new SqlParameter("@amount", SqlDbType.VarChar, 50);
            param[5].Value = amount;

            param[6] = new SqlParameter("@total_amount", SqlDbType.VarChar, 50);
            param[6].Value = total_amount;

            DAL.execute_command("ADD_ORDER_DELAILS", param);
            DAL.close();
        }
        public DataTable VERFAIY_QTE(string id_product, int qte_entered)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[0].Value = id_product;

            param[1] = new SqlParameter("@qte_entered", SqlDbType.Int);
            param[1].Value = qte_entered;

            dt = DAL.select_data("VERFAIY_QTE", param);
            DAL.close();
            return (dt);
        }
        public DataTable SEARCH_ORDER(string id)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;

            dt = DAL.select_data("SEARCH_ORDER", param);
            DAL.close();
            return (dt);
        }


    }
}
