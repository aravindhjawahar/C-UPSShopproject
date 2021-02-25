using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UPSShopDLL
{
    public static class DeserialiseData
    {
        public static object DeSerilaiseProductDetails()
        {
            if(File.Exists(Resource.ProductFile))
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(Collection));
                FileStream file = new FileStream(Resource.ProductFile, FileMode.Open, FileAccess.Read);
                Collection Details = Serializer.Deserialize(file) as Collection;
                return Details;
            }
            return null;
        }
        public static object DeSerialiseSalesDetails()
        {
            if(File.Exists(Resource.SalesFile))
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(Collection));
                FileStream file = new FileStream(Resource.SalesFile, FileMode.Open, FileAccess.Read);
                Collection Details = Serializer.Deserialize(file) as Collection;
                return Details;
            }
            return null;
        }
        public static object DeSerialiseCustomerDetails()
        {
            if (File.Exists(Resource.SalesFile))
            {
                XmlSerializer Serializer = new XmlSerializer(typeof(Collection));
                FileStream file = new FileStream(Resource.CustomerFile, FileMode.Open, FileAccess.Read);
                Collection Details = Serializer.Deserialize(file) as Collection;
                return Details;
            }
            return null;
        }
    }
}
