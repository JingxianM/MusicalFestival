namespace GUI
{
    partial class CheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxTktnr = new System.Windows.Forms.TextBox();
            this.btnbind = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BnCheckIn = new System.Windows.Forms.Button();
            this.BnScanRFID = new System.Windows.Forms.Button();
            this.BtnVerifyTkt = new System.Windows.Forms.Button();
            this.GBxMessage = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.GBxInformation = new System.Windows.Forms.GroupBox();
            this.lbspot = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbbalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbrfid2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbsurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbtnr2 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTnBack = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.GBxMessage.SuspendLayout();
            this.GBxInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.tbxTktnr);
            this.groupBox1.Controls.Add(this.btnbind);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BnCheckIn);
            this.groupBox1.Controls.Add(this.BnScanRFID);
            this.groupBox1.Controls.Add(this.BtnVerifyTkt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(197, 243);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Guest";
            // 
            // tbxTktnr
            // 
            this.tbxTktnr.Location = new System.Drawing.Point(67, 33);
            this.tbxTktnr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxTktnr.Name = "tbxTktnr";
            this.tbxTktnr.Size = new System.Drawing.Size(103, 23);
            this.tbxTktnr.TabIndex = 14;
            
            // 
            // btnbind
            // 
            this.btnbind.Enabled = false;
            this.btnbind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbind.Location = new System.Drawing.Point(14, 160);
            this.btnbind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnbind.Name = "btnbind";
            this.btnbind.Size = new System.Drawing.Size(172, 24);
            this.btnbind.TabIndex = 13;
            this.btnbind.Text = "Bind";
            this.btnbind.UseVisualStyleBackColor = true;
            this.btnbind.Click += new System.EventHandler(this.btnbind_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ticket ID:";
            // 
            // BnCheckIn
            // 
            this.BnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnCheckIn.Location = new System.Drawing.Point(14, 201);
            this.BnCheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BnCheckIn.Name = "BnCheckIn";
            this.BnCheckIn.Size = new System.Drawing.Size(172, 25);
            this.BnCheckIn.TabIndex = 8;
            this.BnCheckIn.Text = "Check In";
            this.BnCheckIn.UseVisualStyleBackColor = true;
            this.BnCheckIn.Click += new System.EventHandler(this.BnCheckIn_Click);
            // 
            // BnScanRFID
            // 
            this.BnScanRFID.Enabled = false;
            this.BnScanRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnScanRFID.Location = new System.Drawing.Point(14, 117);
            this.BnScanRFID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BnScanRFID.Name = "BnScanRFID";
            this.BnScanRFID.Size = new System.Drawing.Size(171, 26);
            this.BnScanRFID.TabIndex = 7;
            this.BnScanRFID.Text = "Scan RFID";
            this.BnScanRFID.UseVisualStyleBackColor = true;
            this.BnScanRFID.Click += new System.EventHandler(this.BnScanRFID_Click);
            // 
            // BtnVerifyTkt
            // 
            this.BtnVerifyTkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerifyTkt.Location = new System.Drawing.Point(14, 76);
            this.BtnVerifyTkt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVerifyTkt.Name = "BtnVerifyTkt";
            this.BtnVerifyTkt.Size = new System.Drawing.Size(172, 26);
            this.BtnVerifyTkt.TabIndex = 1;
            this.BtnVerifyTkt.Text = "Verify Ticket";
            this.BtnVerifyTkt.UseVisualStyleBackColor = true;
            this.BtnVerifyTkt.Click += new System.EventHandler(this.BtnVerifyTkt_Click);
            // 
            // GBxMessage
            // 
            this.GBxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.GBxMessage.Controls.Add(this.lblMsg);
            this.GBxMessage.Location = new System.Drawing.Point(220, 239);
            this.GBxMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBxMessage.Name = "GBxMessage";
            this.GBxMessage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBxMessage.Size = new System.Drawing.Size(170, 118);
            this.GBxMessage.TabIndex = 16;
            this.GBxMessage.TabStop = false;
            this.GBxMessage.Text = "Message";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(17, 49);
            this.lblMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(27, 13);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Msg";
            // 
            // GBxInformation
            // 
            this.GBxInformation.BackColor = System.Drawing.SystemColors.Control;
            this.GBxInformation.Controls.Add(this.lbspot);
            this.GBxInformation.Controls.Add(this.label9);
            this.GBxInformation.Controls.Add(this.lbstatus);
            this.GBxInformation.Controls.Add(this.label8);
            this.GBxInformation.Controls.Add(this.lbbalance);
            this.GBxInformation.Controls.Add(this.label7);
            this.GBxInformation.Controls.Add(this.lbrfid2);
            this.GBxInformation.Controls.Add(this.label6);
            this.GBxInformation.Controls.Add(this.lbsurname);
            this.GBxInformation.Controls.Add(this.label5);
            this.GBxInformation.Controls.Add(this.lbtnr2);
            this.GBxInformation.Controls.Add(this.lbname);
            this.GBxInformation.Controls.Add(this.label2);
            this.GBxInformation.Controls.Add(this.label1);
            this.GBxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBxInformation.Location = new System.Drawing.Point(220, 11);
            this.GBxInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBxInformation.Name = "GBxInformation";
            this.GBxInformation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GBxInformation.Size = new System.Drawing.Size(170, 225);
            this.GBxInformation.TabIndex = 15;
            this.GBxInformation.TabStop = false;
            // 
            // lbspot
            // 
            this.lbspot.AutoSize = true;
            this.lbspot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbspot.Location = new System.Drawing.Point(78, 198);
            this.lbspot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbspot.Name = "lbspot";
            this.lbspot.Size = new System.Drawing.Size(31, 13);
            this.lbspot.TabIndex = 15;
            this.lbspot.Text = "******";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "C Spot:";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Location = new System.Drawing.Point(78, 169);
            this.lbstatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(31, 13);
            this.lbstatus.TabIndex = 13;
            this.lbstatus.Text = "******";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status:";
            // 
            // lbbalance
            // 
            this.lbbalance.AutoSize = true;
            this.lbbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbalance.Location = new System.Drawing.Point(78, 141);
            this.lbbalance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbbalance.Name = "lbbalance";
            this.lbbalance.Size = new System.Drawing.Size(31, 13);
            this.lbbalance.TabIndex = 11;
            this.lbbalance.Text = "******";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Balance:";
            // 
            // lbrfid2
            // 
            this.lbrfid2.AutoSize = true;
            this.lbrfid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrfid2.Location = new System.Drawing.Point(78, 109);
            this.lbrfid2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbrfid2.Name = "lbrfid2";
            this.lbrfid2.Size = new System.Drawing.Size(31, 13);
            this.lbrfid2.TabIndex = 9;
            this.lbrfid2.Text = "******";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "RFID Num:";
            // 
            // lbsurname
            // 
            this.lbsurname.AutoSize = true;
            this.lbsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsurname.Location = new System.Drawing.Point(78, 50);
            this.lbsurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbsurname.Name = "lbsurname";
            this.lbsurname.Size = new System.Drawing.Size(31, 13);
            this.lbsurname.TabIndex = 7;
            this.lbsurname.Text = "******";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Surname:";
            // 
            // lbtnr2
            // 
            this.lbtnr2.AutoSize = true;
            this.lbtnr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtnr2.Location = new System.Drawing.Point(78, 78);
            this.lbtnr2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtnr2.Name = "lbtnr2";
            this.lbtnr2.Size = new System.Drawing.Size(31, 13);
            this.lbtnr2.TabIndex = 5;
            this.lbtnr2.Text = "******";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(78, 22);
            this.lbname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(31, 13);
            this.lbname.TabIndex = 4;
            this.lbname.Text = "******";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ticket ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BTnBack
            // 
            this.BTnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnBack.Location = new System.Drawing.Point(113, 11);
            this.BTnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTnBack.Name = "BTnBack";
            this.BTnBack.Size = new System.Drawing.Size(94, 99);
            this.BTnBack.TabIndex = 14;
            this.BTnBack.Text = "Back";
            this.BTnBack.UseVisualStyleBackColor = true;
            this.BTnBack.Click += new System.EventHandler(this.BTnBack_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(397, 361);
            this.Controls.Add(this.BTnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBxMessage);
            this.Controls.Add(this.GBxInformation);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBxMessage.ResumeLayout(false);
            this.GBxMessage.PerformLayout();
            this.GBxInformation.ResumeLayout(false);
            this.GBxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BnCheckIn;
        private System.Windows.Forms.Button BnScanRFID;
        private System.Windows.Forms.Button BtnVerifyTkt;
        private System.Windows.Forms.GroupBox GBxMessage;
        private System.Windows.Forms.GroupBox GBxInformation;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbbalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbrfid2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbsurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbspot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BTnBack;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnbind;
        private System.Windows.Forms.Label lbtnr2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox tbxTktnr;
    }
}