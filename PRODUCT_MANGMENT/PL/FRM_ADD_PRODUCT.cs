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
    public partial class FRM_ADD_PRODUCT : Form
    {
        public string state = "add";
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            //لتعبئة الكومبو بوكس
            cmd_cat.DataSource = prd.GET_CATEGORY();
            cmd_cat.DisplayMember = "des_cat";
            cmd_cat.ValueMember = "id_cat";

        }
        //تحديد ملف الصورة
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.BMP;*.GIF ;*.PNG ;*.JPG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_des.Text == string.Empty || txt_id.Text == string.Empty || txt_price.Text == string.Empty || txt_qte.Text == string.Empty)
            {
                MessageBox.Show("قم بادخال المعلوات كاملة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (state == "add")
                {
                    //لتحويل الصورة الي بيانات ثنائية
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    byte[] byte_image = ms.ToArray();
                    //للاضافة منتج جديد
                    prd.ADD_PRODUCT(Convert.ToInt32(cmd_cat.SelectedValue), txt_id.Text,
                        txt_des.Text, Convert.ToInt32(txt_qte.Text), txt_price.Text, byte_image);
                    MessageBox.Show("تمت عملية الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pbox.Image.Save(ms, pbox.Image.RawFormat);
                    byte[] byte_image = ms.ToArray();
                    //لتعديل منتج 
                    prd.UPDATE_PRODUCT(Convert.ToInt32(cmd_cat.SelectedValue), txt_id.Text,
                        txt_des.Text, Convert.ToInt32(txt_qte.Text), txt_price.Text, byte_image);
                    MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                FRM_PRODUCT.get_FRM_PRODUCT.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_id_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = prd.VERFAY_ID_PRODUCT(txt_id.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا المعرف موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_id.Focus();
                    txt_id.SelectionStart = 0;
                    txt_id.SelectionLength = txt_id.TextLength;
                }
            }
        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }
    }
}
