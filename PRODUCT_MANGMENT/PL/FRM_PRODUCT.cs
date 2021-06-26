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
namespace PRODUCT_MANGMENT.PL
{
    public partial class FRM_PRODUCT : Form
    {
        private static FRM_PRODUCT frm;

        static void frm_formclosed(object sender, EventArgs e)
        {
            frm = null;
        }
        public static FRM_PRODUCT get_FRM_PRODUCT
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCT();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }

        }
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_PRODUCT()
        {
            InitializeComponent();
            if (frm == null)
               frm = this;
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.ShowDialog();
        }
        //البحث
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.SEARCH_PRODUCT(txt_search.Text);
            this.dataGridView1.DataSource = dt;
        }
        //الحذف
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتج المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                prd.DELETE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
          //لتحديث الداتا غريت فيو
                this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            FRM_ADD_PRODUCT frm = new FRM_ADD_PRODUCT();
            frm.txt_id.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txt_des.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txt_qte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txt_price.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmd_cat.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تعديل بيانات المنتج: " + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btn_add.Text = "تعديل";
            frm.state = "update";
            frm.txt_id.ReadOnly =true;
            frm.txt_des.Focus();
      //لجلب الصورة وتحويلها من بيانات ثنائية الي صورة 
            byte[] image_pro = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image_pro);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_pbox_Click(object sender, EventArgs e)
        {
            //لجلب صورة المنتج من الداتا بيز
            FRM_IMAGE_PREVIEW frm = new FRM_IMAGE_PREVIEW();
            byte[] image_pro = (byte[])prd.GET_IMAGE_PRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image_pro);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.ShowDialog();
        }
    }
}
