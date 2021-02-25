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
    public partial class Availability : Form
    {
        public Main m_main;
        DataTable table;
      
        public Availability()
        {
            InitializeComponent();
            m_main = new Main();
            table = new DataTable();
        }
        public Availability(Main main)
        {
            m_main = main;
        }
        private void Availability_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Brand", typeof(UPSShopDLL.Brand));
            table.Columns.Add("Model", typeof(String));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("UPSByPass", typeof(UPSShopDLL.UPSByPass));
            table.Columns.Add("Efficiency", typeof(int));
            table.Columns.Add("OperationFrequency", typeof(int));
            table.Columns.Add("CurrentDistortion", typeof(int));
            table.Columns.Add("Count", typeof(int));
            Collection Details = (Collection)DeserialiseData.DeSerilaiseProductDetails();
            if (Details != null)
            {
                foreach (var obj in Details.m_ProductList)
                {
                    table.Rows.Add(obj.m_Brand, obj.m_ProductModel, obj.m_Price, obj.m_UPSBYPASS, obj.m_Efficiency
                        , obj.m_OperatingFrequency, obj.m_CurrentDistortion, obj.m_Count);

                }
            }
            dataGridView1.DataSource = table;
            
        }
    }
}
