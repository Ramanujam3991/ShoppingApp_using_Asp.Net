using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAppUsingAsp.Models
{
    public class CategoryRepository : ICategoryRepository
    {
         private readonly ShoppingDbContext _appDbContext;

         public CategoryRepository(ShoppingDbContext appDbContext)
         {
             _appDbContext = appDbContext;
         }


        public IEnumerable<Category> GetAllCategory => _appDbContext.Categories;
    }
}
