using System;
using System.Collections.Generic;
using System.Linq;
using ProductModules.Domain;
using ProductModules.Repository.Interface;

namespace ProductModules.Repository
{
    public class ProductRepository : IProductListRepository, IProductRepository
    {
        List<Product> m_productData;
        public ProductRepository()
        {
            m_productData = new List<Product>();
            m_productData.Add(new Product { ProductId = 1, ArticleNo = "ABC", Name = "SHIRT A", ImageName = "SHRIT1", Description = "DESC",Price = 1000});
            m_productData.Add(new Product { ProductId = 2, ArticleNo = "ABC", Name = "SHIRT B", ImageName = "SHRIT1", Description = "DESC", Price = 2000 });
            m_productData.Add(new Product { ProductId = 3, ArticleNo = "ABC", Name = "SHIRT C", ImageName = "SHRIT1", Description = "DESC", Price = 3000 });
            m_productData.Add(new Product { ProductId = 4, ArticleNo = "ABC", Name = "SHIRT D", ImageName = "SHRIT1", Description = "DESC", Price = 4000 });
            m_productData.Add(new Product { ProductId = 5, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 5000 });
            m_productData.Add(new Product { ProductId = 6, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 6000 });
            m_productData.Add(new Product { ProductId = 7, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 7000 });
            m_productData.Add(new Product { ProductId = 8, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC",Price = 8000 });
            m_productData.Add(new Product { ProductId = 9, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 9000 });
            m_productData.Add(new Product { ProductId = 10, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 10000 });
            m_productData.Add(new Product { ProductId = 11, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 11000 });
            m_productData.Add(new Product { ProductId = 12, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 12000 });
            m_productData.Add(new Product { ProductId = 13, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 13000 });
            m_productData.Add(new Product { ProductId = 14, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 14000 });
            m_productData.Add(new Product { ProductId = 15, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 15000 });
            m_productData.Add(new Product { ProductId = 16, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 16000 });
            m_productData.Add(new Product { ProductId = 17, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 17000 });
            m_productData.Add(new Product { ProductId = 18, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 18000 });
            m_productData.Add(new Product { ProductId = 19, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 19000 });
            m_productData.Add(new Product { ProductId = 20, ArticleNo = "ABC", Name = "SHIRT", ImageName = "SHRIT1", Description = "DESC", Price = 20000 });
        }
        public IEnumerable<Product> GetPagedItem(int pageNo, int count)
        {
            return m_productData.Skip((pageNo - 1) * count).Take(count);
            
        }

        public Product GetProductDetail(int productId)
        {
            return m_productData.Single(p => p.ProductId == productId);
        }
    }
}
