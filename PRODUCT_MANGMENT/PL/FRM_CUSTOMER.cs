using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace PRODUCT_MANGMENT.PL
{
    public partial class FRM_CUSTOMER : Form
    {
        BL.CLS_CUSTOMER prd = new BL.CLS_CUSTOMER();
        DataTable dt = new DataTable();
        public FRM_CUSTOMER()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.GET_ALL_CUSTOMER();
            //لائخفاء معرف العميل من الداتا قريد فيو
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            PBOX.Image.Save(ms,PBOX.Image.RawFormat);
            byte[] byte_image = ms.ToArray();
            prd.ADD_CUSTOMER(Convert.ToInt32(TXT_ID_CUSTOMER.Text), TXT_FIRST_NAME.Text, TXT_LAST_NAME.Text,
                             TXT_PHONE.Text, TXT_EMAIL.Text, byte_image);
            MessageBox.Show("تمت عملية الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridView1.DataSource = prd.GET_ALL_CUSTOMER();
        }

        private void PBOX_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "ملفات الصور |*.BMP;*.GIF ;*.PNG ;*.JPG";
            if (op.ShowDialog() == DialogResult.OK)
            {
                PBOX.Image = Image.FromFile(op.FileName);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.TXT_ID_CUSTOMER.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.TXT_FIRST_NAME.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.TXT_LAST_NAME.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.TXT_PHONE.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.TXT_EMAIL.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] image_customer = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(image_customer);
                PBOX.Image = Image.FromStream(ms);

        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            
            MemoryStream ms = new MemoryStream();
            PBOX.Image.Save(ms, PBOX.Image.RawFormat);
            byte[] byte_image = ms.ToArray();
            prd.UPDATE_CUSTOMER(Convert.ToInt32(TXT_ID_CUSTOMER.Text), TXT_FIRST_NAME.Text, TXT_LAST_NAME.Text,
                             TXT_PHONE.Text, TXT_EMAIL.Text, byte_image);
            MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dataGridView1.DataSource = prd.GET_ALL_CUSTOMER();
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العميل", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prd.DELETE_CUSTOMER(Convert.ToInt32(TXT_ID_CUSTOMER.Text));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT_ID_CUSTOMER.Clear();
                TXT_FIRST_NAME.Clear();
                TXT_LAST_NAME.Clear();
                TXT_PHONE.Clear();
                TXT_EMAIL.Clear();
                PBOX.ResetText();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.dataGridView1.DataSource = prd.GET_ALL_CUSTOMER();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prd.SEARCH_CUSTOMER(TXT_SEARCH.Text);
        }

        //عند الضغط علي انتر في مربع البحث يقوم بالبحث
        private void TXT_SEARCH_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = prd.SEARCH_CUSTOMER(TXT_SEARCH.Text);
            }
        }
        //م شغالات في الشغل دا
        private void BTN_FIRST_Click(object sender, EventArgs e)
        {
        }

        private void BTN_LAST_Click(object sender, EventArgs e)
        {

        }

        private void BTN_NEXT_Click(object sender, EventArgs e)
        {

        }

        private void BTN_PRIVUES_Click(object sender, EventArgs e)
        {
        }
    }
}
