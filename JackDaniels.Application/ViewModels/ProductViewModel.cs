using JackDaniels.Core.Entities;

namespace JackDaniels.Application.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(Guid id,
           string title,
           decimal price,
           string description,
           string imgUrl,
           decimal fixedPrice,
           decimal pricePerKg) : base()
        {
            Title = title;
            Price = price;
            Description = description;
            ImgUrl = imgUrl;
            FixedPrice = fixedPrice;
            PricePerKg = pricePerKg;
            Id = id;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public string ImgUrl { get; private set; }
        public decimal FixedPrice { get; private set; }
        public decimal PricePerKg { get; private set; }

        public static ProductViewModel FromEntity(Product product)
        {
            return new ProductViewModel(product.Id,
                                        product.Title,
                                        product.Price,
                                        product.Description,
                                        product.ImgUrl,
                                        product.FixedPrice,
                                        product.PricePerKg);
        }
    }
}
