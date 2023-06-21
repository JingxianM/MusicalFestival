namespace GUI
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BTnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnScanRFID = new System.Windows.Forms.Button();
            this.GBxMessage = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbspot = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbstatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbtnr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnAddV = new System.Windows.Forms.Button();
            this.btnScanV = new System.Windows.Forms.Button();
            this.lbxAccLst = new System.Windows.Forms.ListBox();
            this.lbtnrV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GBxMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTnBack
            // 
            this.BTnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnBack.Location = new System.Drawing.Point(147, 12);
            this.BTnBack.Name = "BTnBack";
            this.BTnBack.Size = new System.Drawing.Size(75, 120);
            this.BTnBack.TabIndex = 35;
            this.BTnBack.Text = "Back";
            this.BTnBack.UseVisualStyleBackColor = true;
            this.BTnBack.Click += new System.EventHandler(this.BTnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.BtnScanRFID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 76);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RFID Braclet ";
            // 
            // BtnScanRFID
            // 
            this.BtnScanRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScanRFID.Location = new System.Drawing.Point(51, 26);
            this.BtnScanRFID.Name = "BtnScanRFID";
            this.BtnScanRFID.Size = new System.Drawing.Size(108, 32);
            this.BtnScanRFID.TabIndex = 7;
            this.BtnScanRFID.Text = "Scan RFID";
            this.BtnScanRFID.UseVisualStyleBackColor = true;
            this.BtnScanRFID.Click += new System.EventHandler(this.BtnScanRFID_Click);
            // 
            // GBxMessage
            // 
            this.GBxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.GBxMessage.Controls.Add(this.lblMsg);
            this.GBxMessage.Location = new System.Drawing.Point(12, 380);
            this.GBxMessage.Name = "GBxMessage";
            this.GBxMessage.Size = new System.Drawing.Size(451, 82);
            this.GBxMessage.TabIndex = 37;
            this.GBxMessage.TabStop = false;
            this.GBxMessage.Text = "Message";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(15, 38);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(34, 17);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Msg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.lbspot);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbstatus);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbtnr);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnCheckOut);
            this.groupBox3.Controls.Add(this.btnCheckIn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 155);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // lbspot
            // 
            this.lbspot.AutoSize = true;
            this.lbspot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbspot.Location = new System.Drawing.Point(121, 73);
            this.lbspot.Name = "lbspot";
            this.lbspot.Size = new System.Drawing.Size(38, 17);
            this.lbspot.TabIndex = 19;
            this.lbspot.Text = "******";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "C Spot:";
            // 
            // lbstatus
            // 
            this.lbstatus.AutoSize = true;
            this.lbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstatus.Location = new System.Drawing.Point(121, 50);
            this.lbstatus.Name = "lbstatus";
            this.lbstatus.Size = new System.Drawing.Size(38, 17);
            this.lbstatus.TabIndex = 17;
            this.lbstatus.Text = "******";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Status:";
            // 
            // lbtnr
            // 
            this.lbtnr.AutoSize = true;
            this.lbtnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtnr.Location = new System.Drawing.Point(121, 27);
            this.lbtnr.Name = "lbtnr";
            this.lbtnr.Size = new System.Drawing.Size(38, 17);
            this.lbtnr.TabIndex = 10;
            this.lbtnr.Text = "******";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ticket ID:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(112, 104);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(92, 32);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Enabled = false;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(9, 104);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(92, 32);
            this.btnCheckIn.TabIndex = 7;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lbtnrV);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.BtnAddV);
            this.groupBox4.Controls.Add(this.btnScanV);
            this.groupBox4.Controls.Add(this.lbxAccLst);
            this.groupBox4.Location = new System.Drawing.Point(228, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 362);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AddVisitor";
            // 
            // BtnAddV
            // 
            this.BtnAddV.Enabled = false;
            this.BtnAddV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddV.Location = new System.Drawing.Point(69, 150);
            this.BtnAddV.Name = "BtnAddV";
            this.BtnAddV.Size = new System.Drawing.Size(108, 32);
            this.BtnAddV.TabIndex = 41;
            this.BtnAddV.Text = "Add Visitor";
            this.BtnAddV.UseVisualStyleBackColor = true;
            this.BtnAddV.Click += new System.EventHandler(this.BtnAddV_Click);
            // 
            // btnScanV
            // 
            this.btnScanV.Enabled = false;
            this.btnScanV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanV.Location = new System.Drawing.Point(69, 45);
            this.btnScanV.Name = "btnScanV";
            this.btnScanV.Size = new System.Drawing.Size(108, 32);
            this.btnScanV.TabIndex = 40;
            this.btnScanV.Text = "Scan RFID";
            this.btnScanV.UseVisualStyleBackColor = true;
            this.btnScanV.Click += new System.EventHandler(this.btnScanV_Click);
            // 
            // lbxAccLst
            // 
            this.lbxAccLst.FormattingEnabled = true;
            this.lbxAccLst.ItemHeight = 16;
            this.lbxAccLst.Location = new System.Drawing.Point(5, 224);
            this.lbxAccLst.Name = "lbxAccLst";
            this.lbxAccLst.Size = new System.Drawing.Size(224, 132);
            this.lbxAccLst.TabIndex = 0;
            // 
            // lbtnrV
            // 
            this.lbtnrV.AutoSize = true;
            this.lbtnrV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtnrV.Location = new System.Drawing.Point(122, 104);
            this.lbtnrV.Name = "lbtnrV";
            this.lbtnrV.Size = new System.Drawing.Size(33, 17);
            this.lbtnrV.TabIndex = 43;
            this.lbtnrV.Text = "*****";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Ticket ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "member list:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 472);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BTnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBxMessage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "CheckIn/Out_C_Spot";
            this.groupBox1.ResumeLayout(false);
            this.GBxMessage.ResumeLayout(false);
            this.GBxMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnScanRFID;
        private System.Windows.Forms.GroupBox GBxMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAddV;
        private System.Windows.Forms.Button btnScanV;
        private System.Windows.Forms.ListBox lbxAccLst;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lbtnr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbspot;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbstatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbtnrV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}