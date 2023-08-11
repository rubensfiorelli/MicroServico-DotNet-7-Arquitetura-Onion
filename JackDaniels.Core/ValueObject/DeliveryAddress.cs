using JackDaniels.Core.Entities;

namespace JackDaniels.Core.ValueObject
{

    public sealed class DeliveryAddress : BaseEntity
    {
        public DeliveryAddress(string street, int number, string complement, string zipCode, string city, string state)
        {
            Street = street;
            Number = number;
            Complement = complement;
            ZipCode = zipCode;
            City = city;
            State = state;
        }

        public string Street { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public List<ProductOrder> Orders { get; set; }
    }
}
