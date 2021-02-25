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
    public partial class NewSale : Form
    {
        public Main mObj;
        Collection Details;
        public NewSale()
        {
            InitializeComponent();
            this.cbName.DataSource = Enum.GetValues(typeof(Brand));
            mObj = new Main();
            Details = (Collection)DeserialiseData.DeSerilaiseProductDetails();
            cbName.SelectedItem = null;
            
        }
        public NewSale(Main obj)
        {
            mObj = obj;
            
        }


        private void btSell_Click(object sender, EventArgs e)
        { 
            if ( mObj.m_collection.Searchproduct(Details,Convert.ToString(this.cbModel.Text),Convert.ToInt32(this.tbCount.Text)))
            {
                
                UPSShopDLL.CustomerDetails customer = new UPSShopDLL.CustomerDetails();
                customer.m_CustomerName = Convert.ToString(this.tbCustname.Text);
                customer.m_Adddress = Convert.ToString(this.tbAddress.Text);
                customer.m_ContactNumber = Convert.ToInt32(this.tbContact.Text);
                UPSShopDLL.Sales sale = new Sales(customer);
                sale.m_Date = Convert.ToDateTime(this.dateTimePickerDate.Text);
                sale.m_Count = Convert.ToInt32(this.tbCount.Text);
                sale.m_brand = (Brand)cbName.SelectedItem;
                sale.m_Waranty = Convert.ToInt32(tbWaranty.SelectedItem);
                sale.m_Model = Convert.ToString(cbModel.Text);

                sale.m_CustomerSalesId=sale.GenerateSalesID(sale.m_Date);

                mObj.m_collection.m_CustomerList.Add(customer);
                mObj.m_collection. DecrementCount(Details, Convert.ToString(this.cbModel.Text), Convert.ToInt32(this.tbCount.Text));

                SerilaiseData.SerialiseData(Details);
                mObj.m_collection.Add(sale);
                SerilaiseData.SerialiseSalesDetails(sale);

                MessageBox.Show("Product Sold","STATUS");
                this.Close();
            }
            else
            {
                MessageBox.Show("Product Count is not Sufficient","Status");
                this.Close();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewSale_Load(object sender, EventArgs e)
        {
               // if(Details!=null)
                
        }

        private void LoadModel(object sender, EventArgs e)
        {
            foreach (var obj in Details.m_ProductList)
            {
                if (obj.m_Brand.Equals(cbName.SelectedItem))
                {
                    this.cbModel.Items.Add(obj.m_ProductModel);
                }
            }
        }
    }
}
