using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Data.Abstract;
using AppleStore.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AppleStore.Controllers
{
    [Authorize]
    public class FavoriteController:Controller
    {
        private readonly IFavoriteRepository _favoriteRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        public FavoriteController(IFavoriteRepository favoriteRepository, UserManager<ApplicationUser> userManager)
        {
            _favoriteRepository = favoriteRepository;
            _userManager = userManager;
        }
      [HttpPost]
public IActionResult Add(int productId)
{
    var userId = _userManager.GetUserId(User);
    var favorite = _favoriteRepository.GetFavoriteByUserId(userId);

    if (favorite == null)
    {
        favorite = new Favorite
        {
            UserId = userId,
            PublishedOn = DateTime.Now,
            FavoriteItems = new List<FavoriteItem>()
        };
        _favoriteRepository.AddOrder(favorite);
    }

    if (!favorite.FavoriteItems.Any(fi => fi.ProductId == productId))
    {
        favorite.FavoriteItems.Add(new FavoriteItem
        {
            ProductId = productId
        });
        _favoriteRepository.AddOrder(favorite);
    }

    return RedirectToAction("Index", "Home");
}
        

    }
}