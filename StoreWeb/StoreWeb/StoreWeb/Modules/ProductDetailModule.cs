using Nancy;
using StoreWeb.Repository.Interface;
using log4net;

namespace StoreWeb.Modules
{
    public class ProductDetailModule : NancyModule
    {
        public ProductDetailModule(ILog logger, IProductService productService) : base("/ProductDetail") {
            Get["/{ProductId:int}"] = parameters =>
            {
                logger.Info("Getting ProductDetail");
                logger.Debug(parameters.ProductId);
                var result = productService.GetProductDetail(parameters.ProductId);
                return result;
                logger.Info("End ProductDetail");
            };
        }

    }
}
