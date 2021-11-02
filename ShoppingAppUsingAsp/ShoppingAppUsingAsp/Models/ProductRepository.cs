using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingAppUsingAsp.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoppingDbContext _appDbContext;

        public ProductRepository(ShoppingDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> GetAllProduct
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }

        public IEnumerable<Product> GetProductOnSale
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }



    }
}
