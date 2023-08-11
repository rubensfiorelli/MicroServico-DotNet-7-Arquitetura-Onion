using JackDaniels.Core.Entities;
using JackDaniels.Core.ValueObject;

namespace JackDaniels.Application.InputModels
{
    public class AddProductOrderInputModel
    {
        public string Description { get; set; }
        public decimal WeigthInKg { get; set; }
        public Guid DeliveryAddressId { get; set; }
        public List<ProductInputModel> Products { get; set; }

        public ProductOrder ToEntity()
            => new ProductOrder(

                Description,
                WeigthInKg,
                DeliveryAddressId
                );

    }

    public class DeliveryAddressInputModel
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public DeliveryAddress ToValueObject()
            => new DeliveryAddress(Street, Number, Complement, ZipCode, City, State);
    }

    public class ProductInputModel
    {
        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public string ImgUrl { get; private set; }
        public decimal FixedPrice { get; private set; }
        public decimal PricePerKg { get; private set; }

        public Product ToEntity()
            => new Product(Title, Price, Description, ImgUrl, FixedPrice, PricePerKg);
    }


}
