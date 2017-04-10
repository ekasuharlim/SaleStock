using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreWeb.Responses;

namespace StoreWeb.Repository.Interface
{
    public interface ICartService
    {
        CartResponse AddCart(string cartId, int productId);

        CartResponse GetCart(string cartId);
    }
}
