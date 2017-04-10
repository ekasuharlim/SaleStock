using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartService.Domain;
using CartService.Repository.Interface;

namespace CartService.Repository.Interface
{
    public class CartRepository : ICartRepository
    {
        private List<Cart> m_data;

        public CartRepository()
        {
            m_data = new List<Cart>();
        }

        public Cart AddCart(string cartId, int productId)
        {
            var cart = m_data.FirstOrDefault(c => c.CartId == cartId);
            if (cart == null)
            {
                cart = new Cart
                {
                    CartId = cartId,
                    ProductIds = new List<int>()
                };
                m_data.Add(cart);
            }
            cart.ProductIds.Add(productId);
            return cart;
        }

        public Cart GetCart(string cartId)
        {
            var cart = m_data.FirstOrDefault(c => c.CartId == cartId);
            return cart;
        }
    }
}
