using Nancy;
using StoreWeb.Repository.Interface;
using log4net;

namespace StoreWeb.Modules
{
    public class ProductListModule : NancyModule
    {
        public ProductListModule(ILog logger, IProductService productService) : base("/ProductList") {
            Get["/Page/{page:int}/"] = parameters =>
            {
                logger.Info("Getting ProductList");
                var result =  productService.GetProductListOnPage(parameters.page);
                logger.Info("End ProductList");
                return result;
            };
        }
    }
}
