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
                logger.Debug(this.Request.Cookies["CartId"]);
                logger.Debug(parameters.ProductId);
                var result = productService.GetProductDetail(parameters.ProductId);
                logger.Info("End ProductDetail");
                return result;
            };
        }

    }
}
