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
    public partial class FRM_ORDER_LIST : Form
    {
        BL.CLS_ORDER prd = new BL.CLS_ORDER();
        public FRM_ORDER_LIST()
        {
            InitializeComponent();
            this.DGV_ORDER.DataSource = prd.SEARCH_ORDER("");

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            this.DGV_ORDER.DataSource = prd.SEARCH_ORDER(txt_search.Text);
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
