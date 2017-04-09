
using Xunit;
using Nancy.Testing;
using ProductModules.Modules;
using Nancy;
using ProductServiceTest.DummyRepository;
using ProductModules.Responses;
using ProductModules.Domain;

namespace ProductServiceTest
{
    public class ProductListTest
    {
        [Fact]
        public void Get_Productist_Return_Json()
        {
            var browser = new Browser(with =>
            {
                with.Module<ProductList>();
                with.Dependencies(new ProductListDummyRepository());
            });
            var response = browser.Get("/ProductList/Page/1", with =>
            {
                with.Header("Accept", "application/json");
            });
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal("application/json; charset=utf-8", response.ContentType);           
        }

    }
}
