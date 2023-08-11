namespace JackDaniels.Core.Entities
{
    public sealed class Product : BaseEntity
    {
        public Product(string title,
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
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public string Description { get; private set; }
        public string ImgUrl { get; private set; }
        public decimal FixedPrice { get; private set; }
        public decimal PricePerKg { get; private set; }

    }
}
