using Microsoft.EntityFrameworkCore;
using ShopOnline.API.Data;
using ShopOnline.API.Entities;
using ShopOnline.API.Repositories.Contracts;

namespace ShopOnline.API.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(ShopOnlineDbContext shopeOnlineDbContext)
        {
            _shopeOnlineDbContext = shopeOnlineDbContext;
        }

        private ShopOnlineDbContext _shopeOnlineDbContext { get; }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            return await _shopeOnlineDbContext.ProductCategories.ToListAsync();
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            return await _shopeOnlineDbContext.Products.ToListAsync();
        }
    }
}
