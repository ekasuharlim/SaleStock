using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWeb.Responses
{
    public class CartResponse
    {
        public string CartId { get; set; }

        public int ItemCount { get; set; }

        public IEnumerable<int> ProductIds { get; set; }
    }
}
