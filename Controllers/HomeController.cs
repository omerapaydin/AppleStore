using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Data.Abstract;
using AppleStore.Entity;
using AppleStore.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppleStore.Controllers
{
    public class HomeController : Controller
    {
        public int pageSize = 8;
        private readonly IProductRepository _productRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IFavoriteRepository _favoriteRepository;

        private readonly ICategoryRepository _categoryRepository;
        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository, UserManager<ApplicationUser> userManager,IFavoriteRepository favoriteRepository   )
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _userManager = userManager;
            _favoriteRepository = favoriteRepository;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(string search, int? id, int page = 1)
{
    var products = _productRepository.Products.AsQueryable();

    if (id != null)
    {
        products = products.Where(i => i.CategoryId == id);
    }

    if (!string.IsNullOrEmpty(search))
    {
        search = search.ToLower();
        products = products.Where(p =>
            p.Title!.ToLower().Contains(search) ||
            (p.Description ?? "").ToLower().Contains(search)
        );
    }


    var userId = _userManager.GetUserId(User);
    var favoriteIds = new List<int>();

    if (userId != null)
    {
        var favorite = _favoriteRepository.GetFavoriteByUserId(userId);
        if (favorite != null)
        {
            favoriteIds = favorite.FavoriteItems
                .Select(fi => fi.ProductId)
                .ToList();
        }
    }

    var viewModel = new ProductListViewModel
    {
        Products = products
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList(),

        Categories = _categoryRepository.Categories.ToList(),

        FavoriteProductIds = favoriteIds, // ⭐ KRİTİK SATIR

        PageInfo = new PageInfo
        {
            ItemsPerPage = pageSize,
            TotalItems = products.Count(),
            CurrentPage = page
        }
    };

    return View(viewModel);
}

        public async Task<IActionResult> Details(int? id)
        {

            var product = await _productRepository.Products
                .FirstOrDefaultAsync(i => i.ProductId == id);

            return View(product);
        }

    }
}