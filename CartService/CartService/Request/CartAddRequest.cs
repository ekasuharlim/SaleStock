using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartService.Request
{
    public class CartAddRequest
    {
        public string CartId { get; set; }

        public int ProductId { get; set; }
    }
}
