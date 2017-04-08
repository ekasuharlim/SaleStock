using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Nancy.Testing;
using ProductModules.Modules;
using Nancy;

namespace ProductServiceTest
{
    public class ProductListTest
    {
        [Fact]
        public void Get_All_Product()
        {
            var browser = new Browser(with => with.Module<ProductList>());
            var response = browser.Get("/ProductList");         
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
