using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UPSShopDLL
{
    public static  class SerilaiseData
    {
        public static void SerilaiseProductDetails(ProductDetails details)
        {
            FileStream file;
            XmlSerializer Serializer = new XmlSerializer(typeof(Collection));
            if (File.Exists(Resource.ProductFile) == false)
            {
                using (file = new FileStream(Resource.ProductFile, FileMode.Create))
                {
                    Collection collection = new Collection();
                    collection.m_ProductList.Add(details);
                    Serializer.Serialize(file, collection);
                }
                file.Close();
            }
            else
            {

                file = new FileStream(Resource.ProductFile, FileMode.Open, FileAccess.Read);
                var Details = Serializer.Deserialize(file) as Collection;
                Details.m_ProductList.Add(details);
                file.Close();
                file = new FileStream(Resource.ProductFile, FileMode.Open, FileAccess.ReadWrite);
                Serializer.Serialize(file, Details);
                file.Close();
            }
        }
        public static void SerilaiseCustomerDetails(CustomerDetails details)
        {
            FileStream file;
            XmlSerializer Serializer = new XmlSerializer(typeof(Collection));
            if (File.Exists(Resource.CustomerFile) == false)
            {
                using (file = new FileStream(Resource.CustomerFile, FileMode.Create))
                {
                    Collection collection = new Collection();
                    collection.m_CustomerList.Add(details);
                    Serializer.Serialize(file, collection);
                }
                file.Close();
            }
            else
            {

                file = new FileStream(Resource.CustomerFile, FileMode.Open, FileAccess.Read);
                var Details = Serializer.Deserialize(file) as Collection;
                file.Close();
                Details.m_CustomerList.Add(details);
                file = new FileStream(Resource.ProductFile, FileMode.Open, FileAccess.ReadWrite);
                Serializer.Serialize(file, Details);
                file.Close();
            }
        }
       
        public static void SerialiseData(Collection collection)
        {
          
            XmlSerializer Serializer = new XmlSerializer(typeof(Collection));
            using (FileStream file = new FileStream(Resource.ProductFile, FileMode.Create))
            {
                 Serializer.Serialize(file, collection);
            }
            
        }
        public static void SerialiseSalesDetails(Sales sale)
        {
            FileStream file;
            XmlSerializer Serializer = new XmlSerializer(typeof(Collection));
            if (File.Exists(Resource.SalesFile) == false)
            {
                using (file = new FileStream(Resource.SalesFile, FileMode.Create))
                {
                    Collection collection = new Collection();
                    collection.m_SalesList.Add(sale);
                    Serializer.Serialize(file, collection);
                }
                file.Close();
            }
            else
            {
                file = new FileStream(Resource.SalesFile, FileMode.Open, FileAccess.Read);
                var Details = Serializer.Deserialize(file) as Collection;
                file.Close();
                Details.m_SalesList.Add(sale);
                file = new FileStream(Resource.SalesFile, FileMode.Open, FileAccess.ReadWrite);
                Serializer = new XmlSerializer(typeof(Collection));
                Serializer.Serialize(file, Details);
                file.Close();
            }
        }

        
    }

}
