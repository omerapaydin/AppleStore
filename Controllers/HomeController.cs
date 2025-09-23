using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppleStore.Data.Abstract;
using AppleStore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppleStore.Controllers
{
    public class HomeController : Controller
    {
        public int pageSize = 8;

        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public HomeController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List(int? id,int page = 1)
        {

            var products = _productRepository.Products.AsQueryable();

            if (id != null)
            {
                products = products.Where(i => i.CategoryId == id);
            }

            var viewModel = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                Categories = _categoryRepository.Categories.ToList(),
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