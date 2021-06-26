namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_BACKUP
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
            this.BTN_BROWS = new System.Windows.Forms.Button();
            this.BTN_BACUP = new System.Windows.Forms.Button();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.TXT_FILE_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // BTN_BROWS
            // 
            this.BTN_BROWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BROWS.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_BROWS.Image = global::PRODUCT_MANGMENT.Properties.Resources.blue_folder_horizontal_open;
            this.BTN_BROWS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_BROWS.Location = new System.Drawing.Point(509, 59);
            this.BTN_BROWS.Name = "BTN_BROWS";
            this.BTN_BROWS.Size = new System.Drawing.Size(86, 36);
            this.BTN_BROWS.TabIndex = 0;
            this.BTN_BROWS.Text = "تحديد";
            this.BTN_BROWS.UseVisualStyleBackColor = true;
            this.BTN_BROWS.Click += new System.EventHandler(this.BTN_BROWS_Click);
            // 
            // BTN_BACUP
            // 
            this.BTN_BACUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BACUP.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_BACUP.Image = global::PRODUCT_MANGMENT.Properties.Resources.add;
            this.BTN_BACUP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_BACUP.Location = new System.Drawing.Point(187, 102);
            this.BTN_BACUP.Name = "BTN_BACUP";
            this.BTN_BACUP.Size = new System.Drawing.Size(184, 31);
            this.BTN_BACUP.TabIndex = 1;
            this.BTN_BACUP.Text = "انشاء النسخة الاحتياطية";
            this.BTN_BACUP.UseVisualStyleBackColor = true;
            this.BTN_BACUP.Click += new System.EventHandler(this.BTN_BACUP_Click);
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.BTN_CLOSE.Image = global::PRODUCT_MANGMENT.Properties.Resources.cancel;
            this.BTN_CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLOSE.Location = new System.Drawing.Point(377, 102);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(126, 31);
            this.BTN_CLOSE.TabIndex = 2;
            this.BTN_CLOSE.Text = "خروج";
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // TXT_FILE_NAME
            // 
            this.TXT_FILE_NAME.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.TXT_FILE_NAME.Location = new System.Drawing.Point(161, 62);
            this.TXT_FILE_NAME.Name = "TXT_FILE_NAME";
            this.TXT_FILE_NAME.ReadOnly = true;
            this.TXT_FILE_NAME.Size = new System.Drawing.Size(342, 34);
            this.TXT_FILE_NAME.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "قم بتحديد مجلد الحفظ";
            // 
            // FRM_BACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(610, 179);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_FILE_NAME);
            this.Controls.Add(this.BTN_CLOSE);
            this.Controls.Add(this.BTN_BACUP);
            this.Controls.Add(this.BTN_BROWS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_BACKUP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة انشاء نسخة احتياطية";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_BROWS;
        private System.Windows.Forms.Button BTN_BACUP;
        private System.Windows.Forms.Button BTN_CLOSE;
        private System.Windows.Forms.TextBox TXT_FILE_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}