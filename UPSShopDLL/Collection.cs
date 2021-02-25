using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSShopDLL
{
    [Serializable]
    public class Collection
    {
        public List<Sales> m_SalesList;
        public List<ProductDetails> m_ProductList;
        public List<CustomerDetails> m_CustomerList;

        public Collection()
        {
            m_SalesList = new List<Sales>();
            m_ProductList = new List<ProductDetails>();
            m_CustomerList = new List<CustomerDetails>();
        }
        public ProductDetails Searchproduct(Collection list, String ProductModel)
        {
            if (list != null)
                foreach (var obj in list.m_ProductList)
                {
                    if (obj.m_ProductModel.Equals(ProductModel))
                        return obj;
                }
            return null;
        }
        public void IncrementProductCount(Collection list, String ProductModel, int Count)
        {
                var obj=Searchproduct(list, ProductModel);
                if (obj.m_ProductModel.Equals(ProductModel))
                {

                    obj.m_Count = obj.m_Count+ Count;
                }
            
        }
       public List<Sales> CompareDate(Collection Details, DateTime From, DateTime To)
        {
            List<Sales> SaleList = new List<Sales>();
            if (DateTime.Compare(From, DateTime.Now) <=0  && DateTime.Compare(To, DateTime.Now) <= 0)
            {
                foreach (var obj in Details.m_SalesList)
                {
                    int res1 = DateTime.Compare(obj.m_Date.Date, From);
                    int res2 = DateTime.Compare(obj.m_Date.Date, To);
                    if (res1 <= 0 && res2 <=0)
                    {
                        SaleList.Add(obj);
                    }
                }
                return SaleList;
            }
            return null;
        }
        public List<Sales> GetSales()
        {
            return m_SalesList;
        }

        public void DecrementCount(Collection list, String ProductModel, int Count)
        {
            var obj = Searchproduct(list, ProductModel);
             if (obj.m_ProductModel.Equals(ProductModel))
             {

                    obj.m_Count -= Count;
             }
        }

        public bool Searchproduct(Collection list,String ProductModel,int Count)
        {

           foreach(var obj in list.m_ProductList)
            {
               if(obj.m_ProductModel.Equals(ProductModel) && obj.m_Count>=Count)
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(Sales sobj)
        {
            m_SalesList.Add(sobj);
        }
        public void Add(ProductDetails obj)
        {
            m_ProductList.Add(obj);
        }
        public List<ProductDetails> GetProductList()
        {
            return m_ProductList;
        }
        public List<CustomerDetails> GetCustomerDetailsList()
        {
            return m_CustomerList;
        }
        
        
    }
}
