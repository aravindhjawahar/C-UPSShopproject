using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UPSShopDLL
{
    [Serializable]
    public class CustomerDetails
    {
        public String m_CustomerName { set; get; }
        public String m_Adddress { set; get; }
        public int m_ContactNumber { set; get; }
        public DateTime m_date { set; get; }

        
    }
}
