using JackDaniels.Core.Entities;

namespace JackDaniels.Core.Interfaces.Repositories
{
    public interface IProductRepository : IUnitOfWork
    {
        Task<List<Product>> GetAllAsync();
    }
}
