using JackDaniels.Application.ViewModels;
using JackDaniels.Core.Interfaces.Repositories;

namespace JackDaniels.Application.Services
{

    public class ProductService : IProductService
    {
        protected readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            var products = await _repository.GetAllAsync();

            return products
                .Select(s => new ProductViewModel(s.Id, s.Title, s.Price, s.Description, s.ImgUrl, s.FixedPrice, s.PricePerKg))
                .ToList();
        }
    }
}
