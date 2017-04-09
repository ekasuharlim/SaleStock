using System;
using System.Collections.Generic;
using StoreWeb.Repository.Interface;
using StoreWeb.Responses;
using RestSharp;
using StoreWeb.Constant;


namespace StoreWeb.Repository
{
    public class ProductService : IProductService
    {
        public ProductDetailResponse GetProductDetail(int productId)
        {
            var client = new RestClient(Setting.ProductServiceEndPoint);
            var request = new RestRequest("/ProductDetail/{ProductId}");
            request.AddUrlSegment("ProductId", productId.ToString());
            var response = client.Execute<ProductDetailResponse>(request);
            return response.Data;
        }

        public IEnumerable<ProductListResponse> GetProductListOnPage(int pageNo)
        {
            var client = new RestClient(Setting.ProductServiceEndPoint);
            var request = new RestRequest("/ProductList/Page/{pageNo}");
            request.AddUrlSegment("pageNo", pageNo.ToString());
            var response = client.Execute<List<ProductListResponse>>(request);
            return response.Data;
        }
    }
}
