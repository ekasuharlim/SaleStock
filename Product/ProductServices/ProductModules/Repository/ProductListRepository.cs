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
            m_productData.Add(new Product
            {
                ProductId = 1,
                ArticleNo = "A-2121",
                Name = "Mickey",
                ImageName = "A-2121.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 32500
            });
            m_productData.Add(new Product
            {
                ProductId = 2,
                ArticleNo = "A-2122",
                Name = "Tom&Jerry",
                ImageName = "A-2122.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 32000
            });
            m_productData.Add(new Product
            {
                ProductId = 3,
                ArticleNo = "A-2131",
                Name = "Joe Tiger",
                ImageName = "A-2131.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 32000
            });
            m_productData.Add(new Product
            {
                ProductId = 4,
                ArticleNo = "A-2141",
                Name = "Tom&Jerry",
                ImageName = "A-2141.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 10000
            });
            m_productData.Add(new Product
            {
                ProductId = 5,
                ArticleNo = "A-2002",
                Name = "Tom&Jerry",
                ImageName = "A-2002.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 12000
            });
            m_productData.Add(new Product
            {
                ProductId = 6,
                ArticleNo = "A-2011",
                Name = "Giraffe Safari",
                ImageName = "A-2011.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 30000
            });
            m_productData.Add(new Product
            {
                ProductId = 7,
                ArticleNo = "A-2012",
                Name = "Giraffe Zoo",
                ImageName = "A-2012.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 18000
            });
            m_productData.Add(new Product
            {
                ProductId = 8,
                ArticleNo = "A-1632",
                Name = "Apple",
                ImageName = "A-1632.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 19000
            });
            m_productData.Add(new Product
            {
                ProductId = 9,
                ArticleNo = "A-1634",
                Name = "Princess",
                ImageName = "A-1634.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 12000
            });
            m_productData.Add(new Product
            {
                ProductId = 10,
                ArticleNo = "A-1633",
                Name = "Rabbit",
                ImageName = "A-1633.jpg",
                Description = "Baju : LD = 27 cm P = 36 cm Celana : Pinggang Karet P = 28 cm",
                Price = 32000
            });
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
