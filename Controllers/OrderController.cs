using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Data.Abstract;
using AppleStore.Helpers;
using AppleStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppleStore.Controllers
{
    public class OrderController : Controller
    {
        private Cart _cart;
        private IOrderRepository _orderRepository;

        public OrderController(Cart cartService, IOrderRepository orderRepository)
        {
            _cart = cartService;
            _orderRepository = orderRepository;
        }
        
           public IActionResult Checkout()
        {
            var cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            return View(new OrderModel() { Cart = cart });
        }

    }
}