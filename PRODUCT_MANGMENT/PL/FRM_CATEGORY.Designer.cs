namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_CATEGORY
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LPOZITION = new System.Windows.Forms.Label();
            this.BTN_LAST = new System.Windows.Forms.Button();
            this.BTN_PRIVUSE = new System.Windows.Forms.Button();
            this.BTN_NEXT = new System.Windows.Forms.Button();
            this.BTN_FIRST = new System.Windows.Forms.Button();
            this.TXT_DES_CAT = new System.Windows.Forms.TextBox();
            this.TXT_ID_CAT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.LPOZITION);
            this.groupBox1.Controls.Add(this.BTN_LAST);
            this.groupBox1.Controls.Add(this.BTN_PRIVUSE);
            this.groupBox1.Controls.Add(this.BTN_NEXT);
            this.groupBox1.Controls.Add(this.BTN_FIRST);
            this.groupBox1.Controls.Add(this.TXT_DES_CAT);
            this.groupBox1.Controls.Add(this.TXT_ID_CAT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الصنف";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(4, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لائحة الاصناف";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(364, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // LPOZITION
            // 
            this.LPOZITION.AutoSize = true;
            this.LPOZITION.Location = new System.Drawing.Point(508, 187);
            this.LPOZITION.Name = "LPOZITION";
            this.LPOZITION.Size = new System.Drawing.Size(50, 25);
            this.LPOZITION.TabIndex = 8;
            this.LPOZITION.Text = "label3";
            // 
            // BTN_LAST
            // 
            this.BTN_LAST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LAST.Image = global::PRODUCT_MANGMENT.Properties.Resources.control_skip_180;
            this.BTN_LAST.Location = new System.Drawing.Point(386, 184);
            this.BTN_LAST.Name = "BTN_LAST";
            this.BTN_LAST.Size = new System.Drawing.Size(54, 30);
            this.BTN_LAST.TabIndex = 7;
            this.BTN_LAST.UseVisualStyleBackColor = true;
            this.BTN_LAST.Click += new System.EventHandler(this.BTN_LAST_Click);
            // 
            // BTN_PRIVUSE
            // 
            this.BTN_PRIVUSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRIVUSE.Image = global::PRODUCT_MANGMENT.Properties.Resources.control_stop_180;
            this.BTN_PRIVUSE.Location = new System.Drawing.Point(446, 184);
            this.BTN_PRIVUSE.Name = "BTN_PRIVUSE";
            this.BTN_PRIVUSE.Size = new System.Drawing.Size(54, 30);
            this.BTN_PRIVUSE.TabIndex = 6;
            this.BTN_PRIVUSE.UseVisualStyleBackColor = true;
            this.BTN_PRIVUSE.Click += new System.EventHandler(this.BTN_PRIVUSE_Click);
            // 
            // BTN_NEXT
            // 
            this.BTN_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEXT.Image = global::PRODUCT_MANGMENT.Properties.Resources.control_stop;
            this.BTN_NEXT.Location = new System.Drawing.Point(564, 184);
            this.BTN_NEXT.Name = "BTN_NEXT";
            this.BTN_NEXT.Size = new System.Drawing.Size(54, 30);
            this.BTN_NEXT.TabIndex = 5;
            this.BTN_NEXT.UseVisualStyleBackColor = true;
            this.BTN_NEXT.Click += new System.EventHandler(this.BTN_NEXT_Click);
            // 
            // BTN_FIRST
            // 
            this.BTN_FIRST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FIRST.Image = global::PRODUCT_MANGMENT.Properties.Resources.control_skip;
            this.BTN_FIRST.Location = new System.Drawing.Point(624, 184);
            this.BTN_FIRST.Name = "BTN_FIRST";
            this.BTN_FIRST.Size = new System.Drawing.Size(54, 30);
            this.BTN_FIRST.TabIndex = 4;
            this.BTN_FIRST.UseVisualStyleBackColor = true;
            this.BTN_FIRST.Click += new System.EventHandler(this.BTN_FIRST_Click);
            // 
            // TXT_DES_CAT
            // 
            this.TXT_DES_CAT.Location = new System.Drawing.Point(386, 115);
            this.TXT_DES_CAT.Name = "TXT_DES_CAT";
            this.TXT_DES_CAT.Size = new System.Drawing.Size(155, 34);
            this.TXT_DES_CAT.TabIndex = 3;
            // 
            // TXT_ID_CAT
            // 
            this.TXT_ID_CAT.Location = new System.Drawing.Point(456, 75);
            this.TXT_ID_CAT.Name = "TXT_ID_CAT";
            this.TXT_ID_CAT.ReadOnly = true;
            this.TXT_ID_CAT.Size = new System.Drawing.Size(85, 34);
            this.TXT_ID_CAT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "معرف الصنف";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_CLOSE);
            this.groupBox2.Controls.Add(this.BTN_NEW);
            this.groupBox2.Controls.Add(this.BTN_UPDATE);
            this.groupBox2.Controls.Add(this.BTN_DELETE);
            this.groupBox2.Controls.Add(this.BTN_ADD);
            this.groupBox2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE.Image = global::PRODUCT_MANGMENT.Properties.Resources.cancel;
            this.BTN_CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLOSE.Location = new System.Drawing.Point(6, 44);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(92, 36);
            this.BTN_CLOSE.TabIndex = 12;
            this.BTN_CLOSE.Text = "الخروج";
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Image = global::PRODUCT_MANGMENT.Properties.Resources.add1;
            this.BTN_NEW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NEW.Location = new System.Drawing.Point(574, 44);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(104, 36);
            this.BTN_NEW.TabIndex = 11;
            this.BTN_NEW.Text = "صنف جديد";
            this.BTN_NEW.UseVisualStyleBackColor = true;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_form_edit;
            this.BTN_UPDATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_UPDATE.Location = new System.Drawing.Point(104, 44);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(167, 36);
            this.BTN_UPDATE.TabIndex = 10;
            this.BTN_UPDATE.Text = "تعديل الصنف المحدد";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_delete;
            this.BTN_DELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DELETE.Location = new System.Drawing.Point(277, 44);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(151, 36);
            this.BTN_DELETE.TabIndex = 9;
            this.BTN_DELETE.Text = "حذف الصنف المحدد";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.Enabled = false;
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Image = global::PRODUCT_MANGMENT.Properties.Resources.accept;
            this.BTN_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ADD.Location = new System.Drawing.Point(434, 44);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(134, 36);
            this.BTN_ADD.TabIndex = 8;
            this.BTN_ADD.Text = "اضافة الصنف";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // FRM_CATEGORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(708, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_CATEGORY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة ادارة الاصناف";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label LPOZITION;
        public System.Windows.Forms.Button BTN_LAST;
        public System.Windows.Forms.Button BTN_PRIVUSE;
        public System.Windows.Forms.Button BTN_NEXT;
        public System.Windows.Forms.Button BTN_FIRST;
        public System.Windows.Forms.TextBox TXT_DES_CAT;
        public System.Windows.Forms.TextBox TXT_ID_CAT;
        public System.Windows.Forms.Button BTN_CLOSE;
        public System.Windows.Forms.Button BTN_NEW;
        public System.Windows.Forms.Button BTN_UPDATE;
        public System.Windows.Forms.Button BTN_DELETE;
        public System.Windows.Forms.Button BTN_ADD;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}