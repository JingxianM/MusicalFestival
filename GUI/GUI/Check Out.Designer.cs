namespace GUI
{
    partial class Check_Out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Out));
            this.BTnBack = new System.Windows.Forms.Button();
            this.BnScanRFID = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.l_email = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_spot = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_Rfid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ticketId = new System.Windows.Forms.Label();
            this.lb_fname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BnCheckOut = new System.Windows.Forms.Button();
            this.lb_balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.ListBox();
            this.lb_borrowed_items = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTnBack
            // 
            this.BTnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnBack.Location = new System.Drawing.Point(137, 9);
            this.BTnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BTnBack.Name = "BTnBack";
            this.BTnBack.Size = new System.Drawing.Size(157, 48);
            this.BTnBack.TabIndex = 29;
            this.BTnBack.Text = "Back";
            this.BTnBack.UseVisualStyleBackColor = true;
            this.BTnBack.Click += new System.EventHandler(this.BTnBack_Click);
            // 
            // BnScanRFID
            // 
            this.BnScanRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnScanRFID.Location = new System.Drawing.Point(137, 61);
            this.BnScanRFID.Margin = new System.Windows.Forms.Padding(2);
            this.BnScanRFID.Name = "BnScanRFID";
            this.BnScanRFID.Size = new System.Drawing.Size(157, 49);
            this.BnScanRFID.TabIndex = 7;
            this.BnScanRFID.Text = "Scan RFID";
            this.BnScanRFID.UseVisualStyleBackColor = true;
            this.BnScanRFID.Click += new System.EventHandler(this.BnScanRFID_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.l_email);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lb_spot);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lb_status);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lb_Rfid);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lb_lname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_ticketId);
            this.groupBox2.Controls.Add(this.lb_fname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(321, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(450, 315);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(145, 84);
            this.l_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(130, 31);
            this.l_email.TabIndex = 41;
            this.l_email.Text = "b@b.com";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 31);
            this.label10.TabIndex = 40;
            this.label10.Text = "Email:";
            // 
            // lb_spot
            // 
            this.lb_spot.AutoSize = true;
            this.lb_spot.Location = new System.Drawing.Point(152, 266);
            this.lb_spot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_spot.Name = "lb_spot";
            this.lb_spot.Size = new System.Drawing.Size(92, 31);
            this.lb_spot.TabIndex = 39;
            this.lb_spot.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 31);
            this.label9.TabIndex = 38;
            this.label9.Text = "C Spot:";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(146, 218);
            this.lb_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(129, 31);
            this.lb_status.TabIndex = 37;
            this.lb_status.Text = "Checked ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 31);
            this.label8.TabIndex = 36;
            this.label8.Text = "Status:";
            // 
            // lb_Rfid
            // 
            this.lb_Rfid.AutoSize = true;
            this.lb_Rfid.Location = new System.Drawing.Point(176, 172);
            this.lb_Rfid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Rfid.Name = "lb_Rfid";
            this.lb_Rfid.Size = new System.Drawing.Size(29, 31);
            this.lb_Rfid.TabIndex = 33;
            this.lb_Rfid.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "RFID Num:";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.Location = new System.Drawing.Point(127, 48);
            this.lb_lname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(221, 31);
            this.lb_lname.TabIndex = 31;
            this.lb_lname.Text = "Visitor\'s surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "Surname:";
            // 
            // lb_ticketId
            // 
            this.lb_ticketId.AutoSize = true;
            this.lb_ticketId.Location = new System.Drawing.Point(176, 126);
            this.lb_ticketId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ticketId.Name = "lb_ticketId";
            this.lb_ticketId.Size = new System.Drawing.Size(80, 31);
            this.lb_ticketId.TabIndex = 29;
            this.lb_ticketId.Text = "******";
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.Location = new System.Drawing.Point(113, 15);
            this.lb_fname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(183, 31);
            this.lb_fname.TabIndex = 28;
            this.lb_fname.Text = "Visitor\'s name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ticket ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.BnCheckOut);
            this.groupBox3.Controls.Add(this.lb_balance);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 333);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(304, 82);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(202, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 24);
            this.label12.TabIndex = 43;
            this.label12.Text = "€";
            // 
            // BnCheckOut
            // 
            this.BnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnCheckOut.Location = new System.Drawing.Point(42, 42);
            this.BnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.BnCheckOut.Name = "BnCheckOut";
            this.BnCheckOut.Size = new System.Drawing.Size(190, 36);
            this.BnCheckOut.TabIndex = 31;
            this.BnCheckOut.Text = "Check Out";
            this.BnCheckOut.UseVisualStyleBackColor = true;
            this.BnCheckOut.Click += new System.EventHandler(this.BnCheckOut_Click);
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_balance.Location = new System.Drawing.Point(127, 19);
            this.lb_balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(71, 24);
            this.lb_balance.TabIndex = 29;
            this.lb_balance.Text = "000,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Balance:";
            // 
            // lb_message
            // 
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.FormattingEnabled = true;
            this.lb_message.ItemHeight = 31;
            this.lb_message.Location = new System.Drawing.Point(320, 328);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(450, 97);
            this.lb_message.TabIndex = 0;
            // 
            // lb_borrowed_items
            // 
            this.lb_borrowed_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_borrowed_items.FormattingEnabled = true;
            this.lb_borrowed_items.ItemHeight = 29;
            this.lb_borrowed_items.Location = new System.Drawing.Point(5, 116);
            this.lb_borrowed_items.Name = "lb_borrowed_items";
            this.lb_borrowed_items.Size = new System.Drawing.Size(310, 207);
            this.lb_borrowed_items.TabIndex = 36;
            // 
            // Check_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 426);
            this.Controls.Add(this.lb_borrowed_items);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.BnScanRFID);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTnBack);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Check_Out";
            this.Text = "Check_Out";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTnBack;
        private System.Windows.Forms.Button BnScanRFID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_spot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_Rfid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_lname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ticketId;
        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BnCheckOut;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lb_message;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lb_borrowed_items;
    }
}