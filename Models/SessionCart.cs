using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Helpers;

namespace AppleStore.Models
{
    public class SessionCart: Cart
    {
         public static SessionCart GetCart(IServiceProvider services)
        {
            var accessor = services.GetRequiredService<IHttpContextAccessor>();
            var session = accessor.HttpContext?.Session;
            var cart = session?.GetJson<SessionCart>("Cart");
            if (cart == null)
            {
                cart = new SessionCart();
                session?.SetJson("Cart", cart);
            }
            return cart;
        }

        public void SaveToSession(IServiceProvider services)
        {
            var accessor = services.GetRequiredService<IHttpContextAccessor>();
            var session = accessor.HttpContext?.Session;
            session?.SetJson("Cart", this);
        }
    }
}