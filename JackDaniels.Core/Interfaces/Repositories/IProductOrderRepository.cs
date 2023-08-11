using JackDaniels.Core.Entities;

namespace JackDaniels.Core.Interfaces.Repositories
{
    public interface IProductOrderRepository : IUnitOfWork
    {
        Task<ProductOrder> GetTrackingCodeAsync(string code);
        Task<ProductOrder> AddAsync(ProductOrder productOrder);
    }
}
