namespace GUI
{
    partial class SellTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellTicket));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_bind = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.clb_date = new System.Windows.Forms.CheckedListBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TBxBankAcc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.TBxSurName = new System.Windows.Forms.TextBox();
            this.TBxName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sellTicket = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTnBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PriceInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_rfid = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PriceInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.btn_bind);
            this.groupBox1.Controls.Add(this.btn_scan);
            this.groupBox1.Controls.Add(this.clb_date);
            this.groupBox1.Controls.Add(this.tb_pwd);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btn_CheckIn);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TBxBankAcc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtp_dob);
            this.groupBox1.Controls.Add(this.TBxSurName);
            this.groupBox1.Controls.Add(this.TBxName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_sellTicket);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(333, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(476, 517);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sell Ticket";
            // 
            // btn_bind
            // 
            this.btn_bind.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bind.Location = new System.Drawing.Point(10, 450);
            this.btn_bind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_bind.Name = "btn_bind";
            this.btn_bind.Size = new System.Drawing.Size(201, 50);
            this.btn_bind.TabIndex = 48;
            this.btn_bind.Text = "Bind";
            this.btn_bind.UseVisualStyleBackColor = true;
            this.btn_bind.Click += new System.EventHandler(this.btn_bind_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.Location = new System.Drawing.Point(232, 381);
            this.btn_scan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(224, 50);
            this.btn_scan.TabIndex = 47;
            this.btn_scan.Text = "Scan RFID";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click_1);
            // 
            // clb_date
            // 
            this.clb_date.FormattingEnabled = true;
            this.clb_date.Items.AddRange(new object[] {
            "June 27",
            "June 28",
            "June 29"});
            this.clb_date.Location = new System.Drawing.Point(142, 270);
            this.clb_date.Name = "clb_date";
            this.clb_date.Size = new System.Drawing.Size(315, 64);
            this.clb_date.TabIndex = 46;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(142, 225);
            this.tb_pwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(315, 35);
            this.tb_pwd.TabIndex = 45;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(142, 181);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(315, 35);
            this.tb_email.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 227);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 31);
            this.label16.TabIndex = 43;
            this.label16.Text = "Password:";
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckIn.Location = new System.Drawing.Point(232, 449);
            this.btn_CheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(224, 50);
            this.btn_CheckIn.TabIndex = 36;
            this.btn_CheckIn.Text = "Check In";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.Btn_CheckIn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 181);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 31);
            this.label15.TabIndex = 42;
            this.label15.Text = "Email:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 300);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 31);
            this.label14.TabIndex = 38;
            this.label14.Text = "Date: ";
            // 
            // TBxBankAcc
            // 
            this.TBxBankAcc.Location = new System.Drawing.Point(142, 141);
            this.TBxBankAcc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBxBankAcc.Name = "TBxBankAcc";
            this.TBxBankAcc.Size = new System.Drawing.Size(315, 35);
            this.TBxBankAcc.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 140);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 31);
            this.label13.TabIndex = 34;
            this.label13.Text = "Bank Acc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 31);
            this.label12.TabIndex = 33;
            this.label12.Text = "DoB:";
            // 
            // dtp_dob
            // 
            this.dtp_dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dob.Location = new System.Drawing.Point(142, 104);
            this.dtp_dob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(315, 29);
            this.dtp_dob.TabIndex = 32;
            // 
            // TBxSurName
            // 
            this.TBxSurName.Location = new System.Drawing.Point(142, 62);
            this.TBxSurName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBxSurName.Name = "TBxSurName";
            this.TBxSurName.Size = new System.Drawing.Size(315, 35);
            this.TBxSurName.TabIndex = 16;
            // 
            // TBxName
            // 
            this.TBxName.Location = new System.Drawing.Point(142, 24);
            this.TBxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBxName.Name = "TBxName";
            this.TBxName.Size = new System.Drawing.Size(315, 35);
            this.TBxName.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 63);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 31);
            this.label10.TabIndex = 14;
            this.label10.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
            // 
            // btn_sellTicket
            // 
            this.btn_sellTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sellTicket.Location = new System.Drawing.Point(9, 381);
            this.btn_sellTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sellTicket.Name = "btn_sellTicket";
            this.btn_sellTicket.Size = new System.Drawing.Size(202, 50);
            this.btn_sellTicket.TabIndex = 12;
            this.btn_sellTicket.Text = "Sell Ticket";
            this.btn_sellTicket.UseVisualStyleBackColor = true;
            this.btn_sellTicket.Click += new System.EventHandler(this.BnSellTicket_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // BTnBack
            // 
            this.BTnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnBack.Location = new System.Drawing.Point(158, 9);
            this.BTnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTnBack.Name = "BTnBack";
            this.BTnBack.Size = new System.Drawing.Size(163, 118);
            this.BTnBack.TabIndex = 17;
            this.BTnBack.Text = "Back";
            this.BTnBack.UseVisualStyleBackColor = true;
            this.BTnBack.Click += new System.EventHandler(this.BTnBack_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // PriceInfo
            // 
            this.PriceInfo.BackColor = System.Drawing.SystemColors.Control;
            this.PriceInfo.Controls.Add(this.label4);
            this.PriceInfo.Controls.Add(this.label2);
            this.PriceInfo.Controls.Add(this.label1);
            this.PriceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceInfo.Location = new System.Drawing.Point(25, 141);
            this.PriceInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceInfo.Name = "PriceInfo";
            this.PriceInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PriceInfo.Size = new System.Drawing.Size(296, 145);
            this.PriceInfo.TabIndex = 23;
            this.PriceInfo.TabStop = false;
            this.PriceInfo.Text = "PriceInfo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Three Days： € 79";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Two Days： €65";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "One Day: €45";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lb_rfid);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 306);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(294, 91);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RFID";
            // 
            // lb_rfid
            // 
            this.lb_rfid.AutoSize = true;
            this.lb_rfid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_rfid.Location = new System.Drawing.Point(31, 37);
            this.lb_rfid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rfid.Name = "lb_rfid";
            this.lb_rfid.Size = new System.Drawing.Size(72, 26);
            this.lb_rfid.TabIndex = 0;
            this.lb_rfid.Text = "          ";
            // 
            // lb_message
            // 
            this.lb_message.BackColor = System.Drawing.SystemColors.Control;
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.FormattingEnabled = true;
            this.lb_message.ItemHeight = 26;
            this.lb_message.Location = new System.Drawing.Point(26, 416);
            this.lb_message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(295, 108);
            this.lb_message.TabIndex = 25;
            // 
            // SellTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 534);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PriceInfo);
            this.Controls.Add(this.BTnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SellTicket";
            this.Text = "SellTicket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PriceInfo.ResumeLayout(false);
            this.PriceInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBxSurName;
        private System.Windows.Forms.TextBox TBxName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sellTicket;
        private System.Windows.Forms.Button BTnBack;
        private System.Windows.Forms.TextBox TBxBankAcc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckedListBox clb_date;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.Button btn_bind;
        private System.Windows.Forms.GroupBox PriceInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_rfid;
        private System.Windows.Forms.ListBox lb_message;
    }
}