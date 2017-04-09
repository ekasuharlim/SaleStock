using Nancy;
using System.Collections.Generic;
using ProductModules.Domain;
using ProductModules.Repository.Interface;
using log4net;

namespace ProductModules.Modules
{
    public class ProductList : NancyModule
    {
        public ProductList(ILog logger, IProductListRepository repository) : base("/ProductList")
        {
            
            Get["/Page/{page:int}/"] = parameters =>
            {
                logger.Info("Geetting ProductList");
                logger.Debug(string.Format("Page {0}", parameters.page));
                IEnumerable<Product> products = repository.GetPagedItem(parameters.page, 10);
                logger.Info("End ProductList");
                return products;
            };
        }
    }
}
