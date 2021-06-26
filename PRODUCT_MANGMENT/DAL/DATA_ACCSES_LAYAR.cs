using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PRODUCT_MANGMENT.DAL
{
    class DATA_ACCSES_LAYAR
    {
        SqlConnection SqlConnection;
        
        //  انشاء كائن للاتصال مع الداتا بيز
        public DATA_ACCSES_LAYAR()
        {
            SqlConnection = new SqlConnection(@"server=MUSAB-PC;database=product_db;integrated security=true");
        }
        //دالة فتح الاتصال
        public void open()
        {
            if (SqlConnection.State != ConnectionState.Open)
                SqlConnection.Open();
        }
        //دالة اغلاق الاتصال
        public void close()
        {
            if(SqlConnection.State==ConnectionState.Open)
                SqlConnection.Close();
        }
        //دالة لقراة البيانات من الداتا بيز
        public DataTable select_data(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
             da.Fill(dt);
            return (dt);
        }
        //دالة لتنفيذ اوامر الاضافة والحذف والتعديل
        public void execute_command(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }





    }
}
