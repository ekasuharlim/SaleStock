using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartService.Domain
{
    public class Cart
    {
        public string CartId { get; set; }

        public List<int> ProductIds { get; set; }
    }
}
