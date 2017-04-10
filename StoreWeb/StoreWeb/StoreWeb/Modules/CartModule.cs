using Nancy;
using log4net;
using StoreWeb.Responses;
using Nancy.ModelBinding;
using StoreWeb.Repository.Interface;
using System.Collections.Generic;

namespace StoreWeb.Modules
{
    public class CartModule : NancyModule
    {
        public CartModule(ILog logger, ICartService cartService,
                          IProductService productService) : base("/Cart")
        {
            Get["/"] = parameters =>
            {
                logger.Info("Getting cart");
                var cartId = this.Request.Cookies["CartId"];
                var response = cartService.GetCart(cartId);
                var result = new GetCartResponse { ProductList = new List<ProductDetailResponse>() };
                foreach (var p in response.ProductIds)
                {
                    var product = productService.GetProductDetail(p);
                    result.ProductList.Add(product);
                }
                logger.Info(string.Format("Cart fetched"));
                return result;
            };

            Post["/"] = parameters =>
            {
                logger.Info("Adding cart");
                var cartId = this.Request.Cookies["CartId"];
                var productId = this.Bind<int>();
                var response = cartService.AddCart(cartId, productId);
                logger.Info(string.Format("Item added {0}", productId));
                return response;
            };
        }
    }
}
