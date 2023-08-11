using JackDaniels.Application.ViewModels;

namespace JackDaniels.Application.Services
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetAll();
    }
}
