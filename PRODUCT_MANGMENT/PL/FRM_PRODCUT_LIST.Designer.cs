namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_PRODUCT_LIST
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
            this.DGV_PRODUCT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_PRODUCT
            // 
            this.DGV_PRODUCT.AllowUserToAddRows = false;
            this.DGV_PRODUCT.AllowUserToDeleteRows = false;
            this.DGV_PRODUCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_PRODUCT.Location = new System.Drawing.Point(0, 0);
            this.DGV_PRODUCT.Name = "DGV_PRODUCT";
            this.DGV_PRODUCT.ReadOnly = true;
            this.DGV_PRODUCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCT.Size = new System.Drawing.Size(778, 379);
            this.DGV_PRODUCT.TabIndex = 0;
            this.DGV_PRODUCT.DoubleClick += new System.EventHandler(this.DGV_PRODUCT_DoubleClick);
            // 
            // FRM_PRODUCT_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 379);
            this.Controls.Add(this.DGV_PRODUCT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_PRODUCT_LIST";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "لائحة المنتجات";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DGV_PRODUCT;

    }
}