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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN prd = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
         
        }





        private void btn_login_Click_1(object sender, EventArgs e)
        {
            DataTable dt = prd.LOGIN(txt_id.Text, txt_pwd.Text);
            if (dt.Rows.Count > 0)
            {
                //تفعيل القوائم
                FRM_MAIN.get_mainform.المنتجاتToolStripMenuItem.Enabled = true;
                FRM_MAIN.get_mainform.العملاءToolStripMenuItem.Enabled = true;
                FRM_MAIN.get_mainform.المستخدمينToolStripMenuItem.Enabled = true;
                FRM_MAIN.get_mainform.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                FRM_MAIN.get_mainform.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                 FRM_MAIN.get_mainform.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = true;
                //
                Program.selman = dt.Rows[0]["full_name"].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("فشل في تسجيل الدخول");
                txt_id.Focus();
                txt_pwd.Clear();
                txt_id.Clear();
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
