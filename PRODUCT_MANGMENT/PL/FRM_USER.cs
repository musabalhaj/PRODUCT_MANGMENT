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
    public partial class FRM_USER : Form
    {
        BL.CLS_USER prd = new BL.CLS_USER();
        public FRM_USER()
        {
            InitializeComponent();
            DGV_USER.DataSource = prd.GET_ALL_USER();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.ShowDialog();
            DGV_USER.DataSource = prd.GET_ALL_USER();
        }

        private void TXT_SEARSH_Validated(object sender, EventArgs e)
        {
           
        }

        private void TXT_SEARSH_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.SEARCH_USER(TXT_SEARSH.Text);
            this.DGV_USER.DataSource = dt;
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
       
            if (MessageBox.Show("هل تريد حذف المنتج المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                prd.DELETE_USER(this.DGV_USER.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
          //لتحديث الداتا غريت فيو
                this.DGV_USER.DataSource = prd.GET_ALL_USER();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BTN_UPDATE_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.TXT_ID.Text=this.DGV_USER.CurrentRow.Cells[0].Value.ToString();
            frm.TXT_PWD.Text = this.DGV_USER.CurrentRow.Cells[1].Value.ToString();
            frm.TXT_RPWD.Text = this.DGV_USER.CurrentRow.Cells[1].Value.ToString();
            frm.TXT_FULLNAME.Text = this.DGV_USER.CurrentRow.Cells[2].Value.ToString();
            frm.CMB_USERTYPE.Text = this.DGV_USER.CurrentRow.Cells[3].Value.ToString();
            frm.Text = "تعديل بيانات المنتج: " + this.DGV_USER.CurrentRow.Cells[0].Value.ToString();
            frm.BTN_ADD.Text = "تعديل";
            frm.state = "update";
            frm.TXT_ID.ReadOnly = true;
            frm.ShowDialog();
            DGV_USER.DataSource = prd.GET_ALL_USER();
        }




        }

    }

