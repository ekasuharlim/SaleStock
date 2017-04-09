using Nancy;
using System.Collections.Generic;
using ProductModules.Domain;
using ProductModules.Repository.Interface;
using log4net;


namespace ProductModules.Modules
{
    public class ProductDetail : NancyModule
    {
        public ProductDetail(ILog logger, IProductRepository repository) : base("/ProductDetail")
        {

            Get["/{ProductId:int}/"] = parameters =>
            {
                logger.Info("Geetting ProductList");
                var product = repository.GetProductDetail(parameters.ProductId);
                logger.Info("End ProductList");
                return product;
            };
        }

    }
}
