using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace StoreWeb
{
    public class ViewModule : NancyModule
    {
        public ViewModule()
        {
            Get["/"] = parameters => { return View["frontpage.html"]; };
            Get["/View/Product/{ProductId}"] = parameters => { return View["ProductDetail.html", parameters]; };

        }
    }
}
