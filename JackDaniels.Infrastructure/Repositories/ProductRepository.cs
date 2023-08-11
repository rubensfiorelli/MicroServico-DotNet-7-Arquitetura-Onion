using JackDaniels.Core.Entities;
using JackDaniels.Core.Interfaces.Repositories;

namespace JackDaniels.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
