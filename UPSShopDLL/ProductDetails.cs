using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Serialization;
using System.IO;

namespace UPSShopDLL
{
    public enum UPSByPass
    {
        OnOverLoad,
        OnFailure
    }
    public enum Brand
    {
        Alpha,
        CyberPower,
        PowerCom,
        PowerSun,
        PowerKinetics
    }
    [Serializable]
    public class ProductDetails
    {
       
        public Brand m_Brand { get; set; }
        public String m_ProductModel { get; set; }
        public int m_Price { get; set; }
        public UPSByPass m_UPSBYPASS { get; set; }
        public int m_Efficiency { get; set; }
        public int m_OperatingFrequency { get; set; }
        public int m_CurrentDistortion { get; set; }
        public int m_Count { get; set; }
       

    }
}
