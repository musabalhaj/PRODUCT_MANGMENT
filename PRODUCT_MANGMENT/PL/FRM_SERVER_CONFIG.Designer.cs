namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_SERVER_CONFIG
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_SERVER = new System.Windows.Forms.TextBox();
            this.TXT_DATABASE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RB_WINDOWS = new System.Windows.Forms.RadioButton();
            this.RB_SQL = new System.Windows.Forms.RadioButton();
            this.TXT_PWD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم السيرفر";
            // 
            // TXT_SERVER
            // 
            this.TXT_SERVER.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_SERVER.Location = new System.Drawing.Point(155, 29);
            this.TXT_SERVER.Name = "TXT_SERVER";
            this.TXT_SERVER.Size = new System.Drawing.Size(262, 34);
            this.TXT_SERVER.TabIndex = 1;
            // 
            // TXT_DATABASE
            // 
            this.TXT_DATABASE.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_DATABASE.Location = new System.Drawing.Point(155, 68);
            this.TXT_DATABASE.Name = "TXT_DATABASE";
            this.TXT_DATABASE.Size = new System.Drawing.Size(262, 34);
            this.TXT_DATABASE.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم قاعدة البيانات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(107, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "طريقة الدخول";
            // 
            // RB_WINDOWS
            // 
            this.RB_WINDOWS.AutoSize = true;
            this.RB_WINDOWS.Checked = true;
            this.RB_WINDOWS.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_WINDOWS.Location = new System.Drawing.Point(220, 108);
            this.RB_WINDOWS.Name = "RB_WINDOWS";
            this.RB_WINDOWS.Size = new System.Drawing.Size(197, 30);
            this.RB_WINDOWS.TabIndex = 5;
            this.RB_WINDOWS.TabStop = true;
            this.RB_WINDOWS.Text = "windows authentication";
            this.RB_WINDOWS.UseVisualStyleBackColor = true;
            this.RB_WINDOWS.CheckedChanged += new System.EventHandler(this.RB_WINDOWS_CheckedChanged);
            // 
            // RB_SQL
            // 
            this.RB_SQL.AutoSize = true;
            this.RB_SQL.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_SQL.Location = new System.Drawing.Point(221, 143);
            this.RB_SQL.Name = "RB_SQL";
            this.RB_SQL.Size = new System.Drawing.Size(197, 30);
            this.RB_SQL.TabIndex = 6;
            this.RB_SQL.Text = "sql server authintication";
            this.RB_SQL.UseVisualStyleBackColor = true;
            this.RB_SQL.CheckedChanged += new System.EventHandler(this.RB_SQL_CheckedChanged);
            // 
            // TXT_PWD
            // 
            this.TXT_PWD.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_PWD.Location = new System.Drawing.Point(155, 223);
            this.TXT_PWD.Name = "TXT_PWD";
            this.TXT_PWD.ReadOnly = true;
            this.TXT_PWD.Size = new System.Drawing.Size(262, 34);
            this.TXT_PWD.TabIndex = 10;
            this.TXT_PWD.Text = "            ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "كلمة المرور";
            // 
            // TXT_ID
            // 
            this.TXT_ID.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_ID.Location = new System.Drawing.Point(155, 183);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.ReadOnly = true;
            this.TXT_ID.Size = new System.Drawing.Size(262, 34);
            this.TXT_ID.TabIndex = 8;
            this.TXT_ID.Text = "    ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "اسم المستخدم";
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_SAVE.Location = new System.Drawing.Point(155, 263);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(128, 39);
            this.BTN_SAVE.TabIndex = 11;
            this.BTN_SAVE.Text = "حفظ الاعدادات";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_CLOSE.Location = new System.Drawing.Point(289, 263);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(128, 39);
            this.BTN_CLOSE.TabIndex = 12;
            this.BTN_CLOSE.Text = "الخروج";
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // FRM_SERVER_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(451, 342);
            this.Controls.Add(this.BTN_CLOSE);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.TXT_PWD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RB_SQL);
            this.Controls.Add(this.RB_WINDOWS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_DATABASE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_SERVER);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_SERVER_CONFIG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة الاتصال بالسيرفر";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_SERVER;
        private System.Windows.Forms.TextBox TXT_DATABASE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RB_WINDOWS;
        private System.Windows.Forms.RadioButton RB_SQL;
        private System.Windows.Forms.TextBox TXT_PWD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_CLOSE;
    }
}