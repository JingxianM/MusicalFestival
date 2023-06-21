namespace GUI
{
    partial class Change_Amount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_Amount));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LlSelectedItem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LlPricePerItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBxQuantity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LlTotalPrice = new System.Windows.Forms.Label();
            this.BnConfirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Item:";
            // 
            // LlSelectedItem
            // 
            this.LlSelectedItem.AutoSize = true;
            this.LlSelectedItem.Location = new System.Drawing.Point(154, 21);
            this.LlSelectedItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LlSelectedItem.Name = "LlSelectedItem";
            this.LlSelectedItem.Size = new System.Drawing.Size(116, 20);
            this.LlSelectedItem.TabIndex = 3;
            this.LlSelectedItem.Text = "Selected Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price per Item:";
            // 
            // LlPricePerItem
            // 
            this.LlPricePerItem.AutoSize = true;
            this.LlPricePerItem.Location = new System.Drawing.Point(154, 58);
            this.LlPricePerItem.Name = "LlPricePerItem";
            this.LlPricePerItem.Size = new System.Drawing.Size(54, 20);
            this.LlPricePerItem.TabIndex = 5;
            this.LlPricePerItem.Text = "$ 0,00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity:";
            // 
            // CBxQuantity
            // 
            this.CBxQuantity.FormattingEnabled = true;
            this.CBxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CBxQuantity.Location = new System.Drawing.Point(158, 95);
            this.CBxQuantity.Name = "CBxQuantity";
            this.CBxQuantity.Size = new System.Drawing.Size(121, 28);
            this.CBxQuantity.TabIndex = 7;
            this.CBxQuantity.Text = "1";
            this.CBxQuantity.SelectedIndexChanged += new System.EventHandler(this.CBxQuantity_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Price:";
            // 
            // LlTotalPrice
            // 
            this.LlTotalPrice.AutoSize = true;
            this.LlTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlTotalPrice.Location = new System.Drawing.Point(167, 143);
            this.LlTotalPrice.Name = "LlTotalPrice";
            this.LlTotalPrice.Size = new System.Drawing.Size(72, 25);
            this.LlTotalPrice.TabIndex = 9;
            this.LlTotalPrice.Text = "$ 0,00";
            // 
            // BnConfirm
            // 
            this.BnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BnConfirm.Location = new System.Drawing.Point(319, 200);
            this.BnConfirm.Name = "BnConfirm";
            this.BnConfirm.Size = new System.Drawing.Size(93, 37);
            this.BnConfirm.TabIndex = 10;
            this.BnConfirm.Text = "Confirm";
            this.BnConfirm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.LlTotalPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBxQuantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LlPricePerItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LlSelectedItem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 182);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Change_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 260);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BnConfirm);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Change_Amount";
            this.Text = "Change_Amount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LlSelectedItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LlPricePerItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LlTotalPrice;
        private System.Windows.Forms.Button BnConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}