namespace StoreApp.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name required");
            if (price <= 0) throw new ArgumentException("Price must be positive");

            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }
        public void UpdatePrice(decimal newPrice)
        {
            if (newPrice <= 0) throw new ArgumentException("Price must be positive");
            Price = newPrice;
        }
    }
}
