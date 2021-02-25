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
    public partial class btBack : Form
    {
        Main m_Obj;
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        public btBack()
        {
            InitializeComponent();
            table.Columns.Add("Name",typeof(String));
            table.Columns.Add("SalesID", typeof(String));
            table.Columns.Add("Warranty", typeof(int));
            table.Columns.Add("SoldDate", typeof(DateTime));
            table.Columns.Add("Contact", typeof(int));
            table.Columns.Add("Model", typeof(String));
            table.Columns.Add("Brand", typeof(UPSShopDLL.Brand));
            table2.Columns.Add("Name", typeof(String));
            table2.Columns.Add("SalesID", typeof(String));
            table2.Columns.Add("Warranty", typeof(int));
            table2.Columns.Add("SoldDate", typeof(DateTime));
            table2.Columns.Add("Contact", typeof(int));
            table2.Columns.Add("Model", typeof(String));
            table2.Columns.Add("Brand", typeof(UPSShopDLL.Brand));
            m_Obj = new Main();
        }
        public btBack(Main obj)
        {
            m_Obj = obj;
        }
        private void bt_Back(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBack_Load(object sender, EventArgs e)
        {
            Collection Details = (Collection)DeserialiseData.DeSerialiseSalesDetails();
            if (Details != null)
            foreach (var obj in Details.m_SalesList)
            {
                table.Rows.Add(obj.m_Customer.m_CustomerName, obj.m_CustomerSalesId, obj.m_Waranty, 
                    obj.m_Date, obj.m_Customer.m_ContactNumber,obj.m_Model,obj.m_brand);
            }
            dataGridView1.DataSource = table;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Collection Details = (Collection)DeserialiseData.DeSerialiseSalesDetails();
            DateTime From = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime To = Convert.ToDateTime(dateTimePicker2.Value);
            if ( m_Obj.m_collection.CompareDate(Details, From, To) != null )
            {
                var SaleList = m_Obj.m_collection.CompareDate(Details, From, To);
                foreach (var obj in SaleList)
                {
                    table2.Rows.Add(obj.m_Customer.m_CustomerName, obj.m_CustomerSalesId, obj.m_Waranty,
                        obj.m_Date, obj.m_Customer.m_ContactNumber, obj.m_Model, obj.m_brand);
                }
            }
            else
                MessageBox.Show("Enter Valid From Date!!!","ERROR");
            dataGridView1.DataSource = table2;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.table.Rows.Clear();
            this.table2.Rows.Clear();
        }
    }
}
