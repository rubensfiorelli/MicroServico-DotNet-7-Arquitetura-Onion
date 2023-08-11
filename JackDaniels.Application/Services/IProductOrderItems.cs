using JackDaniels.Application.InputModels;
using JackDaniels.Application.ViewModels;

namespace JackDaniels.Application.Services
{
    public interface IProductOrderItems
    {
        Task<string> Add(AddProductOrderInputModel model);
        Task<ProductOrderViewModel> GetByCode(string trackingCode);

    }
}
