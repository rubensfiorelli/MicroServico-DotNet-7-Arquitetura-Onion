using JackDaniels.Application.InputModels;
using JackDaniels.Application.ViewModels;
using JackDaniels.Core.Interfaces.Repositories;

namespace JackDaniels.Application.Services
{
    public class ProductOrderItems : IProductOrderItems
    {
        protected readonly IProductOrderRepository _repository;

        public ProductOrderItems(IProductOrderRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Add(AddProductOrderInputModel model)
        {
            var productOrder = model.ToEntity();

            var products = model
                .Products
                .Select(s => s.ToEntity())
                .ToList();


            productOrder.SetupOrders(products);

            await _repository.AddAsync(productOrder);

            return productOrder.TrackingCode;

        }

        public async Task<ProductOrderViewModel> GetByCode(string trackingCode)
        {
            var productOrder = await _repository.GetTrackingCodeAsync(trackingCode);

            return ProductOrderViewModel.FromEntity(productOrder);
        }
    }
}
