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
    public partial class FRM_ORDER : Form
    {
        BL.CLS_ORDER prd = new BL.CLS_ORDER();
        DataTable dt = new DataTable();
        //لحساب المبلغ 
        void calc_amount()
        {
            if (TXT_PRICE.Text != string.Empty && TXT_QTE.Text != string.Empty)
            {
                double amount = Convert.ToDouble(TXT_PRICE.Text) * Convert.ToInt32(TXT_QTE.Text);
                TXT_AMOUNT.Text = amount.ToString();
            }
         
        }
        //لحساب المبلغ بعد الخصم
        void calc_net_amount()
        {
            if (TXT_DESCOUNT.Text != string.Empty &&TXT_AMOUNT.Text!=string.Empty)
            {
                double descount = Convert.ToDouble(TXT_DESCOUNT.Text);
                double amount = Convert.ToDouble(TXT_AMOUNT.Text);
                double net_amount = amount - (amount * (descount / 100));
                TXT_NET_AMOUNT.Text = net_amount.ToString();
            }
        }
        //لاضافة حقول في الداتا غريد فيو
         void create_datatable()
        {
            dt.Columns.Add("معرف المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("الثمن");
            dt.Columns.Add("الكمية ");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("الخصم(%)");
            dt.Columns.Add("الاجمالي");
            DGV_PRODUCT.DataSource = dt;
        }
        //لتفريغ الحقول بعد الاضافة الي الداتا غريد فيو
         void clear_box()
         {
             TXT_ID_PRODUCT.Clear();
             TXT_DES_PRODUCT.Clear();
             TXT_QTE.Clear();
             TXT_PRICE.Clear();
             TXT_AMOUNT.Clear();
             TXT_DESCOUNT.Clear();
             TXT_NET_AMOUNT.Clear();

         }
         void clear_all()
         {
             TXT_ID_ORDER.Clear();
             TXT_DES_ORDER.Clear();
             TXT_SELMAN.Clear();
             TXT_DATE_ORDER.ResetText();
             TXT_ID_CUSTOMER.Clear();
             TXT_FIRST_NAME.Clear();
             TXT_LAST_NAME.Clear();
             TXT_EMAIL.Clear();
             TXT_PHONE.Clear();
             clear_box();
             dt.Clear();
             DGV_PRODUCT.DataSource = null;
             TXT_TOTAL_AMOUNT.Clear();
             PBOX.Image = null;
         }
        //لتغير حجم الحقول داخل الداتا غريد فيو للتتناسب مع مربعات النص
         void resaiz_dgv_product()
         {
             this.DGV_PRODUCT.RowHeadersWidth = 99;
             this.DGV_PRODUCT.Columns[0].Width = 105;
             this.DGV_PRODUCT.Columns[1].Width = 150;
             this.DGV_PRODUCT.Columns[2].Width = 128;
             this.DGV_PRODUCT.Columns[3].Width = 90;
             this.DGV_PRODUCT.Columns[4].Width = 89;
             this.DGV_PRODUCT.Columns[5].Width = 93;
             this.DGV_PRODUCT.Columns[6].Width = 119;

         }

        public FRM_ORDER()
        {
            InitializeComponent();
            create_datatable();
            resaiz_dgv_product();
            TXT_SELMAN.Text = Program.selman;
        }

        private void BTN_NEW_Click(object sender, EventArgs e)
        {
            this.TXT_ID_ORDER.Text = prd.GET_LAST_ORDER_ID().Rows[0][0].ToString();
          
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
           
            //للتحقق من وجود كل البيانات المهمة
            if (TXT_ID_ORDER.Text == string.Empty || TXT_DES_ORDER.Text == string.Empty || TXT_ID_CUSTOMER.Text == string.Empty || DGV_PRODUCT.Rows.Count < 1)
            {
                MessageBox.Show("قم بتسجيل المعلومات المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //لاضافة معلومات الفاتورة
            prd.ADD_ORDER(Convert.ToInt32(TXT_ID_ORDER.Text), TXT_DATE_ORDER.Value,
              Convert.ToInt32(TXT_ID_CUSTOMER.Text), TXT_DES_ORDER.Text, TXT_SELMAN.Text);
            //لاضافة تفاصيل الفواتير
            for (int i = 0; i < DGV_PRODUCT.Rows.Count - 1; i++)
            {
                prd.ADD_ORDER_DELAILS(DGV_PRODUCT.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToInt32(TXT_ID_ORDER.Text),
                   Convert.ToInt32(DGV_PRODUCT.Rows[i].Cells[3].Value),
                    DGV_PRODUCT.Rows[i].Cells[2].Value.ToString(),
                   Convert.ToInt32(DGV_PRODUCT.Rows[i].Cells[5].Value),
                    DGV_PRODUCT.Rows[i].Cells[4].Value.ToString(),
                    DGV_PRODUCT.Rows[i].Cells[6].Value.ToString());
            }
            MessageBox.Show("تمت عملية الاضافة بنجاح", "عملية الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clear_all();
        }

        private void BTN_CUSTOMER_VIWE_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER_LIST frm = new FRM_CUSTOMER_LIST();
            frm.ShowDialog();
            if (frm.DGV_CUSTOMER.CurrentRow.Cells[5].Value is DBNull)
            {
                MessageBox.Show("هذا العميل لا يحتوي علي صورة");
                this.TXT_ID_CUSTOMER.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[0].Value.ToString();
                this.TXT_FIRST_NAME.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[1].Value.ToString();
                this.TXT_LAST_NAME.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[2].Value.ToString();
                this.TXT_PHONE.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[3].Value.ToString();
                this.TXT_EMAIL.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[4].Value.ToString();
                return;
            }
            this.TXT_ID_CUSTOMER.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[0].Value.ToString();
            this.TXT_FIRST_NAME.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[1].Value.ToString();
            this.TXT_LAST_NAME.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[2].Value.ToString();
            this.TXT_PHONE.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[3].Value.ToString();
            this.TXT_EMAIL.Text = frm.DGV_CUSTOMER.CurrentRow.Cells[4].Value.ToString();
            byte[] cust_image = (byte[])frm.DGV_CUSTOMER.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(cust_image);
            PBOX.Image = Image.FromStream(ms);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_box();
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();
            //لعرض رقم المنتج واسم المنتج والثمن في التيكست بوكس من الداتا غريد فيو
            TXT_ID_PRODUCT.Text = frm.DGV_PRODUCT.CurrentRow.Cells[0].Value.ToString();
            TXT_DES_PRODUCT.Text = frm.DGV_PRODUCT.CurrentRow.Cells[1].Value.ToString();
            TXT_PRICE.Text = frm.DGV_PRODUCT.CurrentRow.Cells[3].Value.ToString();
            TXT_QTE.Focus();

        }
        //منع كتابة القيم الغير رقمية
        private void TXT_QTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //يسمح بكتابة الارقام وتفعيل زر المسح
              if(!char.IsDigit(e.KeyChar) &&e.KeyChar !=8)
              {
                  //منع عملية الكتابة
                  e.Handled = true;
              }
 
        }

        private void TXT_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            //يسمح بكتابة الارقام وزر لمسح والفاصة المستخدمة في العملات
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8&e.KeyChar!=Convert.ToChar( System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                //منع عملية الكتابة
                e.Handled = true;
            }

        }

        private void TXT_PRICE_KeyDown(object sender, KeyEventArgs e)
        {
            //عند الضغط علي الانتر بعد كتابة الثمن ينتقل الي الكمية ولكن اذا كان الثمن غير فارغ
            if (e.KeyCode == Keys.Enter &&TXT_PRICE.Text!=string.Empty)
            {
                TXT_QTE.Focus();
            }
        }

        private void TXT_QTE_KeyDown(object sender, KeyEventArgs e)
        {
            //عند الضغط علي الانتر بعد كتابة الكمية ينتقل الي الخصم ولكن اذا كان الكمية غير فارغ
            if (e.KeyCode == Keys.Enter && TXT_QTE.Text != string.Empty)
            {
                TXT_DESCOUNT.Focus();
            }
        }

        private void TXT_PRICE_KeyUp(object sender, KeyEventArgs e)
        {
            calc_amount();
            calc_net_amount();
        }

        private void TXT_QTE_KeyUp(object sender, KeyEventArgs e)
        {
            calc_amount();
            calc_net_amount();
        }

        private void TXT_DESCOUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //يسمح بكتابة الارقام وتفعيل زر المسح
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //منع عملية الكتابة
                e.Handled = true;
            }
        }

        private void TXT_DESCOUNT_KeyUp(object sender, KeyEventArgs e)
        {
            calc_net_amount();
        }

        private void TXT_DESCOUNT_KeyDown(object sender, KeyEventArgs e)
        {
            //لاضافة البيانات من التيكست بوكس الي الداتا غريد فيو
            if (e.KeyCode == Keys.Enter)
            {
                //للتحقق من ان الكمية متاحة
                if (prd.VERFAIY_QTE(TXT_ID_PRODUCT.Text, Convert.ToInt32(TXT_QTE.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكمية المدخلة غير متوفرة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TXT_QTE.Focus();
                    return;

                }

                for (int i = 0; i < DGV_PRODUCT.Rows.Count - 1; i++)
                {

                    if (DGV_PRODUCT.Rows[i].Cells[0].Value.ToString() == TXT_ID_PRODUCT.Text)
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                    DataRow r = dt.NewRow();
                    r[0] = TXT_ID_PRODUCT.Text;
                    r[1] = TXT_DES_PRODUCT.Text;
                    r[2] = TXT_PRICE.Text;
                    r[3] = TXT_QTE.Text;
                    r[4] = TXT_AMOUNT.Text;
                    r[5] = TXT_DESCOUNT.Text;
                    r[6] = TXT_NET_AMOUNT.Text;
                    dt.Rows.Add(r);
                    DGV_PRODUCT.DataSource = dt;
                    clear_box();
                    BTN_PRODUCT_VIWE.Focus();
                    //لحساب المجموع الكلي للاجمالي
                    TXT_TOTAL_AMOUNT.Text = (from DataGridViewRow row in DGV_PRODUCT.Rows
                                             where row.Cells[6].FormattedValue.ToString() != string.Empty
                                             select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

                
            }
           
        }
        //لتعديل المنتج 
        private void DGV_PRODUCT_DoubleClick(object sender, EventArgs e)
        {
            TXT_ID_PRODUCT.Text = this.DGV_PRODUCT.CurrentRow.Cells[0].Value.ToString();
            TXT_DES_PRODUCT.Text = this.DGV_PRODUCT.CurrentRow.Cells[1].Value.ToString();
            TXT_PRICE.Text = this.DGV_PRODUCT.CurrentRow.Cells[2].Value.ToString();
            TXT_QTE.Text = this.DGV_PRODUCT.CurrentRow.Cells[3].Value.ToString();
            TXT_AMOUNT.Text = this.DGV_PRODUCT.CurrentRow.Cells[4].Value.ToString();
            TXT_DESCOUNT.Text = this.DGV_PRODUCT.CurrentRow.Cells[5].Value.ToString();
            TXT_NET_AMOUNT.Text = this.DGV_PRODUCT.CurrentRow.Cells[6].Value.ToString();
            DGV_PRODUCT.Rows.RemoveAt(DGV_PRODUCT.CurrentRow.Index);
            TXT_QTE.Focus();
            

        }

        private void DGV_PRODUCT_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //لتحديث المجموع بعد الحذف
            TXT_TOTAL_AMOUNT.Text = (from DataGridViewRow row in DGV_PRODUCT.Rows
                                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV_PRODUCT_DoubleClick(sender, e);
        }

        private void حذفالسطرالحاليToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV_PRODUCT.Rows.RemoveAt(DGV_PRODUCT.CurrentRow.Index);
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            DGV_PRODUCT.Refresh();
        }

        private void BTN_DELETE_SELECTED_ROW_Click(object sender, EventArgs e)
        {
            DGV_PRODUCT.Rows.RemoveAt(DGV_PRODUCT.CurrentRow.Index);
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
