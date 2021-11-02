using ShoppingAppUsingAsp.Models;
using ShoppingAppUsingAsp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAppUsingAsp.Components
{
    public class CategoryMenu : ViewComponent
    {

        private readonly ICategoryRepository _categoryRepository;
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllCategory.OrderBy(c => c.CategoryName);

            return View(categories);
        }
    }
}
