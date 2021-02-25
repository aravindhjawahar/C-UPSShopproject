using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UPSShopDLL
{
    public class Sales
    {
        

        public String m_CustomerSalesId;
        public CustomerDetails m_Customer;
        public String m_Maintanance { get; set; }
        public  DateTime m_Date{set;get;}
        public int m_Count { get; set; }
        public String m_Model { get; set; }
        public int m_Waranty { get; set; }
        public Brand m_brand{ get; set; }


        public Sales()
        {

        }

        public Sales(CustomerDetails customer)
        {
            this.m_Customer = customer;
        }

        public String GenerateSalesID(DateTime TIME)
        {
            this.m_CustomerSalesId = this.m_Customer.m_CustomerName +TIME;
            return m_CustomerSalesId;
        }
    }
}
