
namespace IoCContainers.Core
{
    public sealed class Product : IEntity
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public Product(int id, string name, decimal price)
        {
            Ensure.ArgumentNotNull(name, "name");

            Id = id;
            Name = name;
            Price = price;
        }
    }
}
