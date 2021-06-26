namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_CUSTOMER
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
            this.TXT_PHONE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.TXT_EMAIL = new System.Windows.Forms.TextBox();
            this.TXT_LAST_NAME = new System.Windows.Forms.TextBox();
            this.TXT_FIRST_NAME = new System.Windows.Forms.TextBox();
            this.TXT_ID_CUSTOMER = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TXT_SEARCH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.BTN_UPDATE = new System.Windows.Forms.Button();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_PHONE);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PBOX);
            this.groupBox1.Controls.Add(this.TXT_EMAIL);
            this.groupBox1.Controls.Add(this.TXT_LAST_NAME);
            this.groupBox1.Controls.Add(this.TXT_FIRST_NAME);
            this.groupBox1.Controls.Add(this.TXT_ID_CUSTOMER);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات العميل";
            // 
            // TXT_PHONE
            // 
            this.TXT_PHONE.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_PHONE.Location = new System.Drawing.Point(178, 166);
            this.TXT_PHONE.Name = "TXT_PHONE";
            this.TXT_PHONE.Size = new System.Drawing.Size(157, 34);
            this.TXT_PHONE.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(362, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "رقم الهاتف";
            // 
            // PBOX
            // 
            this.PBOX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PBOX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBOX.Location = new System.Drawing.Point(6, 46);
            this.PBOX.Name = "PBOX";
            this.PBOX.Size = new System.Drawing.Size(166, 194);
            this.PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBOX.TabIndex = 8;
            this.PBOX.TabStop = false;
            this.PBOX.Click += new System.EventHandler(this.PBOX_Click);
            // 
            // TXT_EMAIL
            // 
            this.TXT_EMAIL.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_EMAIL.Location = new System.Drawing.Point(178, 206);
            this.TXT_EMAIL.Name = "TXT_EMAIL";
            this.TXT_EMAIL.Size = new System.Drawing.Size(157, 34);
            this.TXT_EMAIL.TabIndex = 4;
            // 
            // TXT_LAST_NAME
            // 
            this.TXT_LAST_NAME.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_LAST_NAME.Location = new System.Drawing.Point(178, 126);
            this.TXT_LAST_NAME.Name = "TXT_LAST_NAME";
            this.TXT_LAST_NAME.Size = new System.Drawing.Size(157, 34);
            this.TXT_LAST_NAME.TabIndex = 2;
            // 
            // TXT_FIRST_NAME
            // 
            this.TXT_FIRST_NAME.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_FIRST_NAME.Location = new System.Drawing.Point(178, 86);
            this.TXT_FIRST_NAME.Name = "TXT_FIRST_NAME";
            this.TXT_FIRST_NAME.Size = new System.Drawing.Size(157, 34);
            this.TXT_FIRST_NAME.TabIndex = 1;
            // 
            // TXT_ID_CUSTOMER
            // 
            this.TXT_ID_CUSTOMER.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_ID_CUSTOMER.Location = new System.Drawing.Point(178, 46);
            this.TXT_ID_CUSTOMER.Name = "TXT_ID_CUSTOMER";
            this.TXT_ID_CUSTOMER.Size = new System.Drawing.Size(157, 34);
            this.TXT_ID_CUSTOMER.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(341, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "البريد الالكتروني";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(360, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "اسم العائلة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(341, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم الشخصي";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(360, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم العميل";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_SEARCH);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.TXT_SEARCH);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(469, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لائحة العملاء";
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SEARCH.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_SEARCH.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_search_result;
            this.BTN_SEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SEARCH.Location = new System.Drawing.Point(6, 33);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(71, 32);
            this.BTN_SEARCH.TabIndex = 8;
            this.BTN_SEARCH.Text = "بحث";
            this.BTN_SEARCH.UseVisualStyleBackColor = true;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "جديد";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TXT_SEARCH
            // 
            this.TXT_SEARCH.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_SEARCH.Location = new System.Drawing.Point(83, 33);
            this.TXT_SEARCH.Name = "TXT_SEARCH";
            this.TXT_SEARCH.Size = new System.Drawing.Size(222, 34);
            this.TXT_SEARCH.TabIndex = 6;
            this.TXT_SEARCH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_SEARCH_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(311, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "ادخل الكلمة المراد البحث عنها";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(129, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(176, 34);
            this.textBox5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "معرف المعيل";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_CLOSE);
            this.groupBox3.Controls.Add(this.BTN_NEW);
            this.groupBox3.Controls.Add(this.BTN_UPDATE);
            this.groupBox3.Controls.Add(this.BTN_DELETE);
            this.groupBox3.Controls.Add(this.BTN_ADD);
            this.groupBox3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 80);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحة";
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_CLOSE.Image = global::PRODUCT_MANGMENT.Properties.Resources.cancel;
            this.BTN_CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLOSE.Location = new System.Drawing.Point(6, 33);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(92, 34);
            this.BTN_CLOSE.TabIndex = 4;
            this.BTN_CLOSE.Text = "الخروج";
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_NEW.Image = global::PRODUCT_MANGMENT.Properties.Resources.add;
            this.BTN_NEW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NEW.Location = new System.Drawing.Point(365, 33);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(80, 34);
            this.BTN_NEW.TabIndex = 0;
            this.BTN_NEW.Text = "جديد";
            this.BTN_NEW.UseVisualStyleBackColor = true;
            // 
            // BTN_UPDATE
            // 
            this.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UPDATE.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_UPDATE.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_form_edit;
            this.BTN_UPDATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_UPDATE.Location = new System.Drawing.Point(104, 33);
            this.BTN_UPDATE.Name = "BTN_UPDATE";
            this.BTN_UPDATE.Size = new System.Drawing.Size(88, 34);
            this.BTN_UPDATE.TabIndex = 3;
            this.BTN_UPDATE.Text = "تعديل";
            this.BTN_UPDATE.UseVisualStyleBackColor = true;
            this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_DELETE.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_delete;
            this.BTN_DELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DELETE.Location = new System.Drawing.Point(198, 33);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(76, 34);
            this.BTN_DELETE.TabIndex = 2;
            this.BTN_DELETE.Text = "حذف";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_ADD.Image = global::PRODUCT_MANGMENT.Properties.Resources.accept;
            this.BTN_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ADD.Location = new System.Drawing.Point(280, 33);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(79, 34);
            this.BTN_ADD.TabIndex = 1;
            this.BTN_ADD.Text = "اضافة";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.BTN_ADD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(475, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(490, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // FRM_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(983, 422);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FRM_CUSTOMER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة العملاء";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button BTN_CLOSE;
        public System.Windows.Forms.Button BTN_NEW;
        public System.Windows.Forms.Button BTN_UPDATE;
        public System.Windows.Forms.Button BTN_DELETE;
        public System.Windows.Forms.Button BTN_ADD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox PBOX;
        public System.Windows.Forms.TextBox TXT_EMAIL;
        public System.Windows.Forms.TextBox TXT_LAST_NAME;
        public System.Windows.Forms.TextBox TXT_FIRST_NAME;
        public System.Windows.Forms.TextBox TXT_ID_CUSTOMER;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox TXT_SEARCH;
        public System.Windows.Forms.TextBox TXT_PHONE;
        public System.Windows.Forms.Button BTN_SEARCH;
        public System.Windows.Forms.Button button1;
    }
}