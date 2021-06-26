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
    public partial class FRM_MAIN : Form
    {
        //للتعامل مع الشاشة الريئسية مباشرة
        private static FRM_MAIN frm;

        static void frm_formclosed(object sender, EventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN get_mainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_formclosed);
                }
                return frm;
            }
            
        }
        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            //الغاء تفعيل القوائم
            this.المنتجاتToolStripMenuItem.Enabled = false;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.المستخدمينToolStripMenuItem.Enabled = false;
            this.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
            this.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = false;
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCT frm = new FRM_PRODUCT();
            frm.ShowDialog();
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORY frm = new FRM_CATEGORY();
            frm.ShowDialog();
        }

        private void ادارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER frm = new FRM_CUSTOMER();
            frm.ShowDialog();
        }

        private void اضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER frm = new FRM_ORDER();
            frm.ShowDialog();
        }

        private void ادارةالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER_LIST frm = new FRM_ORDER_LIST();
            frm.ShowDialog();

        }

        private void اضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.ShowDialog();
        }

        private void ادارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USER frm = new FRM_USER();
            frm.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_MAIN.get_mainform.المنتجاتToolStripMenuItem.Enabled = false;
            FRM_MAIN.get_mainform.العملاءToolStripMenuItem.Enabled = false;
            FRM_MAIN.get_mainform.المستخدمينToolStripMenuItem.Enabled = false;
            FRM_MAIN.get_mainform.انشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            FRM_MAIN.get_mainform.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
            this.اعداداتالاتصالبالسيرفرToolStripMenuItem.Enabled = false;
        }

        private void انشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void استعادةنسخةمحفوظةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTOR frm = new FRM_RESTOR();
            frm.ShowDialog();
        }

        private void اعداداتالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SERVER_CONFIG frm = new FRM_SERVER_CONFIG();
            frm.ShowDialog();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
