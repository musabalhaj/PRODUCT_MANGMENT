using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PRODUCT_MANGMENT.BL
{
    class CLS_PRODUCT
    {
        //لتعبئة الكومبوبوكس
        public DataTable GET_CATEGORY()
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            dt = DAL.select_data("GET_CATEGORY", null);
            DAL.close();
            return (dt);
        }




        //اضافة منتج جديد
        public void ADD_PRODUCT(int id_cat, string id_product, string des_product, 
                                int qte, string price, byte[] image_product)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar,50);
            param[1].Value = id_product;
            
            param[2] = new SqlParameter("@des_product", SqlDbType.VarChar,50);
            param[2].Value = des_product;
            
            param[3] = new SqlParameter("@qte", SqlDbType.Int);
            param[3].Value = qte;
            
            param[4] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[4].Value = price;
            
            param[5] = new SqlParameter("@image_product", SqlDbType.Image);
            param[5].Value = image_product;
            DAL.execute_command("ADD_PRODUCT", param);
            DAL.close();
        }

        //للتحقق من معرف المنتج
        public DataTable VERFAY_ID_PRODUCT(string id_product)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[0].Value = id_product;
            dt = DAL.select_data("VERFAY_ID_PRODUCT", param);
            DAL.close();
            return (dt);
        }
        //لتعبئة الداتا غريد فيو
        public DataTable GET_ALL_PRODUCT()
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            dt = DAL.select_data("GET_ALL_PRODUCT", null);
            DAL.close();
            return (dt);
        }
        //للبحث
        public DataTable SEARCH_PRODUCT(string id)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            dt = DAL.select_data("SEARCH_PRODUCT", param);
            DAL.close();
            return (dt);
        }
        //للحذف
        public void DELETE_PRODUCT(string id_product)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[0].Value = id_product;

            DAL.execute_command("DELETE_PRODUCT", param);
            DAL.close();
        }
        //لجلب صورة المنتج
        public DataTable GET_IMAGE_PRODUCT(string id_product)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[0].Value = id_product;
            dt = DAL.select_data("GET_IMAGE_PRODUCT", param);
            DAL.close();
            return (dt);
        }
        //للتعديل
        public void UPDATE_PRODUCT(int id_cat, string id_product, string des_product,
                              int qte, string price, byte[] image_product)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id_cat", SqlDbType.Int);
            param[0].Value = id_cat;

            param[1] = new SqlParameter("@id_product", SqlDbType.VarChar, 50);
            param[1].Value = id_product;

            param[2] = new SqlParameter("@des_product", SqlDbType.VarChar, 50);
            param[2].Value = des_product;

            param[3] = new SqlParameter("@qte", SqlDbType.Int);
            param[3].Value = qte;

            param[4] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[4].Value = price;

            param[5] = new SqlParameter("@image_product", SqlDbType.Image);
            param[5].Value = image_product;
            DAL.execute_command("UPDATE_PRODUCT", param);
            DAL.close();
        }



    }
}
