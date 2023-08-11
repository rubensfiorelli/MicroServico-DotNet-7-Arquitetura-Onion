using JackDaniels.Core.Enum;
using JackDaniels.Core.ValueObject;

namespace JackDaniels.Core.Entities
{
    public sealed class ProductOrder : BaseEntity
    {
        public ProductOrder(string description,
                            decimal weigthInKg,
                            Guid deliveryAddressId) : base()

        {
            TrackingCode = GenerateTrackingCode();
            Description = description;
            WeigthInKg = weigthInKg;
            DeliveryAddressId = deliveryAddressId;


            Status = ProductOrderStatus.Started;
            Items = new List<ProductOrderItems>();
        }

        public string TrackingCode { get; private set; }
        public string Description { get; private set; }
        public decimal WeigthInKg { get; private set; }
        public Guid DeliveryAddressId { get; private set; }
        public DeliveryAddress? DeliveryAddress { get; set; }
        public ProductOrderStatus Status { get; private set; }
        public decimal TotalPrice { get; private set; }
        public List<ProductOrderItems> Items { get; private set; }


        public void SetupOrders(List<Product> items)
        {
            foreach (var product in items)
            {
                var productPrice = product.Price + product.FixedPrice + product.PricePerKg * WeigthInKg;
                TotalPrice += productPrice;
                Items.Add(new ProductOrderItems(product.Title, productPrice));
            }
        }


        private static string GenerateTrackingCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";

            var code = new char[10];
            var random = new Random();

            for (var i = 0; i < 5; i++)
            {
                code[i] = chars[random.Next(chars.Length)];
            }

            for (var i = 5; i < 10; i++)
            {
                code[i] = numbers[random.Next(numbers.Length)];
            }

            return new string(code);
        }

    }
}
