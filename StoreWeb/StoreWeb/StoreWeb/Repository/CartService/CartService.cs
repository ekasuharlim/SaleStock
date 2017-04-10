using System;
using System.Collections.Generic;
using StoreWeb.Repository.Interface;
using StoreWeb.Responses;
using RestSharp;
using StoreWeb.Constant;
using StoreWeb.Repository.CartService.Contract;
using System.Linq;

namespace StoreWeb.Repository.CartService
{
    public class CartService : ICartService
    {
        public CartResponse AddCart(string cartId, int productId)
        {
            var client = new RestClient(Setting.CartServiceEndPoint);
            var request = new RestRequest("/Cart", Method.POST);
            request.AddJsonBody(new CartAddRequest
            {
                CartId = cartId,
                ProductId = productId
            });
            var response = client.Execute<CartAddResponse>(request);
            var result = new CartResponse
            {
                CartId = response.Data.CartId,
                ProductIds = response.Data.ProductIds,
                ItemCount = response.Data.ProductIds.Count()
            };
            return result;
        }

        public CartResponse GetCart(string cartId)
        {
            var client = new RestClient(Setting.CartServiceEndPoint);
            var request = new RestRequest("/Cart/{CartId}");
            request.AddUrlSegment("CartId", cartId);
            var response = client.Execute<CartAddResponse>(request);
            var result = new CartResponse
            {
                CartId = response.Data.CartId,
                ProductIds = response.Data.ProductIds,
                ItemCount = response.Data.ProductIds.Count()
            };
            return result;
        }
    }
}
