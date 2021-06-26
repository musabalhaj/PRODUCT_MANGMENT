namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_ADD_PRODUCT
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
            this.button1 = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_qte = new System.Windows.Forms.TextBox();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmd_cat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Chocolate;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_qte);
            this.groupBox1.Controls.Add(this.txt_des);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmd_cat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(470, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات المنتج";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::PRODUCT_MANGMENT.Properties.Resources.blue_folder_horizontal_open;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 356);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "تحديد ملف الصورة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbox
            // 
            this.pbox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbox.Location = new System.Drawing.Point(16, 268);
            this.pbox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(192, 82);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 9;
            this.pbox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "صورة المنتج";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(16, 228);
            this.txt_price.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(192, 34);
            this.txt_price.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "ثمن المنتج";
            // 
            // txt_qte
            // 
            this.txt_qte.Location = new System.Drawing.Point(16, 183);
            this.txt_qte.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_qte.Name = "txt_qte";
            this.txt_qte.Size = new System.Drawing.Size(192, 34);
            this.txt_qte.TabIndex = 2;
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(16, 113);
            this.txt_des.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_des.Size = new System.Drawing.Size(192, 63);
            this.txt_des.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "كمية المنتج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "وصف المنتج";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(16, 74);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(192, 34);
            this.txt_id.TabIndex = 0;
            this.txt_id.Validated += new System.EventHandler(this.txt_id_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "معرف المنتج";
            // 
            // cmd_cat
            // 
            this.cmd_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmd_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmd_cat.FormattingEnabled = true;
            this.cmd_cat.Location = new System.Drawing.Point(16, 35);
            this.cmd_cat.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmd_cat.Name = "cmd_cat";
            this.cmd_cat.Size = new System.Drawing.Size(192, 33);
            this.cmd_cat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "صنف المنتج";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 412);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox2.Size = new System.Drawing.Size(470, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العمليات المتاحة";
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = global::PRODUCT_MANGMENT.Properties.Resources.add;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(124, 35);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 33);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "اضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = global::PRODUCT_MANGMENT.Properties.Resources.cancel;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(16, 35);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(86, 33);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "الغاء";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FRM_ADD_PRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(494, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ADD_PRODUCT";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة منتج جديد";
            this.Load += new System.EventHandler(this.FRM_ADD_PRODUCT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox txt_des;
        public System.Windows.Forms.TextBox txt_id;
        public System.Windows.Forms.ComboBox cmd_cat;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pbox;
        public System.Windows.Forms.TextBox txt_price;
        public System.Windows.Forms.TextBox txt_qte;
    }
}