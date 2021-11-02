using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingAppUsingAsp.Models;
using ShoppingAppUsingAsp.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAppUsingAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _candyRepository;

        public HomeController(IProductRepository candyRepository)
        {
            _candyRepository = candyRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductOnSale = _candyRepository.GetProductOnSale
            };

            return View(homeViewModel);
        }
    }
}
