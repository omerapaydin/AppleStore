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
    public class HomeController:Controller
    {
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
        public async Task<IActionResult> List(int? id)
        {

            var products = await _productRepository.Products.ToListAsync();

            if (id != null)
            {
                products = products.Where(i => i.CategoryId == id).ToList();
            }

            var viewModel = new ProductListViewModel
            {
                Products = products,
                Categories = await _categoryRepository.Categories.ToListAsync()
            };
             return View(viewModel);
        }
    }
}