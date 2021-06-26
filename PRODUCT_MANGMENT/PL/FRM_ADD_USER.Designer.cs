namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_ADD_USER
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
            this.TXT_RPWD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMB_USERTYPE = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_FULLNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_PWD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.BTN_ADD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_RPWD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CMB_USERTYPE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_FULLNAME);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_PWD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل المستخدم";
            // 
            // TXT_RPWD
            // 
            this.TXT_RPWD.Location = new System.Drawing.Point(23, 133);
            this.TXT_RPWD.Name = "TXT_RPWD";
            this.TXT_RPWD.PasswordChar = '*';
            this.TXT_RPWD.Size = new System.Drawing.Size(206, 34);
            this.TXT_RPWD.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "تأكيد كلمة المرور";
            // 
            // CMB_USERTYPE
            // 
            this.CMB_USERTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_USERTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CMB_USERTYPE.FormattingEnabled = true;
            this.CMB_USERTYPE.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.CMB_USERTYPE.Location = new System.Drawing.Point(23, 213);
            this.CMB_USERTYPE.Name = "CMB_USERTYPE";
            this.CMB_USERTYPE.Size = new System.Drawing.Size(206, 33);
            this.CMB_USERTYPE.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "نوع المستخدم";
            // 
            // TXT_FULLNAME
            // 
            this.TXT_FULLNAME.Location = new System.Drawing.Point(23, 173);
            this.TXT_FULLNAME.Name = "TXT_FULLNAME";
            this.TXT_FULLNAME.Size = new System.Drawing.Size(206, 34);
            this.TXT_FULLNAME.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "الاسم الكامل";
            // 
            // TXT_PWD
            // 
            this.TXT_PWD.Location = new System.Drawing.Point(23, 93);
            this.TXT_PWD.Name = "TXT_PWD";
            this.TXT_PWD.PasswordChar = '*';
            this.TXT_PWD.Size = new System.Drawing.Size(206, 34);
            this.TXT_PWD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة المرور ";
            // 
            // TXT_ID
            // 
            this.TXT_ID.Location = new System.Drawing.Point(23, 53);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(206, 34);
            this.TXT_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_CLOSE);
            this.groupBox2.Controls.Add(this.BTN_ADD);
            this.groupBox2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE.Image = global::PRODUCT_MANGMENT.Properties.Resources.cancel;
            this.BTN_CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLOSE.Location = new System.Drawing.Point(23, 31);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(114, 42);
            this.BTN_CLOSE.TabIndex = 1;
            this.BTN_CLOSE.Text = "الغاء";
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_ADD
            // 
            this.BTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ADD.Image = global::PRODUCT_MANGMENT.Properties.Resources.add;
            this.BTN_ADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ADD.Location = new System.Drawing.Point(143, 31);
            this.BTN_ADD.Name = "BTN_ADD";
            this.BTN_ADD.Size = new System.Drawing.Size(114, 42);
            this.BTN_ADD.TabIndex = 0;
            this.BTN_ADD.Text = "اضافة";
            this.BTN_ADD.UseVisualStyleBackColor = true;
            this.BTN_ADD.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRM_ADD_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(401, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_USER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة اضافة مستخدم جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CMB_USERTYPE;
        public System.Windows.Forms.TextBox TXT_FULLNAME;
        public System.Windows.Forms.TextBox TXT_PWD;
        public System.Windows.Forms.TextBox TXT_ID;
        public System.Windows.Forms.Button BTN_CLOSE;
        public System.Windows.Forms.Button BTN_ADD;
        public System.Windows.Forms.TextBox TXT_RPWD;
    }
}