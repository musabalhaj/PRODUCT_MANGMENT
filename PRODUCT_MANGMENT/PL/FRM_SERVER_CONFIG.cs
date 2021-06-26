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
    public partial class FRM_SERVER_CONFIG : Form
    {
        public FRM_SERVER_CONFIG()
        {
            InitializeComponent();
            TXT_SERVER.Text = Properties.Settings.Default.server;
            TXT_DATABASE.Text = Properties.Settings.Default.database;
            if (Properties.Settings.Default.mode == "sql")
            {
                RB_SQL.Checked = true;
                TXT_ID.Text = Properties.Settings.Default.id;
                TXT_PWD.Text = Properties.Settings.Default.pwd;
            }
            else
            {
                RB_WINDOWS.Checked = true;
                TXT_ID.Clear();
                TXT_PWD.Clear();
                TXT_ID.ReadOnly = true;
                TXT_PWD.ReadOnly = true;
            }

        }  

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = TXT_SERVER.Text;
            Properties.Settings.Default.database = TXT_DATABASE.Text;
            Properties.Settings.Default.mode = RB_SQL.Checked == true ? "sql" : "windows";
            Properties.Settings.Default.id = TXT_ID.Text;
            Properties.Settings.Default.pwd = TXT_PWD.Text;
            Properties.Settings.Default.Save();
        }

        private void RB_SQL_CheckedChanged(object sender, EventArgs e)
        {
            TXT_ID.ReadOnly = false;
            TXT_PWD.ReadOnly = false;
        }

        private void RB_WINDOWS_CheckedChanged(object sender, EventArgs e)
        {
            TXT_ID.ReadOnly = true;
            TXT_PWD.ReadOnly = true;
        }
    }
}
