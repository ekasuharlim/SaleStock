using System;
using Nancy;

namespace ProductServices.Modules
{
    public class ProductList : NancyModule
    {
        public ProductList()
        {
            Get["/ProductList"] = parameters =>
            {
                return "Show product list";
            };
        }
    }
}
