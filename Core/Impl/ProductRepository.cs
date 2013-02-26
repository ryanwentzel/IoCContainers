using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCContainers.Core.Impl
{
    public sealed class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product(1, "Product A", 10.99m),
                new Product(2, "Product B", 19.99m),
                new Product(3, "Product C", 5.99m),
                new Product(4, "Product D", 19.99m),
                new Product(5, "Product E", 25.99m)
            };
        }

        public IEnumerable<Product> GetAll()
        {
            return _products.AsEnumerable();
        }

        public Product Find(Func<Product, bool> predicate)
        {
            return _products.FirstOrDefault(predicate);
        }
    }
}
