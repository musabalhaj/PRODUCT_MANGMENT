namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_USER
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_SEARSH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_USER = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USER)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_SEARSH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DGV_USER);
            this.groupBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لائحة المستخدمين";
            // 
            // TXT_SEARSH
            // 
            this.TXT_SEARSH.Location = new System.Drawing.Point(6, 33);
            this.TXT_SEARSH.Name = "TXT_SEARSH";
            this.TXT_SEARSH.Size = new System.Drawing.Size(337, 34);
            this.TXT_SEARSH.TabIndex = 2;
            this.TXT_SEARSH.TextChanged += new System.EventHandler(this.TXT_SEARSH_TextChanged);
            this.TXT_SEARSH.Validated += new System.EventHandler(this.TXT_SEARSH_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "قم بادخال الكلمة المراد البحث عنها";
            // 
            // DGV_USER
            // 
            this.DGV_USER.AllowUserToAddRows = false;
            this.DGV_USER.AllowUserToDeleteRows = false;
            this.DGV_USER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_USER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_USER.Location = new System.Drawing.Point(6, 75);
            this.DGV_USER.Name = "DGV_USER";
            this.DGV_USER.ReadOnly = true;
            this.DGV_USER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_USER.Size = new System.Drawing.Size(685, 205);
            this.DGV_USER.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_CLOSE);
            this.groupBox2.Controls.Add(this.BTN_UPDATE);
            this.groupBox2.Controls.Add(this.BTN_DELETE);
            this.groupBox2.Controls.Add(this.BTN_ADD);
            this.groupBox2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE.Image = global::PRODUCT_MANGMENT.Properties.Resources.cancel;
            this.BTN_CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLOSE.Location = new System.Drawing.Point(6, 43);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(105, 36);
            this.BTN_CLOSE.TabIndex = 11;
            this.BTN_CLOSE.Text = "الخروج";
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_form_edit;
            this.BTN_UPDATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_UPDATE.Location = new System.Drawing.Point(117, 43);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(204, 36);
            this.BTN_UPDATE.TabIndex = 10;
            this.BTN_UPDATE.Text = "تعديل بيانات المستخدم";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_delete;
            this.BTN_DELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DELETE.Location = new System.Drawing.Point(327, 43);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(190, 36);
            this.BTN_DELETE.TabIndex = 9;
            this.BTN_DELETE.Text = "حذف المستخدم المحدد";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Image = global::PRODUCT_MANGMENT.Properties.Resources.add;
            this.BTN_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ADD.Location = new System.Drawing.Point(523, 43);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(168, 36);
            this.BTN_ADD.TabIndex = 8;
            this.BTN_ADD.Text = "اضافة مستخدم جديد";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // FRM_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(720, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_USER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة ادارة المستخدمين";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_USER)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_USER;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button BTN_CLOSE;
        public System.Windows.Forms.Button BTN_UPDATE;
        public System.Windows.Forms.Button BTN_DELETE;
        public System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.TextBox TXT_SEARSH;
        private System.Windows.Forms.Label label1;
    }
}