using Nancy;

namespace ProductModules.Modules
{
    public class ProductList : NancyModule
    {
        public ProductList() : base("/ProductList")
        {
            Get["/"] = parameters =>
            {
                return "ProductList";
            };
        }
    }
}
