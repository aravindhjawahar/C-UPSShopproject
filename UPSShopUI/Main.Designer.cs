namespace UPSShopUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btNewSales = new System.Windows.Forms.Button();
            this.btCustomerDetails = new System.Windows.Forms.Button();
            this.btvAddProducts = new System.Windows.Forms.Button();
            this.btViewReport = new System.Windows.Forms.Button();
            this.btViewProducts = new System.Windows.Forms.Button();
            this.btAvailability = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNewSales
            // 
            this.btNewSales.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btNewSales.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewSales.Location = new System.Drawing.Point(100, 408);
            this.btNewSales.Name = "btNewSales";
            this.btNewSales.Size = new System.Drawing.Size(219, 28);
            this.btNewSales.TabIndex = 0;
            this.btNewSales.Text = "New Sales";
            this.btNewSales.UseVisualStyleBackColor = false;
            this.btNewSales.Click += new System.EventHandler(this.btNewSales_Click);
            // 
            // btCustomerDetails
            // 
            this.btCustomerDetails.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btCustomerDetails.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomerDetails.Location = new System.Drawing.Point(100, 442);
            this.btCustomerDetails.Name = "btCustomerDetails";
            this.btCustomerDetails.Size = new System.Drawing.Size(219, 32);
            this.btCustomerDetails.TabIndex = 1;
            this.btCustomerDetails.Text = "View Customer Details";
            this.btCustomerDetails.UseVisualStyleBackColor = false;
            this.btCustomerDetails.Click += new System.EventHandler(this.btCustomerDetails_Click);
            // 
            // btvAddProducts
            // 
            this.btvAddProducts.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btvAddProducts.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvAddProducts.Location = new System.Drawing.Point(100, 480);
            this.btvAddProducts.Name = "btvAddProducts";
            this.btvAddProducts.Size = new System.Drawing.Size(219, 30);
            this.btvAddProducts.TabIndex = 2;
            this.btvAddProducts.Text = "Add Products";
            this.btvAddProducts.UseVisualStyleBackColor = false;
            this.btvAddProducts.Click += new System.EventHandler(this.btvAddProducts_Click);
            // 
            // btViewReport
            // 
            this.btViewReport.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btViewReport.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewReport.Location = new System.Drawing.Point(100, 516);
            this.btViewReport.Name = "btViewReport";
            this.btViewReport.Size = new System.Drawing.Size(219, 30);
            this.btViewReport.TabIndex = 3;
            this.btViewReport.Text = "View Maintanance Report and Details";
            this.btViewReport.UseVisualStyleBackColor = false;
            this.btViewReport.Click += new System.EventHandler(this.btViewReport_Click);
            // 
            // btViewProducts
            // 
            this.btViewProducts.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btViewProducts.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewProducts.Location = new System.Drawing.Point(100, 370);
            this.btViewProducts.Name = "btViewProducts";
            this.btViewProducts.Size = new System.Drawing.Size(219, 32);
            this.btViewProducts.TabIndex = 4;
            this.btViewProducts.Text = "View Products";
            this.btViewProducts.UseVisualStyleBackColor = false;
            this.btViewProducts.Click += new System.EventHandler(this.btViewProducts_Click);
            // 
            // btAvailability
            // 
            this.btAvailability.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btAvailability.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvailability.Location = new System.Drawing.Point(100, 334);
            this.btAvailability.Name = "btAvailability";
            this.btAvailability.Size = new System.Drawing.Size(219, 30);
            this.btAvailability.TabIndex = 5;
            this.btAvailability.Text = "Check Product Availability";
            this.btAvailability.UseVisualStyleBackColor = false;
            this.btAvailability.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 648);
            this.Controls.Add(this.btAvailability);
            this.Controls.Add(this.btViewProducts);
            this.Controls.Add(this.btViewReport);
            this.Controls.Add(this.btvAddProducts);
            this.Controls.Add(this.btCustomerDetails);
            this.Controls.Add(this.btNewSales);
            this.Name = "Main";
            this.Text = "UPS SHOP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNewSales;
        private System.Windows.Forms.Button btCustomerDetails;
        private System.Windows.Forms.Button btvAddProducts;
        private System.Windows.Forms.Button btViewReport;
        private System.Windows.Forms.Button btViewProducts;
        private System.Windows.Forms.Button btAvailability;
    }
}

