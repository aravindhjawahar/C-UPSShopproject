namespace UPSShopUI
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbEfficiency = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbByPass = new System.Windows.Forms.ComboBox();
            this.tbCurrentDistortion = new System.Windows.Forms.TextBox();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ModelName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Efficiency";
            // 
            // cbBrand
            // 
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Items.AddRange(new object[] {
            "Alpha",
            "CyberPower",
            "PowerCom",
            "PowerSun",
            "PowerKinetics"});
            this.cbBrand.Location = new System.Drawing.Point(150, 53);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(158, 21);
            this.cbBrand.TabIndex = 4;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(150, 93);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(158, 20);
            this.tbModel.TabIndex = 5;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(150, 139);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(158, 20);
            this.tbPrice.TabIndex = 6;
            // 
            // tbEfficiency
            // 
            this.tbEfficiency.Location = new System.Drawing.Point(150, 182);
            this.tbEfficiency.Name = "tbEfficiency";
            this.tbEfficiency.Size = new System.Drawing.Size(158, 20);
            this.tbEfficiency.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "UPSBypass";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current Distortion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Operation Frequency";
            // 
            // cbByPass
            // 
            this.cbByPass.FormattingEnabled = true;
            this.cbByPass.Items.AddRange(new object[] {
            "OnOverLoad",
            "OnFailure"});
            this.cbByPass.Location = new System.Drawing.Point(150, 224);
            this.cbByPass.Name = "cbByPass";
            this.cbByPass.Size = new System.Drawing.Size(158, 21);
            this.cbByPass.TabIndex = 11;
            // 
            // tbCurrentDistortion
            // 
            this.tbCurrentDistortion.Location = new System.Drawing.Point(150, 265);
            this.tbCurrentDistortion.Name = "tbCurrentDistortion";
            this.tbCurrentDistortion.Size = new System.Drawing.Size(158, 20);
            this.tbCurrentDistortion.TabIndex = 12;
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(150, 303);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(158, 20);
            this.tbFrequency.TabIndex = 13;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdd.BackgroundImage")));
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(150, 388);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Count";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(150, 351);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(158, 20);
            this.tbCount.TabIndex = 17;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 423);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbFrequency);
            this.Controls.Add(this.tbCurrentDistortion);
            this.Controls.Add(this.cbByPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEfficiency);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbEfficiency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbByPass;
        private System.Windows.Forms.TextBox tbCurrentDistortion;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCount;
    }
}