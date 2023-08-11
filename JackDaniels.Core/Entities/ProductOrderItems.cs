namespace JackDaniels.Core.Entities
{
    public sealed class ProductOrderItems : BaseEntity
    {
        public ProductOrderItems(string title, decimal price) : base()
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
    }
}
