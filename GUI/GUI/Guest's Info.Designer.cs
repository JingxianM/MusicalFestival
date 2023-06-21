namespace GUI
{
    partial class Guest_s_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_s_Info));
            this.BTnBack = new System.Windows.Forms.Button();
            this.GBxInformation = new System.Windows.Forms.GroupBox();
            this.lb_message = new System.Windows.Forms.ListBox();
            this.BuyingHistory = new System.Windows.Forms.ListBox();
            this.LoaningHistory = new System.Windows.Forms.ListBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_balance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_dob = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_fname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_ticketId = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.GBxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTnBack
            // 
            this.BTnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnBack.Location = new System.Drawing.Point(236, 6);
            this.BTnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BTnBack.Name = "BTnBack";
            this.BTnBack.Size = new System.Drawing.Size(147, 72);
            this.BTnBack.TabIndex = 24;
            this.BTnBack.Text = "Back";
            this.BTnBack.UseVisualStyleBackColor = true;
            this.BTnBack.Click += new System.EventHandler(this.BTnBack_Click);
            // 
            // GBxInformation
            // 
            this.GBxInformation.BackColor = System.Drawing.SystemColors.Control;
            this.GBxInformation.Controls.Add(this.lb_message);
            this.GBxInformation.Controls.Add(this.BuyingHistory);
            this.GBxInformation.Controls.Add(this.LoaningHistory);
            this.GBxInformation.Controls.Add(this.lb_status);
            this.GBxInformation.Controls.Add(this.label8);
            this.GBxInformation.Controls.Add(this.lb_balance);
            this.GBxInformation.Controls.Add(this.label7);
            this.GBxInformation.Controls.Add(this.lb_dob);
            this.GBxInformation.Controls.Add(this.label6);
            this.GBxInformation.Controls.Add(this.lb_fname);
            this.GBxInformation.Controls.Add(this.label5);
            this.GBxInformation.Controls.Add(this.lb_ticketId);
            this.GBxInformation.Controls.Add(this.lb_lname);
            this.GBxInformation.Controls.Add(this.label2);
            this.GBxInformation.Controls.Add(this.label1);
            this.GBxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBxInformation.Location = new System.Drawing.Point(11, 107);
            this.GBxInformation.Margin = new System.Windows.Forms.Padding(2);
            this.GBxInformation.Name = "GBxInformation";
            this.GBxInformation.Padding = new System.Windows.Forms.Padding(2);
            this.GBxInformation.Size = new System.Drawing.Size(896, 373);
            this.GBxInformation.TabIndex = 28;
            this.GBxInformation.TabStop = false;
            this.GBxInformation.Enter += new System.EventHandler(this.GBxInformation_Enter);
            // 
            // lb_message
            // 
            this.lb_message.FormattingEnabled = true;
            this.lb_message.ItemHeight = 29;
            this.lb_message.Location = new System.Drawing.Point(475, 212);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(381, 149);
            this.lb_message.TabIndex = 16;
            // 
            // BuyingHistory
            // 
            this.BuyingHistory.FormattingEnabled = true;
            this.BuyingHistory.ItemHeight = 29;
            this.BuyingHistory.Location = new System.Drawing.Point(475, 20);
            this.BuyingHistory.Margin = new System.Windows.Forms.Padding(2);
            this.BuyingHistory.Name = "BuyingHistory";
            this.BuyingHistory.Size = new System.Drawing.Size(381, 149);
            this.BuyingHistory.TabIndex = 15;
            this.BuyingHistory.SelectedIndexChanged += new System.EventHandler(this.BuyingHistory_SelectedIndexChanged);
            // 
            // LoaningHistory
            // 
            this.LoaningHistory.FormattingEnabled = true;
            this.LoaningHistory.ItemHeight = 29;
            this.LoaningHistory.Location = new System.Drawing.Point(4, 212);
            this.LoaningHistory.Margin = new System.Windows.Forms.Padding(2);
            this.LoaningHistory.Name = "LoaningHistory";
            this.LoaningHistory.Size = new System.Drawing.Size(409, 149);
            this.LoaningHistory.TabIndex = 14;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(173, 173);
            this.lb_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(115, 29);
            this.lb_status.TabIndex = 13;
            this.lb_status.Text = "Checked ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status:";
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Location = new System.Drawing.Point(173, 144);
            this.lb_balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(73, 29);
            this.lb_balance.TabIndex = 11;
            this.lb_balance.Text = "******";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Balance:";
            // 
            // lb_dob
            // 
            this.lb_dob.AutoSize = true;
            this.lb_dob.Location = new System.Drawing.Point(188, 112);
            this.lb_dob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_dob.Name = "lb_dob";
            this.lb_dob.Size = new System.Drawing.Size(131, 29);
            this.lb_dob.TabIndex = 9;
            this.lb_dob.Text = "01/01/1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "DoB";
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.Location = new System.Drawing.Point(157, 48);
            this.lb_fname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(195, 29);
            this.lb_fname.TabIndex = 7;
            this.lb_fname.Text = "Visitor\'s surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Surname:";
            // 
            // lb_ticketId
            // 
            this.lb_ticketId.AutoSize = true;
            this.lb_ticketId.Location = new System.Drawing.Point(204, 83);
            this.lb_ticketId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ticketId.Name = "lb_ticketId";
            this.lb_ticketId.Size = new System.Drawing.Size(73, 29);
            this.lb_ticketId.TabIndex = 5;
            this.lb_ticketId.Text = "******";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.Location = new System.Drawing.Point(173, 19);
            this.lb_lname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(162, 29);
            this.lb_lname.TabIndex = 4;
            this.lb_lname.Text = "Visitor\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ticket ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btn_scan
            // 
            this.btn_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scan.Location = new System.Drawing.Point(760, 6);
            this.btn_scan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(147, 72);
            this.btn_scan.TabIndex = 29;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.Btn_scan_Click);
            // 
            // Guest_s_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 491);
            this.Controls.Add(this.btn_scan);
            this.Controls.Add(this.BTnBack);
            this.Controls.Add(this.GBxInformation);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Guest_s_Info";
            this.Text = "Guest_s_Info";
            this.GBxInformation.ResumeLayout(false);
            this.GBxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTnBack;
        private System.Windows.Forms.GroupBox GBxInformation;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_ticketId;
        private System.Windows.Forms.Label lb_lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox BuyingHistory;
        private System.Windows.Forms.ListBox LoaningHistory;
        private System.Windows.Forms.Label lb_dob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lb_message;
        private System.Windows.Forms.Button btn_scan;
    }
}