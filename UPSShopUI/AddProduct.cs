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
    public partial class AddProduct : Form
    {
        public Main m_Main;
        Collection Details;
        public AddProduct()
        {
            InitializeComponent();
            m_Main = new Main();
            cbByPass.DataSource = Enum.GetValues(typeof(UPSByPass));
            cbBrand.DataSource = Enum.GetValues(typeof(Brand));
            cbBrand.SelectedItem = null;
            cbByPass.SelectedItem = null;
            Details = (Collection)DeserialiseData.DeSerilaiseProductDetails();
        }
        public AddProduct(Main obj)
        {
          
            m_Main = obj;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            
            ProductDetails details = new ProductDetails();
            if (m_Main.m_collection.Searchproduct(Details, Convert.ToString(this.tbModel.Text))!=null)
            { 
                m_Main.m_collection.IncrementProductCount(Details, Convert.ToString(this.tbModel.Text),
                    Convert.ToInt32(this.tbCount.Text));
                SerilaiseData.SerialiseData(Details);
            }
            else
            {
                details.m_Price = Convert.ToInt32(tbPrice.Text);
                details.m_ProductModel = tbModel.Text;
                details.m_Efficiency = Convert.ToInt32(tbEfficiency.Text);
                details.m_CurrentDistortion = Convert.ToInt32(tbCurrentDistortion.Text);
                details.m_OperatingFrequency = Convert.ToInt32(tbFrequency.Text);
                details.m_UPSBYPASS = (UPSByPass)cbByPass.SelectedItem;
                details.m_Brand = (Brand)cbBrand.SelectedItem;
                details.m_Count = Convert.ToInt32(tbCount.Text);

                SerilaiseData.SerilaiseProductDetails(details);
            }
          if(details!=null)
          {
                 MessageBox.Show("New Product Added to the List", "STATUS");
                    this.Close();
          }
          else
              MessageBox.Show("Enter Valid data", "STATUS");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
