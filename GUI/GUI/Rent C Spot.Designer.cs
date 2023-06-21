namespace GUI
{
    partial class Rent_C_Spot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent_C_Spot));
            this.BTnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BnScanRFID = new System.Windows.Forms.Button();
            this.GBxMessage = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBxPossibleSpots = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BnPay = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.LlBalanceTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTnBack
            // 
            this.BTnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnBack.Location = new System.Drawing.Point(147, 11);
            this.BTnBack.Name = "BTnBack";
            this.BTnBack.Size = new System.Drawing.Size(75, 120);
            this.BTnBack.TabIndex = 29;
            this.BTnBack.Text = "Back";
            this.BTnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.BnScanRFID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 133);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RFID Braclet ";
            // 
            // BnScanRFID
            // 
            this.BnScanRFID.Location = new System.Drawing.Point(52, 50);
            this.BnScanRFID.Name = "BnScanRFID";
            this.BnScanRFID.Size = new System.Drawing.Size(108, 32);
            this.BnScanRFID.TabIndex = 7;
            this.BnScanRFID.Text = "Scan RFID";
            this.BnScanRFID.UseVisualStyleBackColor = true;
            this.BnScanRFID.Click += new System.EventHandler(this.BnScanRFID_Click);
            // 
            // GBxMessage
            // 
            this.GBxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.GBxMessage.Location = new System.Drawing.Point(12, 279);
            this.GBxMessage.Name = "GBxMessage";
            this.GBxMessage.Size = new System.Drawing.Size(210, 87);
            this.GBxMessage.TabIndex = 31;
            this.GBxMessage.TabStop = false;
            this.GBxMessage.Text = "Message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // LBxPossibleSpots
            // 
            this.LBxPossibleSpots.FormattingEnabled = true;
            this.LBxPossibleSpots.ItemHeight = 20;
            this.LBxPossibleSpots.Location = new System.Drawing.Point(6, 26);
            this.LBxPossibleSpots.Name = "LBxPossibleSpots";
            this.LBxPossibleSpots.Size = new System.Drawing.Size(467, 224);
            this.LBxPossibleSpots.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.BnPay);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.LlBalanceTotal);
            this.groupBox3.Controls.Add(this.LBxPossibleSpots);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(228, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 354);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Possible Spots";
            // 
            // BnPay
            // 
            this.BnPay.Location = new System.Drawing.Point(222, 279);
            this.BnPay.Name = "BnPay";
            this.BnPay.Size = new System.Drawing.Size(134, 35);
            this.BnPay.TabIndex = 33;
            this.BnPay.Text = "Pay";
            this.BnPay.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Price:";
            // 
            // LlBalanceTotal
            // 
            this.LlBalanceTotal.AutoSize = true;
            this.LlBalanceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlBalanceTotal.Location = new System.Drawing.Point(95, 279);
            this.LlBalanceTotal.Name = "LlBalanceTotal";
            this.LlBalanceTotal.Size = new System.Drawing.Size(90, 29);
            this.LlBalanceTotal.TabIndex = 30;
            this.LlBalanceTotal.Text = "000,00";
            // 
            // Rent_C_Spot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 375);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BTnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBxMessage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Rent_C_Spot";
            this.Text = "Rent_C_Spot";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BnScanRFID;
        private System.Windows.Forms.GroupBox GBxMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox LBxPossibleSpots;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LlBalanceTotal;
        private System.Windows.Forms.Button BnPay;
        private System.Windows.Forms.Label label11;
    }
}