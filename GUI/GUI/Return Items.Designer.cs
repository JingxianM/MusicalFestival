namespace GUI
{
    partial class Return_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return_Items));
            this.BTnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BnScanRFID = new System.Windows.Forms.Button();
            this.GBxInformation = new System.Windows.Forms.GroupBox();
            this.LlAge = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LlBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LlRfidChecked = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LlSurname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LlID = new System.Windows.Forms.Label();
            this.LlName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GBxMessage = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BnPriceToPay = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.LlPriceToPay = new System.Windows.Forms.Label();
            this.LBxLoanedItems = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TBxDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RBnDamaged = new System.Windows.Forms.RadioButton();
            this.RBnNotDamaged = new System.Windows.Forms.RadioButton();
            this.LBxItemsToReturn = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.GBxInformation.SuspendLayout();
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
            this.BTnBack.TabIndex = 49;
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
            this.groupBox1.Size = new System.Drawing.Size(210, 139);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RFID Braclet ";
            // 
            // BnScanRFID
            // 
            this.BnScanRFID.Location = new System.Drawing.Point(52, 55);
            this.BnScanRFID.Name = "BnScanRFID";
            this.BnScanRFID.Size = new System.Drawing.Size(108, 32);
            this.BnScanRFID.TabIndex = 7;
            this.BnScanRFID.Text = "Scan RFID";
            this.BnScanRFID.UseVisualStyleBackColor = true;
            this.BnScanRFID.Click += new System.EventHandler(this.BnScanRFID_Click);
            // 
            // GBxInformation
            // 
            this.GBxInformation.BackColor = System.Drawing.SystemColors.Control;
            this.GBxInformation.Controls.Add(this.LlAge);
            this.GBxInformation.Controls.Add(this.label3);
            this.GBxInformation.Controls.Add(this.LStatus);
            this.GBxInformation.Controls.Add(this.label8);
            this.GBxInformation.Controls.Add(this.LlBalance);
            this.GBxInformation.Controls.Add(this.label7);
            this.GBxInformation.Controls.Add(this.LlRfidChecked);
            this.GBxInformation.Controls.Add(this.label6);
            this.GBxInformation.Controls.Add(this.LlSurname);
            this.GBxInformation.Controls.Add(this.label5);
            this.GBxInformation.Controls.Add(this.LlID);
            this.GBxInformation.Controls.Add(this.LlName);
            this.GBxInformation.Controls.Add(this.label2);
            this.GBxInformation.Controls.Add(this.label1);
            this.GBxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBxInformation.Location = new System.Drawing.Point(231, 12);
            this.GBxInformation.Name = "GBxInformation";
            this.GBxInformation.Size = new System.Drawing.Size(222, 267);
            this.GBxInformation.TabIndex = 52;
            this.GBxInformation.TabStop = false;
            this.GBxInformation.Text = "Guest\'s Info";
            // 
            // LlAge
            // 
            this.LlAge.AutoSize = true;
            this.LlAge.Location = new System.Drawing.Point(125, 244);
            this.LlAge.Name = "LlAge";
            this.LlAge.Size = new System.Drawing.Size(27, 20);
            this.LlAge.TabIndex = 15;
            this.LlAge.Text = "18";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Age:";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(104, 210);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(79, 20);
            this.LStatus.TabIndex = 13;
            this.LStatus.Text = "Checked ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status:";
            // 
            // LlBalance
            // 
            this.LlBalance.AutoSize = true;
            this.LlBalance.Location = new System.Drawing.Point(116, 174);
            this.LlBalance.Name = "LlBalance";
            this.LlBalance.Size = new System.Drawing.Size(45, 20);
            this.LlBalance.TabIndex = 11;
            this.LlBalance.Text = "******";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Balance:";
            // 
            // LlRfidChecked
            // 
            this.LlRfidChecked.AutoSize = true;
            this.LlRfidChecked.Location = new System.Drawing.Point(116, 141);
            this.LlRfidChecked.Name = "LlRfidChecked";
            this.LlRfidChecked.Size = new System.Drawing.Size(45, 20);
            this.LlRfidChecked.TabIndex = 9;
            this.LlRfidChecked.Text = "******";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "RFID Num:";
            // 
            // LlSurname
            // 
            this.LlSurname.AutoSize = true;
            this.LlSurname.Location = new System.Drawing.Point(86, 63);
            this.LlSurname.Name = "LlSurname";
            this.LlSurname.Size = new System.Drawing.Size(140, 20);
            this.LlSurname.TabIndex = 7;
            this.LlSurname.Text = "Visitor\'s surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Surname:";
            // 
            // LlID
            // 
            this.LlID.AutoSize = true;
            this.LlID.Location = new System.Drawing.Point(116, 102);
            this.LlID.Name = "LlID";
            this.LlID.Size = new System.Drawing.Size(45, 20);
            this.LlID.TabIndex = 5;
            this.LlID.Text = "******";
            // 
            // LlName
            // 
            this.LlName.AutoSize = true;
            this.LlName.Location = new System.Drawing.Point(86, 23);
            this.LlName.Name = "LlName";
            this.LlName.Size = new System.Drawing.Size(116, 20);
            this.LlName.TabIndex = 4;
            this.LlName.Text = "Visitor\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ticket ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // GBxMessage
            // 
            this.GBxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.GBxMessage.Location = new System.Drawing.Point(12, 285);
            this.GBxMessage.Name = "GBxMessage";
            this.GBxMessage.Size = new System.Drawing.Size(441, 153);
            this.GBxMessage.TabIndex = 51;
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
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // BnPriceToPay
            // 
            this.BnPriceToPay.Location = new System.Drawing.Point(334, 376);
            this.BnPriceToPay.Name = "BnPriceToPay";
            this.BnPriceToPay.Size = new System.Drawing.Size(134, 35);
            this.BnPriceToPay.TabIndex = 33;
            this.BnPriceToPay.Text = "Pay";
            this.BnPriceToPay.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "Total Price:";
            // 
            // LlPriceToPay
            // 
            this.LlPriceToPay.AutoSize = true;
            this.LlPriceToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlPriceToPay.Location = new System.Drawing.Point(173, 382);
            this.LlPriceToPay.Name = "LlPriceToPay";
            this.LlPriceToPay.Size = new System.Drawing.Size(90, 29);
            this.LlPriceToPay.TabIndex = 30;
            this.LlPriceToPay.Text = "000,00";
            // 
            // LBxLoanedItems
            // 
            this.LBxLoanedItems.FormattingEnabled = true;
            this.LBxLoanedItems.ItemHeight = 20;
            this.LBxLoanedItems.Location = new System.Drawing.Point(6, 26);
            this.LBxLoanedItems.Name = "LBxLoanedItems";
            this.LBxLoanedItems.Size = new System.Drawing.Size(480, 104);
            this.LBxLoanedItems.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.TBxDescription);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.RBnDamaged);
            this.groupBox3.Controls.Add(this.RBnNotDamaged);
            this.groupBox3.Controls.Add(this.LBxItemsToReturn);
            this.groupBox3.Controls.Add(this.BnPriceToPay);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.LlPriceToPay);
            this.groupBox3.Controls.Add(this.LBxLoanedItems);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(459, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(492, 425);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items to Loan";
            // 
            // TBxDescription
            // 
            this.TBxDescription.Location = new System.Drawing.Point(23, 306);
            this.TBxDescription.Name = "TBxDescription";
            this.TBxDescription.Size = new System.Drawing.Size(445, 27);
            this.TBxDescription.TabIndex = 41;
            this.TBxDescription.Tag = "";
            this.TBxDescription.Text = "DMGDescription";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(173, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 29);
            this.label9.TabIndex = 40;
            this.label9.Text = "000,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Deposit to return:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(355, 261);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(100, 24);
            this.radioButton1.TabIndex = 38;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Unusable";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RBnDamaged
            // 
            this.RBnDamaged.AutoSize = true;
            this.RBnDamaged.Location = new System.Drawing.Point(181, 261);
            this.RBnDamaged.Name = "RBnDamaged";
            this.RBnDamaged.Size = new System.Drawing.Size(102, 24);
            this.RBnDamaged.TabIndex = 37;
            this.RBnDamaged.TabStop = true;
            this.RBnDamaged.Text = "Damaged";
            this.RBnDamaged.UseVisualStyleBackColor = true;
            // 
            // RBnNotDamaged
            // 
            this.RBnNotDamaged.AutoSize = true;
            this.RBnNotDamaged.Location = new System.Drawing.Point(23, 261);
            this.RBnNotDamaged.Name = "RBnNotDamaged";
            this.RBnNotDamaged.Size = new System.Drawing.Size(133, 24);
            this.RBnNotDamaged.TabIndex = 36;
            this.RBnNotDamaged.TabStop = true;
            this.RBnNotDamaged.Text = "Not Damaged";
            this.RBnNotDamaged.UseVisualStyleBackColor = true;
            // 
            // LBxItemsToReturn
            // 
            this.LBxItemsToReturn.FormattingEnabled = true;
            this.LBxItemsToReturn.ItemHeight = 20;
            this.LBxItemsToReturn.Location = new System.Drawing.Point(6, 141);
            this.LBxItemsToReturn.Name = "LBxItemsToReturn";
            this.LBxItemsToReturn.Size = new System.Drawing.Size(480, 104);
            this.LBxItemsToReturn.TabIndex = 35;
            // 
            // Return_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 454);
            this.Controls.Add(this.BTnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GBxInformation);
            this.Controls.Add(this.GBxMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Return_Items";
            this.Text = "Return_Items";
            this.groupBox1.ResumeLayout(false);
            this.GBxInformation.ResumeLayout(false);
            this.GBxInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BnScanRFID;
        private System.Windows.Forms.GroupBox GBxInformation;
        private System.Windows.Forms.Label LlAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LlBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LlRfidChecked;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LlSurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LlID;
        private System.Windows.Forms.Label LlName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GBxMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BnPriceToPay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LlPriceToPay;
        private System.Windows.Forms.ListBox LBxLoanedItems;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox LBxItemsToReturn;
        private System.Windows.Forms.RadioButton RBnDamaged;
        private System.Windows.Forms.RadioButton RBnNotDamaged;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox TBxDescription;
    }
}