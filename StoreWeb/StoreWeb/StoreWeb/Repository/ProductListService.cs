using System;
using System.Collections.Generic;
using StoreWeb.Repository.Interface;
using StoreWeb.Responses;
using RestSharp;
using StoreWeb.Constant;


namespace StoreWeb.Repository
{
    public class ProductListService : IProductService
    {
        public IEnumerable<ProductListResponse> GetProductListOnPage(int pageNo)
        {
            var client = new RestClient(EndPoint.ProductService);
            var request = new RestRequest("/ProductList/Page/{pageNo}");
            request.AddUrlSegment("pageNo", pageNo.ToString());
            var response = client.Execute<List<ProductListResponse>>(request);
            return response.Data;
        }
    }
}
