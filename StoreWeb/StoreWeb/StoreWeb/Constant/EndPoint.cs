using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StoreWeb.Constant
{
    public static class EndPoint
    {
        public static string ProductService = ConfigurationManager.AppSettings["ProductServiceEndPoint"];
    }
}
