using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPSShopUI
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender,EventArgs e)
        {
            this.textBox1.Text = Convert.ToString(UPSShopDLL.Brand.Alpha);
            this.textBox2.Text = Convert.ToString(UPSShopDLL.Brand.CyberPower);
            this.textBox3.Text = Convert.ToString(UPSShopDLL.Brand.PowerCom);
            this.textBox4.Text = Convert.ToString(UPSShopDLL.Brand.PowerKinetics);
            this.textBox5.Text = Convert.ToString(UPSShopDLL.Brand.PowerSun);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
