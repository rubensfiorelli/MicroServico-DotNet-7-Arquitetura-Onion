using JackDaniels.Core.Interfaces.Repositories;

namespace JackDaniels.Infrastructure.Repositories
{
    public class ProductOrder : IProductOrderRepository
    {
        public Task<Core.Entities.ProductOrder> AddAsync(Core.Entities.ProductOrder productOrder)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Entities.ProductOrder> GetTrackingCodeAsync(string code)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Commit()
        {
            throw new NotImplementedException();
        }

        public Task Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
