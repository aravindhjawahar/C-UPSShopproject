using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPSShopDLL;

namespace UPSShopUI
{
    public partial class Main : Form
    {
        public UPSShopDLL.CustomerDetails m_details;
        public Collection m_collection;
       
        public Main()
        {
            InitializeComponent();
            m_details = new UPSShopDLL.CustomerDetails();
            m_collection = new Collection();
        }
        
        private void btCustomerDetails_Click(object sender, EventArgs e)
        {
           
            CustomerDetails details = new CustomerDetails();
            details.ShowDialog(this);
        }

        private void btViewProducts_Click(object sender, EventArgs e)
        {
            
            Product product = new Product();
            product.ShowDialog();
        }

        private void btNewSales_Click(object sender, EventArgs e)
        {
           
            NewSale sale = new NewSale();
            sale.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Availability availability = new Availability();
            availability.ShowDialog();
           
        }

        private void btvAddProducts_Click(object sender, EventArgs e)
        {
            
            AddProduct product = new AddProduct();
          
            product.ShowDialog(this);
           
        }

        private void btViewReport_Click(object sender, EventArgs e)
        {
           
            btBack report = new btBack();
            report.ShowDialog();
        }

       
    }
}
