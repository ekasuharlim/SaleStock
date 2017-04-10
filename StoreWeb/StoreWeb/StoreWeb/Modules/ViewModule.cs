using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Cookies;

namespace StoreWeb
{
    public class ViewModule : NancyModule
    {
        public ViewModule()
        {
            Get["/"] = parameters =>
            {
                var cartId = string.Empty;
                if (this.Request.Cookies.ContainsKey("CartId"))
                {
                    cartId = this.Request.Cookies["CartId"];
                }
                else
                {
                    cartId = Guid.NewGuid().ToString();
                }
                return View["frontpage.html"].WithCookie(new NancyCookie("CartId", cartId));
            };
            Get["/View/Product/{ProductId}"] = parameters => { return View["ProductDetail.html", parameters]; };
            Get["/View/Checkout"] = parameters => { return View["checkout.html"]; };

        }
    }
}
