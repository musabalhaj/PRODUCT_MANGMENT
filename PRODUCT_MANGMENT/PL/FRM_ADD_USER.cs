using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRODUCT_MANGMENT.PL
{
    public partial class FRM_ADD_USER : Form
    {
        public string state = "add";
        BL.CLS_USER prd = new BL.CLS_USER();
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                if (TXT_PWD.Text == TXT_RPWD.Text)
                {
                    prd.ADD_USER(TXT_ID.Text, TXT_PWD.Text, TXT_FULLNAME.Text, CMB_USERTYPE.Text);
                    MessageBox.Show("تمت عملية الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXT_FULLNAME.Clear();
                    TXT_ID.Clear();
                    TXT_PWD.Clear();
                    TXT_RPWD.Clear();
                    TXT_ID.Focus();
                }
                else
                {
                    MessageBox.Show("كلمة السر غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXT_PWD.Clear();
                    TXT_RPWD.Clear();
                    TXT_PWD.Focus();
                }
            }
            else
            {
                prd.UPDATE_USER(TXT_ID.Text, TXT_PWD.Text, TXT_FULLNAME.Text, CMB_USERTYPE.Text);
                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
