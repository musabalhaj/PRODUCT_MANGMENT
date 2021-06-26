namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_CUSTOMER_LIST
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_CUSTOMER = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_CUSTOMER
            // 
            this.DGV_CUSTOMER.AllowUserToAddRows = false;
            this.DGV_CUSTOMER.AllowUserToDeleteRows = false;
            this.DGV_CUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_CUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CUSTOMER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_CUSTOMER.Location = new System.Drawing.Point(0, 0);
            this.DGV_CUSTOMER.Name = "DGV_CUSTOMER";
            this.DGV_CUSTOMER.ReadOnly = true;
            this.DGV_CUSTOMER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CUSTOMER.Size = new System.Drawing.Size(777, 386);
            this.DGV_CUSTOMER.TabIndex = 0;
            this.DGV_CUSTOMER.DoubleClick += new System.EventHandler(this.DGV_CUSTOMER_DoubleClick);
            // 
            // FRM_CUSTOMER_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 386);
            this.Controls.Add(this.DGV_CUSTOMER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CUSTOMER_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لائحة العملاء";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CUSTOMER)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_CUSTOMER;

    }
}