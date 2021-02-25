namespace UPSShopUI
{
    partial class NewSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.MaskedTextBox();
            this.tbWaranty = new System.Windows.Forms.ComboBox();
            this.btSell = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCustname = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Warrenty(in Years)";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(198, 234);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(173, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // tbWaranty
            // 
            this.tbWaranty.FormattingEnabled = true;
            this.tbWaranty.Items.AddRange(new object[] {
            "1",
            "2 ",
            "3 "});
            this.tbWaranty.Location = new System.Drawing.Point(198, 271);
            this.tbWaranty.Name = "tbWaranty";
            this.tbWaranty.Size = new System.Drawing.Size(173, 21);
            this.tbWaranty.TabIndex = 7;
            // 
            // btSell
            // 
            this.btSell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSell.Location = new System.Drawing.Point(163, 403);
            this.btSell.Name = "btSell";
            this.btSell.Size = new System.Drawing.Size(105, 35);
            this.btSell.TabIndex = 8;
            this.btSell.Text = "Sell";
            this.btSell.UseVisualStyleBackColor = false;
            this.btSell.Click += new System.EventHandler(this.btSell_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(274, 403);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(97, 35);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "CustomerName";
            // 
            // tbCustname
            // 
            this.tbCustname.Location = new System.Drawing.Point(198, 72);
            this.tbCustname.Name = "tbCustname";
            this.tbCustname.Size = new System.Drawing.Size(173, 20);
            this.tbCustname.TabIndex = 13;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(198, 110);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(173, 20);
            this.tbAddress.TabIndex = 14;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(198, 152);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(173, 20);
            this.tbContact.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(198, 314);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(173, 20);
            this.dateTimePickerDate.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Count";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(198, 352);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(173, 20);
            this.tbCount.TabIndex = 19;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(198, 33);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(173, 21);
            this.cbName.TabIndex = 20;
            this.cbName.SelectionChangeCommitted += new System.EventHandler(this.LoadModel);
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(198, 189);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(173, 21);
            this.cbModel.TabIndex = 21;
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbCustname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSell);
            this.Controls.Add(this.tbWaranty);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "NewSale";
            this.Text = "NewSale";
            this.Load += new System.EventHandler(this.NewSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbPrice;
        private System.Windows.Forms.ComboBox tbWaranty;
        private System.Windows.Forms.Button btSell;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCustname;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbModel;
    }
}