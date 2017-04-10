using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CartService.Domain;

namespace CartService.Repository.Interface
{
    public interface ICartRepository
    {
        Cart AddCart(string cartId, int productId);

        Cart GetCart(string cartId);
    }
}
