namespace PRODUCT_MANGMENT.PL
{
    partial class FRM_ORDER
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_DATE_ORDER = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_SELMAN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_DES_ORDER = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_ID_ORDER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_CUSTOMER_VIWE = new System.Windows.Forms.Button();
            this.TXT_PHONE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PBOX = new System.Windows.Forms.PictureBox();
            this.TXT_EMAIL = new System.Windows.Forms.TextBox();
            this.TXT_LAST_NAME = new System.Windows.Forms.TextBox();
            this.TXT_FIRST_NAME = new System.Windows.Forms.TextBox();
            this.TXT_ID_CUSTOMER = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TXT_NET_AMOUNT = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_DESCOUNT = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TXT_AMOUNT = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TXT_QTE = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXT_PRICE = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TXT_DES_PRODUCT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXT_ID_PRODUCT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BTN_PRODUCT_VIWE = new System.Windows.Forms.Button();
            this.BTN_DELETE_SELECTED_ROW = new System.Windows.Forms.Button();
            this.TXT_TOTAL_AMOUNT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DGV_PRODUCT = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالسطرالحاليToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالكلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_CLOSE = new System.Windows.Forms.Button();
            this.BTN_PRINT = new System.Windows.Forms.Button();
            this.BTN_SAVE = new System.Windows.Forms.Button();
            this.BTN_NEW = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_DATE_ORDER);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXT_SELMAN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXT_DES_ORDER);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_ID_ORDER);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة";
            // 
            // TXT_DATE_ORDER
            // 
            this.TXT_DATE_ORDER.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TXT_DATE_ORDER.Location = new System.Drawing.Point(54, 128);
            this.TXT_DATE_ORDER.Name = "TXT_DATE_ORDER";
            this.TXT_DATE_ORDER.Size = new System.Drawing.Size(216, 20);
            this.TXT_DATE_ORDER.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "تاريخ البيع";
            // 
            // TXT_SELMAN
            // 
            this.TXT_SELMAN.Location = new System.Drawing.Point(54, 154);
            this.TXT_SELMAN.Name = "TXT_SELMAN";
            this.TXT_SELMAN.ReadOnly = true;
            this.TXT_SELMAN.Size = new System.Drawing.Size(217, 20);
            this.TXT_SELMAN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "اسم البائع";
            // 
            // TXT_DES_ORDER
            // 
            this.TXT_DES_ORDER.Location = new System.Drawing.Point(54, 52);
            this.TXT_DES_ORDER.Multiline = true;
            this.TXT_DES_ORDER.Name = "TXT_DES_ORDER";
            this.TXT_DES_ORDER.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_DES_ORDER.Size = new System.Drawing.Size(216, 70);
            this.TXT_DES_ORDER.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "وصف الفاتورة";
            // 
            // TXT_ID_ORDER
            // 
            this.TXT_ID_ORDER.Location = new System.Drawing.Point(174, 26);
            this.TXT_ID_ORDER.Name = "TXT_ID_ORDER";
            this.TXT_ID_ORDER.ReadOnly = true;
            this.TXT_ID_ORDER.Size = new System.Drawing.Size(96, 20);
            this.TXT_ID_ORDER.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_CUSTOMER_VIWE);
            this.groupBox2.Controls.Add(this.TXT_PHONE);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PBOX);
            this.groupBox2.Controls.Add(this.TXT_EMAIL);
            this.groupBox2.Controls.Add(this.TXT_LAST_NAME);
            this.groupBox2.Controls.Add(this.TXT_FIRST_NAME);
            this.groupBox2.Controls.Add(this.TXT_ID_CUSTOMER);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(400, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل";
            // 
            // BTN_CUSTOMER_VIWE
            // 
            this.BTN_CUSTOMER_VIWE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CUSTOMER_VIWE.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_search_result;
            this.BTN_CUSTOMER_VIWE.Location = new System.Drawing.Point(178, 17);
            this.BTN_CUSTOMER_VIWE.Name = "BTN_CUSTOMER_VIWE";
            this.BTN_CUSTOMER_VIWE.Size = new System.Drawing.Size(54, 23);
            this.BTN_CUSTOMER_VIWE.TabIndex = 17;
            this.BTN_CUSTOMER_VIWE.Text = ". . .";
            this.BTN_CUSTOMER_VIWE.UseVisualStyleBackColor = true;
            this.BTN_CUSTOMER_VIWE.Click += new System.EventHandler(this.BTN_CUSTOMER_VIWE_Click);
            // 
            // TXT_PHONE
            // 
            this.TXT_PHONE.Location = new System.Drawing.Point(178, 128);
            this.TXT_PHONE.Name = "TXT_PHONE";
            this.TXT_PHONE.ReadOnly = true;
            this.TXT_PHONE.Size = new System.Drawing.Size(176, 20);
            this.TXT_PHONE.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "رقم الهاتف";
            // 
            // PBOX
            // 
            this.PBOX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PBOX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBOX.Location = new System.Drawing.Point(6, 19);
            this.PBOX.Name = "PBOX";
            this.PBOX.Size = new System.Drawing.Size(166, 170);
            this.PBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBOX.TabIndex = 8;
            this.PBOX.TabStop = false;
            // 
            // TXT_EMAIL
            // 
            this.TXT_EMAIL.Location = new System.Drawing.Point(178, 169);
            this.TXT_EMAIL.Name = "TXT_EMAIL";
            this.TXT_EMAIL.ReadOnly = true;
            this.TXT_EMAIL.Size = new System.Drawing.Size(176, 20);
            this.TXT_EMAIL.TabIndex = 4;
            // 
            // TXT_LAST_NAME
            // 
            this.TXT_LAST_NAME.Location = new System.Drawing.Point(178, 91);
            this.TXT_LAST_NAME.Name = "TXT_LAST_NAME";
            this.TXT_LAST_NAME.ReadOnly = true;
            this.TXT_LAST_NAME.Size = new System.Drawing.Size(176, 20);
            this.TXT_LAST_NAME.TabIndex = 2;
            // 
            // TXT_FIRST_NAME
            // 
            this.TXT_FIRST_NAME.Location = new System.Drawing.Point(178, 55);
            this.TXT_FIRST_NAME.Name = "TXT_FIRST_NAME";
            this.TXT_FIRST_NAME.ReadOnly = true;
            this.TXT_FIRST_NAME.Size = new System.Drawing.Size(176, 20);
            this.TXT_FIRST_NAME.TabIndex = 1;
            // 
            // TXT_ID_CUSTOMER
            // 
            this.TXT_ID_CUSTOMER.Location = new System.Drawing.Point(238, 19);
            this.TXT_ID_CUSTOMER.Name = "TXT_ID_CUSTOMER";
            this.TXT_ID_CUSTOMER.ReadOnly = true;
            this.TXT_ID_CUSTOMER.Size = new System.Drawing.Size(116, 20);
            this.TXT_ID_CUSTOMER.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "البريد الالكتروني";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "اسم العائلة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "الاسم الشخصي";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "رقم العميل";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.TXT_NET_AMOUNT);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.TXT_DESCOUNT);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.TXT_AMOUNT);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.TXT_QTE);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.TXT_PRICE);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.TXT_DES_PRODUCT);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TXT_ID_PRODUCT);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.BTN_PRODUCT_VIWE);
            this.groupBox3.Controls.Add(this.BTN_DELETE_SELECTED_ROW);
            this.groupBox3.Controls.Add(this.TXT_TOTAL_AMOUNT);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.DGV_PRODUCT);
            this.groupBox3.Location = new System.Drawing.Point(12, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات";
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(734, 16);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(3);
            this.label18.Size = new System.Drawing.Size(99, 26);
            this.label18.TabIndex = 49;
            this.label18.Text = "اختيار المنتج";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_NET_AMOUNT
            // 
            this.TXT_NET_AMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_NET_AMOUNT.Location = new System.Drawing.Point(6, 45);
            this.TXT_NET_AMOUNT.Name = "TXT_NET_AMOUNT";
            this.TXT_NET_AMOUNT.ReadOnly = true;
            this.TXT_NET_AMOUNT.Size = new System.Drawing.Size(119, 20);
            this.TXT_NET_AMOUNT.TabIndex = 48;
            this.TXT_NET_AMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(3);
            this.label17.Size = new System.Drawing.Size(119, 26);
            this.label17.TabIndex = 47;
            this.label17.Text = "الاجمالي";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DESCOUNT
            // 
            this.TXT_DESCOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_DESCOUNT.Location = new System.Drawing.Point(121, 45);
            this.TXT_DESCOUNT.MaxLength = 3;
            this.TXT_DESCOUNT.Name = "TXT_DESCOUNT";
            this.TXT_DESCOUNT.Size = new System.Drawing.Size(93, 20);
            this.TXT_DESCOUNT.TabIndex = 46;
            this.TXT_DESCOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_DESCOUNT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_DESCOUNT_KeyDown);
            this.TXT_DESCOUNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DESCOUNT_KeyPress);
            this.TXT_DESCOUNT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_DESCOUNT_KeyUp);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(121, 16);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(3);
            this.label15.Size = new System.Drawing.Size(93, 26);
            this.label15.TabIndex = 45;
            this.label15.Text = "الخصم";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_AMOUNT
            // 
            this.TXT_AMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_AMOUNT.Location = new System.Drawing.Point(209, 45);
            this.TXT_AMOUNT.Name = "TXT_AMOUNT";
            this.TXT_AMOUNT.ReadOnly = true;
            this.TXT_AMOUNT.Size = new System.Drawing.Size(87, 20);
            this.TXT_AMOUNT.TabIndex = 44;
            this.TXT_AMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(209, 16);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(3);
            this.label16.Size = new System.Drawing.Size(87, 26);
            this.label16.TabIndex = 43;
            this.label16.Text = "المبلغ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_QTE
            // 
            this.TXT_QTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_QTE.Location = new System.Drawing.Point(294, 45);
            this.TXT_QTE.MaxLength = 8;
            this.TXT_QTE.Name = "TXT_QTE";
            this.TXT_QTE.Size = new System.Drawing.Size(88, 20);
            this.TXT_QTE.TabIndex = 42;
            this.TXT_QTE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_QTE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_QTE_KeyDown);
            this.TXT_QTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_QTE_KeyPress);
            this.TXT_QTE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_QTE_KeyUp);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(294, 16);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(3);
            this.label13.Size = new System.Drawing.Size(88, 26);
            this.label13.TabIndex = 41;
            this.label13.Text = "الكمية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_PRICE.Location = new System.Drawing.Point(378, 45);
            this.TXT_PRICE.MaxLength = 8;
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Size = new System.Drawing.Size(120, 20);
            this.TXT_PRICE.TabIndex = 40;
            this.TXT_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_PRICE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_PRICE_KeyDown);
            this.TXT_PRICE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_PRICE_KeyPress);
            this.TXT_PRICE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXT_PRICE_KeyUp);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(378, 16);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(3);
            this.label14.Size = new System.Drawing.Size(120, 26);
            this.label14.TabIndex = 39;
            this.label14.Text = "الثمن";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_DES_PRODUCT
            // 
            this.TXT_DES_PRODUCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_DES_PRODUCT.Location = new System.Drawing.Point(491, 45);
            this.TXT_DES_PRODUCT.Name = "TXT_DES_PRODUCT";
            this.TXT_DES_PRODUCT.ReadOnly = true;
            this.TXT_DES_PRODUCT.Size = new System.Drawing.Size(143, 20);
            this.TXT_DES_PRODUCT.TabIndex = 38;
            this.TXT_DES_PRODUCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(491, 16);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(3);
            this.label12.Size = new System.Drawing.Size(143, 26);
            this.label12.TabIndex = 37;
            this.label12.Text = "اسم المنتج";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_ID_PRODUCT
            // 
            this.TXT_ID_PRODUCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ID_PRODUCT.Location = new System.Drawing.Point(631, 45);
            this.TXT_ID_PRODUCT.Name = "TXT_ID_PRODUCT";
            this.TXT_ID_PRODUCT.ReadOnly = true;
            this.TXT_ID_PRODUCT.Size = new System.Drawing.Size(105, 20);
            this.TXT_ID_PRODUCT.TabIndex = 36;
            this.TXT_ID_PRODUCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(631, 16);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(3);
            this.label11.Size = new System.Drawing.Size(105, 26);
            this.label11.TabIndex = 35;
            this.label11.Text = "معرف المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_PRODUCT_VIWE
            // 
            this.BTN_PRODUCT_VIWE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_PRODUCT_VIWE.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_search_result;
            this.BTN_PRODUCT_VIWE.Location = new System.Drawing.Point(734, 45);
            this.BTN_PRODUCT_VIWE.Name = "BTN_PRODUCT_VIWE";
            this.BTN_PRODUCT_VIWE.Size = new System.Drawing.Size(99, 20);
            this.BTN_PRODUCT_VIWE.TabIndex = 34;
            this.BTN_PRODUCT_VIWE.Text = ". . . ";
            this.BTN_PRODUCT_VIWE.UseVisualStyleBackColor = true;
            this.BTN_PRODUCT_VIWE.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_DELETE_SELECTED_ROW
            // 
            this.BTN_DELETE_SELECTED_ROW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_DELETE_SELECTED_ROW.Image = global::PRODUCT_MANGMENT.Properties.Resources.application_delete;
            this.BTN_DELETE_SELECTED_ROW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DELETE_SELECTED_ROW.Location = new System.Drawing.Point(667, 187);
            this.BTN_DELETE_SELECTED_ROW.Name = "BTN_DELETE_SELECTED_ROW";
            this.BTN_DELETE_SELECTED_ROW.Size = new System.Drawing.Size(166, 23);
            this.BTN_DELETE_SELECTED_ROW.TabIndex = 18;
            this.BTN_DELETE_SELECTED_ROW.Text = "حذف السطر المحدد";
            this.BTN_DELETE_SELECTED_ROW.UseVisualStyleBackColor = true;
            this.BTN_DELETE_SELECTED_ROW.Click += new System.EventHandler(this.BTN_DELETE_SELECTED_ROW_Click);
            // 
            // TXT_TOTAL_AMOUNT
            // 
            this.TXT_TOTAL_AMOUNT.Location = new System.Drawing.Point(6, 189);
            this.TXT_TOTAL_AMOUNT.Name = "TXT_TOTAL_AMOUNT";
            this.TXT_TOTAL_AMOUNT.ReadOnly = true;
            this.TXT_TOTAL_AMOUNT.Size = new System.Drawing.Size(217, 20);
            this.TXT_TOTAL_AMOUNT.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "المجموع";
            // 
            // DGV_PRODUCT
            // 
            this.DGV_PRODUCT.AllowUserToOrderColumns = true;
            this.DGV_PRODUCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_PRODUCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PRODUCT.ColumnHeadersVisible = false;
            this.DGV_PRODUCT.ContextMenuStrip = this.contextMenuStrip1;
            this.DGV_PRODUCT.Location = new System.Drawing.Point(6, 71);
            this.DGV_PRODUCT.MultiSelect = false;
            this.DGV_PRODUCT.Name = "DGV_PRODUCT";
            this.DGV_PRODUCT.ReadOnly = true;
            this.DGV_PRODUCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_PRODUCT.Size = new System.Drawing.Size(827, 112);
            this.DGV_PRODUCT.TabIndex = 0;
            this.DGV_PRODUCT.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV_PRODUCT_RowsRemoved);
            this.DGV_PRODUCT.DoubleClick += new System.EventHandler(this.DGV_PRODUCT_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.toolStripSeparator1,
            this.حذفالسطرالحاليToolStripMenuItem,
            this.toolStripSeparator2,
            this.حذفالكلToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 82);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // حذفالسطرالحاليToolStripMenuItem
            // 
            this.حذفالسطرالحاليToolStripMenuItem.Name = "حذفالسطرالحاليToolStripMenuItem";
            this.حذفالسطرالحاليToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.حذفالسطرالحاليToolStripMenuItem.Text = "حذف السطر الحالي";
            this.حذفالسطرالحاليToolStripMenuItem.Click += new System.EventHandler(this.حذفالسطرالحاليToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // حذفالكلToolStripMenuItem
            // 
            this.حذفالكلToolStripMenuItem.Name = "حذفالكلToolStripMenuItem";
            this.حذفالكلToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.حذفالكلToolStripMenuItem.Text = "حذف الكل";
            this.حذفالكلToolStripMenuItem.Click += new System.EventHandler(this.حذفالكلToolStripMenuItem_Click);
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLOSE.Image = global::PRODUCT_MANGMENT.Properties.Resources.cancel;
            this.BTN_CLOSE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLOSE.Location = new System.Drawing.Point(606, 445);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(166, 23);
            this.BTN_CLOSE.TabIndex = 22;
            this.BTN_CLOSE.Text = "الخروج";
            this.BTN_CLOSE.UseVisualStyleBackColor = true;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // BTN_PRINT
            // 
            this.BTN_PRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRINT.Image = global::PRODUCT_MANGMENT.Properties.Resources.blue_document_code;
            this.BTN_PRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_PRINT.Location = new System.Drawing.Point(434, 445);
            this.BTN_PRINT.Name = "BTN_PRINT";
            this.BTN_PRINT.Size = new System.Drawing.Size(166, 23);
            this.BTN_PRINT.TabIndex = 21;
            this.BTN_PRINT.Text = "طباعة الفاتورة";
            this.BTN_PRINT.UseVisualStyleBackColor = true;
            // 
            // BTN_SAVE
            // 
            this.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SAVE.Image = global::PRODUCT_MANGMENT.Properties.Resources.accept;
            this.BTN_SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SAVE.Location = new System.Drawing.Point(262, 445);
            this.BTN_SAVE.Name = "BTN_SAVE";
            this.BTN_SAVE.Size = new System.Drawing.Size(166, 23);
            this.BTN_SAVE.TabIndex = 20;
            this.BTN_SAVE.Text = "حفظ المبيعة";
            this.BTN_SAVE.UseVisualStyleBackColor = true;
            this.BTN_SAVE.Click += new System.EventHandler(this.BTN_SAVE_Click);
            // 
            // BTN_NEW
            // 
            this.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW.Image = global::PRODUCT_MANGMENT.Properties.Resources.add;
            this.BTN_NEW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NEW.Location = new System.Drawing.Point(90, 445);
            this.BTN_NEW.Name = "BTN_NEW";
            this.BTN_NEW.Size = new System.Drawing.Size(166, 23);
            this.BTN_NEW.TabIndex = 19;
            this.BTN_NEW.Text = "مبيعة جديدة";
            this.BTN_NEW.UseVisualStyleBackColor = true;
            this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
            // 
            // FRM_ORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(859, 487);
            this.Controls.Add(this.BTN_CLOSE);
            this.Controls.Add(this.BTN_PRINT);
            this.Controls.Add(this.BTN_SAVE);
            this.Controls.Add(this.BTN_NEW);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDER";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نافذة البيع";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBOX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PRODUCT)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker TXT_DATE_ORDER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_SELMAN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_DES_ORDER;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_ID_ORDER;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox TXT_PHONE;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox PBOX;
        public System.Windows.Forms.TextBox TXT_EMAIL;
        public System.Windows.Forms.TextBox TXT_LAST_NAME;
        public System.Windows.Forms.TextBox TXT_FIRST_NAME;
        public System.Windows.Forms.TextBox TXT_ID_CUSTOMER;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTN_CUSTOMER_VIWE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_DELETE_SELECTED_ROW;
        private System.Windows.Forms.TextBox TXT_TOTAL_AMOUNT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DGV_PRODUCT;
        private System.Windows.Forms.Button BTN_NEW;
        private System.Windows.Forms.Button BTN_SAVE;
        private System.Windows.Forms.Button BTN_CLOSE;
        private System.Windows.Forms.Button BTN_PRINT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TXT_NET_AMOUNT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXT_DESCOUNT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXT_AMOUNT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXT_QTE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXT_PRICE;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXT_DES_PRODUCT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXT_ID_PRODUCT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BTN_PRODUCT_VIWE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem حذفالسطرالحاليToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem حذفالكلToolStripMenuItem;
    }
}