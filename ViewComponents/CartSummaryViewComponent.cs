using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppleStore.ViewComponents
{
    public class CartSummaryViewComponent:ViewComponent
    {
         private readonly Cart _cart;

    public CartSummaryViewComponent(Cart cart)
    {
        _cart = cart;
    }

    public IViewComponentResult Invoke()
    {
        return View(_cart);
    }
    }
}