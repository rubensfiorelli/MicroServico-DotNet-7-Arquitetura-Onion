using JackDaniels.Core.Entities;
using JackDaniels.Core.Enum;

namespace JackDaniels.Application.ViewModels
{
    public class ProductOrderViewModel
    {
        public ProductOrderViewModel(string trackingCode,
                                     string description,
                                     decimal weigthInKg,
                                     Guid deliveryAddressId,
                                     ProductOrderStatus status,
                                     decimal totalPrice)
        {
            TrackingCode = trackingCode;
            Description = description;
            WeigthInKg = weigthInKg;
            DeliveryAddressId = deliveryAddressId;
            Status = status;
            TotalPrice = totalPrice;
        }

        public string TrackingCode { get; private set; }
        public string Description { get; private set; }
        public decimal WeigthInKg { get; private set; }
        public Guid DeliveryAddressId { get; private set; }
        public ProductOrderStatus Status { get; private set; }
        public decimal TotalPrice { get; private set; }

        public static ProductOrderViewModel FromEntity(ProductOrder productOrder)
        {

            return new ProductOrderViewModel(productOrder.TrackingCode,
                                             productOrder.Description,
                                             productOrder.WeigthInKg,
                                             productOrder.DeliveryAddressId,
                                             productOrder.Status,
                                             productOrder.TotalPrice);
        }
    }
}
