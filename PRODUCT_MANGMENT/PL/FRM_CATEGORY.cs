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
    public partial class FRM_CATEGORY : Form
    {
        //لانشاء اتصال بين قاعدة البيانات والمشروع
        SqlConnection sqlcon = new SqlConnection(@"server=MUSAB-PC;database=product_db;integrated security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        //لعمل الاضافة والحذف والتعديل
        BindingManagerBase bmb;
        SqlCommandBuilder cmdb;
        public FRM_CATEGORY()
        {
            InitializeComponent();
            //لعرض البيانات في الداتا غريد فيو
            da = new SqlDataAdapter("select id_cat as'معرف الصنف',des_cat as'اسم الصنف' from tbl_category", sqlcon);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //لعرض البيانات في التيكست بوكس
            TXT_ID_CAT.DataBindings.Add("text", dt, "معرف الصنف");
            TXT_DES_CAT.DataBindings.Add("text", dt, "اسم الصنف");
            bmb = this.BindingContext[dt];
            LPOZITION.Text = (bmb.Position+1 + "  /  " + bmb.Count);
        }

        private void BTN_FIRST_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            LPOZITION.Text = (bmb.Position + 1 + "  /  " + bmb.Count);
        }

        private void BTN_LAST_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            LPOZITION.Text = (bmb.Position + 1 + "  /  " + bmb.Count);

        }

        private void BTN_NEXT_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            LPOZITION.Text = (bmb.Position + 1 + "  /  " + bmb.Count);

        }

        private void BTN_PRIVUSE_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            LPOZITION.Text = (bmb.Position + 1 + "  /  " + bmb.Count);

        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            BTN_ADD.Enabled = true;
            BTN_NEW.Enabled = false;
            //لجلب اخر رقم صنف زائد واحد
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0])+1;
            TXT_ID_CAT.Text = id.ToString();
            TXT_DES_CAT.Focus();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت عملية الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BTN_ADD.Enabled = false ;
            BTN_NEW.Enabled = true;
            LPOZITION.Text = (bmb.Position + 1 + "  /  " + bmb.Count);

        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الصنف؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                bmb.RemoveAt(bmb.Position);
                bmb.EndCurrentEdit();
                cmdb = new SqlCommandBuilder(da);
                da.Update(dt);
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LPOZITION.Text = (bmb.Position + 1 + "  /  " + bmb.Count);
            }
            else
            {
                MessageBox.Show("تمت  الغاء عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LPOZITION.Text = (bmb.Position + 1 + "  /  " + bmb.Count);
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
