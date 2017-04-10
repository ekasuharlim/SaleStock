using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Nancy;
using Nancy.ModelBinding;
using CartService.Repository.Interface;
using CartService.Request;

namespace CartService.Modules
{
    public class CartModule : NancyModule
    {
        public CartModule(ILog logger,ICartRepository repository) : base("/Cart")
        {
            Get["/{CartId}/"] = parameters =>
            {
                logger.Info("Getting cart");
                var result = repository.GetCart(parameters.CartId);
                logger.Info("Cart fetched");
                return result;
            };

            Post["/"] = parameters =>
            {
                logger.Info("Adding cart");
                var request = this.Bind<CartAddRequest>();
                var result = repository.AddCart(request.CartId, request.ProductId);
                logger.Info(string.Format("Item added {0}", request.ProductId));
                return result;
            };
        }

    }
}
