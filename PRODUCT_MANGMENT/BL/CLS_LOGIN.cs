using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PRODUCT_MANGMENT.BL
{
    class CLS_LOGIN
    {
        //دالة لمقارنة اسم المستخدم وكلمة المرور مع البيانات في الداتا بيز
        public DataTable LOGIN(string id, string pwd)
        {
            DAL.DATA_ACCSES_LAYAR DAL = new DAL.DATA_ACCSES_LAYAR();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            
            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;
            
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.select_data("LOGIN_DB", param);
            DAL.close();
            return (dt);
            
        }
    }
}
