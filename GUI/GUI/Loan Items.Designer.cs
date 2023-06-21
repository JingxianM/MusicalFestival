namespace GUI
{
    partial class Loan_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan_Items));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_days = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.l_total = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_itemId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.l_deposit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.lb_selectedItems = new System.Windows.Forms.ListBox();
            this.BnLoan = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.BTnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BnScanRFID = new System.Windows.Forms.Button();
            this.GBxInformation = new System.Windows.Forms.GroupBox();
            this.lb_age = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_balance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Rfid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ticketId = new System.Windows.Forms.Label();
            this.lb_fname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_message = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.cb_days);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.l_total);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tb_itemId);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.l_deposit);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cb_item);
            this.groupBox3.Controls.Add(this.lb_selectedItems);
            this.groupBox3.Controls.Add(this.BnLoan);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lb_price);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(344, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(369, 345);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items to Loan";
            // 
            // cb_days
            // 
            this.cb_days.FormattingEnabled = true;
            this.cb_days.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_days.Location = new System.Drawing.Point(134, 80);
            this.cb_days.Margin = new System.Windows.Forms.Padding(2);
            this.cb_days.Name = "cb_days";
            this.cb_days.Size = new System.Drawing.Size(107, 25);
            this.cb_days.TabIndex = 53;
            this.cb_days.SelectedIndexChanged += new System.EventHandler(this.Cb_days_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(71, 80);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 17);
            this.label18.TabIndex = 49;
            this.label18.Text = "Days:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(185, 310);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 24);
            this.label17.TabIndex = 48;
            this.label17.Text = "€";
            // 
            // l_total
            // 
            this.l_total.AutoSize = true;
            this.l_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_total.Location = new System.Drawing.Point(110, 313);
            this.l_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(71, 24);
            this.l_total.TabIndex = 47;
            this.l_total.Text = "000,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 317);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 17);
            this.label15.TabIndex = 46;
            this.label15.Text = "Total:";
            // 
            // tb_itemId
            // 
            this.tb_itemId.Location = new System.Drawing.Point(134, 112);
            this.tb_itemId.Name = "tb_itemId";
            this.tb_itemId.Size = new System.Drawing.Size(107, 23);
            this.tb_itemId.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Item Id:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(185, 285);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 24);
            this.label13.TabIndex = 43;
            this.label13.Text = "€";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(185, 261);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 24);
            this.label12.TabIndex = 42;
            this.label12.Text = "€";
            // 
            // l_deposit
            // 
            this.l_deposit.AutoSize = true;
            this.l_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_deposit.Location = new System.Drawing.Point(110, 261);
            this.l_deposit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_deposit.Name = "l_deposit";
            this.l_deposit.Size = new System.Drawing.Size(71, 24);
            this.l_deposit.TabIndex = 41;
            this.l_deposit.Text = "000,00";
            this.l_deposit.Click += new System.EventHandler(this.Label12_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 261);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Deposit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Item:";
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Items.AddRange(new object[] {
            "FlashLight",
            "Power Bank",
            "Glowing Bracelet"});
            this.cb_item.Location = new System.Drawing.Point(134, 37);
            this.cb_item.Margin = new System.Windows.Forms.Padding(2);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(107, 25);
            this.cb_item.TabIndex = 36;
            this.cb_item.SelectedIndexChanged += new System.EventHandler(this.Cb_item_SelectedIndexChanged);
            // 
            // lb_selectedItems
            // 
            this.lb_selectedItems.FormattingEnabled = true;
            this.lb_selectedItems.ItemHeight = 17;
            this.lb_selectedItems.Location = new System.Drawing.Point(4, 141);
            this.lb_selectedItems.Margin = new System.Windows.Forms.Padding(2);
            this.lb_selectedItems.Name = "lb_selectedItems";
            this.lb_selectedItems.Size = new System.Drawing.Size(361, 106);
            this.lb_selectedItems.TabIndex = 35;
            // 
            // BnLoan
            // 
            this.BnLoan.Location = new System.Drawing.Point(252, 297);
            this.BnLoan.Margin = new System.Windows.Forms.Padding(2);
            this.BnLoan.Name = "BnLoan";
            this.BnLoan.Size = new System.Drawing.Size(100, 28);
            this.BnLoan.TabIndex = 33;
            this.BnLoan.Text = "Loan";
            this.BnLoan.UseVisualStyleBackColor = true;
            this.BnLoan.Click += new System.EventHandler(this.BnLoan_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 288);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Price per day:";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(110, 288);
            this.lb_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(71, 24);
            this.lb_price.TabIndex = 30;
            this.lb_price.Text = "000,00";
            this.lb_price.Click += new System.EventHandler(this.L_price_Click);
            // 
            // BTnBack
            // 
            this.BTnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnBack.Location = new System.Drawing.Point(110, 9);
            this.BTnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BTnBack.Name = "BTnBack";
            this.BTnBack.Size = new System.Drawing.Size(56, 98);
            this.BTnBack.TabIndex = 43;
            this.BTnBack.Text = "Back";
            this.BTnBack.UseVisualStyleBackColor = true;
            this.BTnBack.Click += new System.EventHandler(this.BTnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.BnScanRFID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(158, 113);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RFID Braclet ";
            // 
            // BnScanRFID
            // 
            this.BnScanRFID.Location = new System.Drawing.Point(39, 45);
            this.BnScanRFID.Margin = new System.Windows.Forms.Padding(2);
            this.BnScanRFID.Name = "BnScanRFID";
            this.BnScanRFID.Size = new System.Drawing.Size(81, 26);
            this.BnScanRFID.TabIndex = 7;
            this.BnScanRFID.Text = "Scan RFID";
            this.BnScanRFID.UseVisualStyleBackColor = true;
            this.BnScanRFID.Click += new System.EventHandler(this.BnScanRFID_Click);
            // 
            // GBxInformation
            // 
            this.GBxInformation.BackColor = System.Drawing.SystemColors.Control;
            this.GBxInformation.Controls.Add(this.lb_age);
            this.GBxInformation.Controls.Add(this.label3);
            this.GBxInformation.Controls.Add(this.lb_status);
            this.GBxInformation.Controls.Add(this.label8);
            this.GBxInformation.Controls.Add(this.lb_balance);
            this.GBxInformation.Controls.Add(this.label7);
            this.GBxInformation.Controls.Add(this.lb_Rfid);
            this.GBxInformation.Controls.Add(this.label6);
            this.GBxInformation.Controls.Add(this.lb_lname);
            this.GBxInformation.Controls.Add(this.label5);
            this.GBxInformation.Controls.Add(this.lb_ticketId);
            this.GBxInformation.Controls.Add(this.lb_fname);
            this.GBxInformation.Controls.Add(this.label2);
            this.GBxInformation.Controls.Add(this.label1);
            this.GBxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBxInformation.Location = new System.Drawing.Point(173, 10);
            this.GBxInformation.Margin = new System.Windows.Forms.Padding(2);
            this.GBxInformation.Name = "GBxInformation";
            this.GBxInformation.Padding = new System.Windows.Forms.Padding(2);
            this.GBxInformation.Size = new System.Drawing.Size(166, 217);
            this.GBxInformation.TabIndex = 46;
            this.GBxInformation.TabStop = false;
            this.GBxInformation.Text = "Guest\'s Info";
            // 
            // lb_age
            // 
            this.lb_age.AutoSize = true;
            this.lb_age.Location = new System.Drawing.Point(94, 198);
            this.lb_age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_age.Name = "lb_age";
            this.lb_age.Size = new System.Drawing.Size(24, 17);
            this.lb_age.TabIndex = 15;
            this.lb_age.Text = "18";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Age:";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(78, 171);
            this.lb_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(67, 17);
            this.lb_status.TabIndex = 13;
            this.lb_status.Text = "Checked ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status:";
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Location = new System.Drawing.Point(87, 141);
            this.lb_balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(38, 17);
            this.lb_balance.TabIndex = 11;
            this.lb_balance.Text = "******";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Balance:";
            // 
            // lb_Rfid
            // 
            this.lb_Rfid.AutoSize = true;
            this.lb_Rfid.Location = new System.Drawing.Point(87, 115);
            this.lb_Rfid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Rfid.Name = "lb_Rfid";
            this.lb_Rfid.Size = new System.Drawing.Size(38, 17);
            this.lb_Rfid.TabIndex = 9;
            this.lb_Rfid.Text = "******";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "RFID Num:";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.Location = new System.Drawing.Point(64, 51);
            this.lb_lname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(116, 17);
            this.lb_lname.TabIndex = 7;
            this.lb_lname.Text = "Visitor\'s surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Surname:";
            // 
            // lb_ticketId
            // 
            this.lb_ticketId.AutoSize = true;
            this.lb_ticketId.Location = new System.Drawing.Point(87, 83);
            this.lb_ticketId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ticketId.Name = "lb_ticketId";
            this.lb_ticketId.Size = new System.Drawing.Size(64, 17);
            this.lb_ticketId.TabIndex = 5;
            this.lb_ticketId.Text = "2222222";
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.Location = new System.Drawing.Point(64, 19);
            this.lb_fname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(96, 17);
            this.lb_fname.TabIndex = 4;
            this.lb_fname.Text = "Visitor\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ticket ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // lb_message
            // 
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.FormattingEnabled = true;
            this.lb_message.ItemHeight = 24;
            this.lb_message.Location = new System.Drawing.Point(9, 232);
            this.lb_message.Margin = new System.Windows.Forms.Padding(2);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(331, 124);
            this.lb_message.TabIndex = 42;
            // 
            // Loan_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 366);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BTnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBxInformation);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Loan_Items";
            this.Text = "Loan_Items";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.GBxInformation.ResumeLayout(false);
            this.GBxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lb_selectedItems;
        private System.Windows.Forms.Button BnLoan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Button BTnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BnScanRFID;
        private System.Windows.Forms.GroupBox GBxInformation;
        private System.Windows.Forms.Label lb_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_Rfid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_lname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ticketId;
        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_deposit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.ListBox lb_message;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_itemId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_days;
    }
}