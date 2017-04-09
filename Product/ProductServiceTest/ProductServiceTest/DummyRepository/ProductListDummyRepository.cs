using System;
using System.Collections.Generic;
using System.Linq;
using ProductModules.Domain;
using ProductModules.Repository.Interface;


namespace ProductServiceTest.DummyRepository
{
   
    public class ProductListDummyRepository : IProductListRepository
    {
        List<Product> m_productData;

        public ProductListDummyRepository()
        {
            m_productData = new List<Product>();
            m_productData.Add(new Product { ProductId = 1, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 1000 });
        }

        public IEnumerable<Product> GetPagedItem(int pageNo, int count)
        {
            return m_productData.ToArray();            
        }
    }
}
