namespace GUI
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTnBack = new System.Windows.Forms.Button();
            this.Statics = new System.Windows.Forms.GroupBox();
            this.btn_statics = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.l_freeSpots = new System.Windows.Forms.Label();
            this.l_spots = new System.Windows.Forms.Label();
            this.l_spent = new System.Windows.Forms.Label();
            this.l_balance = new System.Windows.Forms.Label();
            this.l_nrOfV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_saleShop = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_sCheck = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_rentShop = new System.Windows.Forms.ComboBox();
            this.l_sAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_iCheck = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_iAmout = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_user = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Statics.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // BTnBack
            // 
            this.BTnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnBack.Location = new System.Drawing.Point(187, 22);
            this.BTnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BTnBack.Name = "BTnBack";
            this.BTnBack.Size = new System.Drawing.Size(141, 64);
            this.BTnBack.TabIndex = 46;
            this.BTnBack.Text = "Back";
            this.BTnBack.UseVisualStyleBackColor = true;
            this.BTnBack.Click += new System.EventHandler(this.BTnBack_Click);
            // 
            // Statics
            // 
            this.Statics.BackColor = System.Drawing.SystemColors.Control;
            this.Statics.Controls.Add(this.btn_statics);
            this.Statics.Controls.Add(this.label6);
            this.Statics.Controls.Add(this.l_freeSpots);
            this.Statics.Controls.Add(this.l_spots);
            this.Statics.Controls.Add(this.l_spent);
            this.Statics.Controls.Add(this.l_balance);
            this.Statics.Controls.Add(this.l_nrOfV);
            this.Statics.Controls.Add(this.label5);
            this.Statics.Controls.Add(this.label2);
            this.Statics.Controls.Add(this.label1);
            this.Statics.Controls.Add(this.label4);
            this.Statics.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statics.Location = new System.Drawing.Point(358, 11);
            this.Statics.Name = "Statics";
            this.Statics.Size = new System.Drawing.Size(667, 304);
            this.Statics.TabIndex = 47;
            this.Statics.TabStop = false;
            this.Statics.Text = "Statics";
            // 
            // btn_statics
            // 
            this.btn_statics.Location = new System.Drawing.Point(406, 252);
            this.btn_statics.Margin = new System.Windows.Forms.Padding(2);
            this.btn_statics.Name = "btn_statics";
            this.btn_statics.Size = new System.Drawing.Size(239, 42);
            this.btn_statics.TabIndex = 57;
            this.btn_statics.Text = "Check";
            this.btn_statics.UseVisualStyleBackColor = true;
            this.btn_statics.Click += new System.EventHandler(this.Btn_statics_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 177);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Booked Spots:";
            // 
            // l_freeSpots
            // 
            this.l_freeSpots.AutoSize = true;
            this.l_freeSpots.Location = new System.Drawing.Point(203, 222);
            this.l_freeSpots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_freeSpots.Name = "l_freeSpots";
            this.l_freeSpots.Size = new System.Drawing.Size(105, 31);
            this.l_freeSpots.TabIndex = 26;
            this.l_freeSpots.Text = "             ";
            // 
            // l_spots
            // 
            this.l_spots.AutoSize = true;
            this.l_spots.Location = new System.Drawing.Point(250, 177);
            this.l_spots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_spots.Name = "l_spots";
            this.l_spots.Size = new System.Drawing.Size(105, 31);
            this.l_spots.TabIndex = 25;
            this.l_spots.Text = "             ";
            // 
            // l_spent
            // 
            this.l_spent.AutoSize = true;
            this.l_spent.Location = new System.Drawing.Point(301, 132);
            this.l_spent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_spent.Name = "l_spent";
            this.l_spent.Size = new System.Drawing.Size(105, 31);
            this.l_spent.TabIndex = 24;
            this.l_spent.Text = "             ";
            // 
            // l_balance
            // 
            this.l_balance.AutoSize = true;
            this.l_balance.Location = new System.Drawing.Point(301, 87);
            this.l_balance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_balance.Name = "l_balance";
            this.l_balance.Size = new System.Drawing.Size(105, 31);
            this.l_balance.TabIndex = 23;
            this.l_balance.Text = "             ";
            // 
            // l_nrOfV
            // 
            this.l_nrOfV.AutoSize = true;
            this.l_nrOfV.Location = new System.Drawing.Point(214, 44);
            this.l_nrOfV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_nrOfV.Name = "l_nrOfV";
            this.l_nrOfV.Size = new System.Drawing.Size(189, 31);
            this.l_nrOfV.TabIndex = 22;
            this.l_nrOfV.Text = "                         ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Free Spots:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total Visitors\' spent:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total Visitors\' Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total Visitors:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cb_saleShop);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btn_sCheck);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cb_rentShop);
            this.groupBox1.Controls.Add(this.l_sAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 319);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop";
            // 
            // cb_saleShop
            // 
            this.cb_saleShop.FormattingEnabled = true;
            this.cb_saleShop.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_saleShop.Location = new System.Drawing.Point(195, 154);
            this.cb_saleShop.Margin = new System.Windows.Forms.Padding(2);
            this.cb_saleShop.Name = "cb_saleShop";
            this.cb_saleShop.Size = new System.Drawing.Size(136, 39);
            this.cb_saleShop.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 157);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 31);
            this.label13.TabIndex = 58;
            this.label13.Text = "Sale Shop Nr:";
            // 
            // btn_sCheck
            // 
            this.btn_sCheck.Location = new System.Drawing.Point(53, 262);
            this.btn_sCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sCheck.Name = "btn_sCheck";
            this.btn_sCheck.Size = new System.Drawing.Size(222, 45);
            this.btn_sCheck.TabIndex = 57;
            this.btn_sCheck.Text = "Check";
            this.btn_sCheck.UseVisualStyleBackColor = true;
            this.btn_sCheck.Click += new System.EventHandler(this.Btn_sCheck_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(271, 224);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 24);
            this.label12.TabIndex = 55;
            this.label12.Text = "€";
            // 
            // cb_rentShop
            // 
            this.cb_rentShop.FormattingEnabled = true;
            this.cb_rentShop.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_rentShop.Location = new System.Drawing.Point(195, 71);
            this.cb_rentShop.Margin = new System.Windows.Forms.Padding(2);
            this.cb_rentShop.Name = "cb_rentShop";
            this.cb_rentShop.Size = new System.Drawing.Size(136, 39);
            this.cb_rentShop.TabIndex = 54;
            // 
            // l_sAmount
            // 
            this.l_sAmount.AutoSize = true;
            this.l_sAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_sAmount.Location = new System.Drawing.Point(191, 221);
            this.l_sAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_sAmount.Name = "l_sAmount";
            this.l_sAmount.Size = new System.Drawing.Size(71, 24);
            this.l_sAmount.TabIndex = 42;
            this.l_sAmount.Text = "000,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Total Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 31);
            this.label10.TabIndex = 22;
            this.label10.Text = "                         ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 74);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 31);
            this.label15.TabIndex = 17;
            this.label15.Text = "Rent Shop Nr:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.cb_item);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_iCheck);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lb_iAmout);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(358, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 217);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item";
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Items.AddRange(new object[] {
            "Heineken",
            "Fries",
            "Kibbeling",
            "Corona",
            "Cola",
            "Fanta",
            "Bruger",
            "Pizza",
            "Iced-coffe",
            "Power Bank",
            "FlashLight",
            "Glowing Bracelet"});
            this.cb_item.Location = new System.Drawing.Point(256, 78);
            this.cb_item.Margin = new System.Windows.Forms.Padding(2);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(298, 39);
            this.cb_item.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 31);
            this.label7.TabIndex = 57;
            this.label7.Text = "Item Name:";
            // 
            // btn_iCheck
            // 
            this.btn_iCheck.Location = new System.Drawing.Point(406, 157);
            this.btn_iCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btn_iCheck.Name = "btn_iCheck";
            this.btn_iCheck.Size = new System.Drawing.Size(239, 45);
            this.btn_iCheck.TabIndex = 56;
            this.btn_iCheck.Text = " Check";
            this.btn_iCheck.UseVisualStyleBackColor = true;
            this.btn_iCheck.Click += new System.EventHandler(this.Btn_iCheck_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(346, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 55;
            this.label9.Text = "€";
            // 
            // lb_iAmout
            // 
            this.lb_iAmout.AutoSize = true;
            this.lb_iAmout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_iAmout.Location = new System.Drawing.Point(261, 166);
            this.lb_iAmout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_iAmout.Name = "lb_iAmout";
            this.lb_iAmout.Size = new System.Drawing.Size(71, 24);
            this.lb_iAmout.TabIndex = 42;
            this.lb_iAmout.Text = "000,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 31);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Amount:";
            // 
            // btn_user
            // 
            this.btn_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.Location = new System.Drawing.Point(187, 113);
            this.btn_user.Margin = new System.Windows.Forms.Padding(2);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(141, 61);
            this.btn_user.TabIndex = 56;
            this.btn_user.Text = "User Info";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.Btn_user_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1037, 534);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Statics);
            this.Controls.Add(this.BTnBack);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Information";
            this.Text = "Information";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Statics.ResumeLayout(false);
            this.Statics.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTnBack;
        private System.Windows.Forms.GroupBox Statics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_freeSpots;
        private System.Windows.Forms.Label l_spots;
        private System.Windows.Forms.Label l_spent;
        private System.Windows.Forms.Label l_balance;
        private System.Windows.Forms.Label l_nrOfV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label l_sAmount;
        private System.Windows.Forms.ComboBox cb_rentShop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_iAmout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_statics;
        private System.Windows.Forms.Button btn_sCheck;
        private System.Windows.Forms.Button btn_iCheck;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_saleShop;
        private System.Windows.Forms.Label label13;
    }
}