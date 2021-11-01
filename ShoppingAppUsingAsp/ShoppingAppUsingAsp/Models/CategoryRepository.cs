using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAppUsingAsp.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        /* private readonly AppDbContext _appDbContext;

         public CategoryRepository(AppDbContext appDbContext)
         {
             _appDbContext = appDbContext;
         }

         public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;*/
        public IEnumerable<Category> GetAllCategory => new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Book",CategoryDesc="Famous book"},
            new Category{ CategoryId=2,CategoryName="Table", CategoryDesc="Office Table"},
            new Category{ CategoryId=3,CategoryName="Snacks",CategoryDesc="Essential food"}

        };
        
    }
}
