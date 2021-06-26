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
    public partial class FRM_BACKUP : Form
    {
         
        SqlConnection con = new SqlConnection(@"server=MUSAB-PC;database=product_db;integrated security=true");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void BTN_BROWS_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TXT_FILE_NAME.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_BACUP_Click(object sender, EventArgs e)
        {
            string filename = TXT_FILE_NAME.Text + "\\product_db" + DateTime.Now.ToShortDateString().Replace('/', '-')
                + " _ " + DateTime.Now.ToLongTimeString().Replace(':', '-');
            string command = "backup database product_db to disk='"+filename+".bak'";
            cmd = new SqlCommand(command, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم انشاء النسخة الاحتياطية", "انشاء نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
