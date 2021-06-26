using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PRODUCT_MANGMENT.PL
{
    public partial class FRM_RESTOR : Form
    {
        SqlConnection con = new SqlConnection(@"server=MUSAB-PC;database=master;integrated security=true");
        SqlCommand cmd;
        public FRM_RESTOR()
        {
           
            InitializeComponent();
        }

        private void BTN_BROWS_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TXT_FILE_NAME.Text = openFileDialog1.FileName;
            }

        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_BACUP_Click(object sender, EventArgs e)
        {
            string command = "ALTER DATABASE product_db SET OFFLINE WITH ROLLBACK IMMEDIATE; restore database product_db from disk='"+TXT_FILE_NAME.Text+"'";
            cmd = new SqlCommand(command,con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم استعادة النسخة الاحتياطية", "استعادة نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
