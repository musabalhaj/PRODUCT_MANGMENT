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
    public partial class FRM_CUSTOMER_LIST : Form
    {
        BL.CLS_CUSTOMER prd = new BL.CLS_CUSTOMER();
        public FRM_CUSTOMER_LIST()
        {
            InitializeComponent();
            this.DGV_CUSTOMER.DataSource = prd.GET_ALL_CUSTOMER(); 
            DGV_CUSTOMER.Columns[0].Visible = false;
            DGV_CUSTOMER.Columns[5].Visible = false;
        }

        private void DGV_CUSTOMER_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
