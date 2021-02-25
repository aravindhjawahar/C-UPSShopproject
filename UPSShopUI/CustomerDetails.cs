using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using UPSShopDLL;
namespace UPSShopUI
{
    public partial class CustomerDetails : Form
    {
       
        public Main m_obj;
        DataTable table;
        public CustomerDetails()
        {
            InitializeComponent();
          
            m_obj = new Main();
            table = new DataTable();
        }
        public CustomerDetails(Main obj)
        {
            m_obj = obj;
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            
            table.Columns.Add("SalesID", typeof(String));
            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Contact", typeof(int));
            table.Columns.Add("Address", typeof(String));
            Collection Details = (Collection)DeserialiseData.DeSerialiseSalesDetails();
            if (Details != null)
            {
            
            foreach (var obj in Details.m_SalesList)
            {
                table.Rows.Add(obj.m_CustomerSalesId, obj.m_Customer.m_CustomerName, obj.m_Customer.m_ContactNumber, obj.m_Customer.m_Adddress);
            }
           }
            dataGridView1.DataSource = table;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
