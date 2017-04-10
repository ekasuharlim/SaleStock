using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWeb.Repository.CartService.Contract
{
    public class CartAddResponse
    {
        public string CartId { get; set; }

        public List<int> ProductIds { get; set; }
    }
}
