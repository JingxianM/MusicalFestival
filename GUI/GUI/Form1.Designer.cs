namespace GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BnSellTicket = new System.Windows.Forms.Button();
            this.BnAddMoney = new System.Windows.Forms.Button();
            this.LlCheckIn = new System.Windows.Forms.Button();
            this.BnCheckOut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BnRentSpot = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BnSellItem = new System.Windows.Forms.Button();
            this.BnLoanItem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BnReturnItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BnSellTicket
            // 
            this.BnSellTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnSellTicket.Location = new System.Drawing.Point(4, 17);
            this.BnSellTicket.Margin = new System.Windows.Forms.Padding(2);
            this.BnSellTicket.Name = "BnSellTicket";
            this.BnSellTicket.Size = new System.Drawing.Size(85, 24);
            this.BnSellTicket.TabIndex = 10;
            this.BnSellTicket.Text = "SellTicket";
            this.BnSellTicket.UseVisualStyleBackColor = true;
            this.BnSellTicket.Click += new System.EventHandler(this.BnSellTicket_Click);
            // 
            // BnAddMoney
            // 
            this.BnAddMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnAddMoney.Location = new System.Drawing.Point(98, 73);
            this.BnAddMoney.Margin = new System.Windows.Forms.Padding(2);
            this.BnAddMoney.Name = "BnAddMoney";
            this.BnAddMoney.Size = new System.Drawing.Size(85, 28);
            this.BnAddMoney.TabIndex = 11;
            this.BnAddMoney.Text = "Add Money";
            this.BnAddMoney.UseVisualStyleBackColor = true;
            this.BnAddMoney.Click += new System.EventHandler(this.BnAddMoney_Click);
            // 
            // LlCheckIn
            // 
            this.LlCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlCheckIn.Location = new System.Drawing.Point(98, 17);
            this.LlCheckIn.Margin = new System.Windows.Forms.Padding(2);
            this.LlCheckIn.Name = "LlCheckIn";
            this.LlCheckIn.Size = new System.Drawing.Size(85, 24);
            this.LlCheckIn.TabIndex = 13;
            this.LlCheckIn.Text = "Check In";
            this.LlCheckIn.UseVisualStyleBackColor = true;
            this.LlCheckIn.Click += new System.EventHandler(this.LlCheckIn_Click);
            // 
            // BnCheckOut
            // 
            this.BnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnCheckOut.Location = new System.Drawing.Point(4, 73);
            this.BnCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.BnCheckOut.Name = "BnCheckOut";
            this.BnCheckOut.Size = new System.Drawing.Size(85, 28);
            this.BnCheckOut.TabIndex = 14;
            this.BnCheckOut.Text = "CheckOut";
            this.BnCheckOut.UseVisualStyleBackColor = true;
            this.BnCheckOut.Click += new System.EventHandler(this.BnCheckOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.LlCheckIn);
            this.groupBox1.Controls.Add(this.BnCheckOut);
            this.groupBox1.Controls.Add(this.BnAddMoney);
            this.groupBox1.Controls.Add(this.BnSellTicket);
            this.groupBox1.Location = new System.Drawing.Point(129, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(188, 115);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance Box";
            // 
            // BnRentSpot
            // 
            this.BnRentSpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnRentSpot.Location = new System.Drawing.Point(17, 17);
            this.BnRentSpot.Margin = new System.Windows.Forms.Padding(2);
            this.BnRentSpot.Name = "BnRentSpot";
            this.BnRentSpot.Size = new System.Drawing.Size(85, 28);
            this.BnRentSpot.TabIndex = 15;
            this.BnRentSpot.Text = "Rent C Spot";
            this.BnRentSpot.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BnRentSpot);
            this.groupBox2.Location = new System.Drawing.Point(18, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(106, 87);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camping Spot";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Check In CS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BnSellItem
            // 
            this.BnSellItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnSellItem.Location = new System.Drawing.Point(4, 17);
            this.BnSellItem.Margin = new System.Windows.Forms.Padding(2);
            this.BnSellItem.Name = "BnSellItem";
            this.BnSellItem.Size = new System.Drawing.Size(178, 28);
            this.BnSellItem.TabIndex = 16;
            this.BnSellItem.Text = "Sell Item/s";
            this.BnSellItem.UseVisualStyleBackColor = true;
            // 
            // BnLoanItem
            // 
            this.BnLoanItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnLoanItem.Location = new System.Drawing.Point(4, 50);
            this.BnLoanItem.Margin = new System.Windows.Forms.Padding(2);
            this.BnLoanItem.Name = "BnLoanItem";
            this.BnLoanItem.Size = new System.Drawing.Size(85, 28);
            this.BnLoanItem.TabIndex = 17;
            this.BnLoanItem.Text = "Loan Item/s";
            this.BnLoanItem.UseVisualStyleBackColor = true;
            this.BnLoanItem.Click += new System.EventHandler(this.BnLoanItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.BnReturnItem);
            this.groupBox3.Controls.Add(this.BnLoanItem);
            this.groupBox3.Controls.Add(this.BnSellItem);
            this.groupBox3.Location = new System.Drawing.Point(129, 140);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(188, 87);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shops & Loans";
            // 
            // BnReturnItem
            // 
            this.BnReturnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnReturnItem.Location = new System.Drawing.Point(94, 50);
            this.BnReturnItem.Margin = new System.Windows.Forms.Padding(2);
            this.BnReturnItem.Name = "BnReturnItem";
            this.BnReturnItem.Size = new System.Drawing.Size(89, 28);
            this.BnReturnItem.TabIndex = 18;
            this.BnReturnItem.Text = "Return Item/s";
            this.BnReturnItem.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 246);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(337, 297);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ShakyKnees";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BnSellTicket;
        private System.Windows.Forms.Button BnAddMoney;
        private System.Windows.Forms.Button LlCheckIn;
        private System.Windows.Forms.Button BnCheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BnRentSpot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BnSellItem;
        private System.Windows.Forms.Button BnLoanItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BnReturnItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

