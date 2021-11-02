using Microsoft.AspNetCore.Mvc;
using ShoppingAppUsingAsp.Models;
using ShoppingAppUsingAsp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAppUsingAsp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        /*        public IActionResult List()
                {
                    *//* ViewBag.Currentcategory = "Best Seller";
                     return View(_productRepository.GetAllProduct);*//*
                    var productListViewModel = new ProductListViewModel();
                    productListViewModel.Products = _productRepository.GetAllProduct;
                    productListViewModel.CurrentCategory = "BestSellers";
                    return View(productListViewModel);
                }*/
        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.GetAllProduct.OrderBy(c => c.ProductId);
                currentCategory = "All Product";
            }
            else
            {
                products = _productRepository.GetAllProduct.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategory.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
