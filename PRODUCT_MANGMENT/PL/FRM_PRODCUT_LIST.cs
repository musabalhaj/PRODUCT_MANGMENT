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
    public partial class FRM_PRODUCT_LIST : Form
    {
        BL.CLS_PRODUCT prd = new BL.CLS_PRODUCT();
        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            this.DGV_PRODUCT.DataSource = prd.GET_ALL_PRODUCT();
        }

        private void DGV_PRODUCT_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
