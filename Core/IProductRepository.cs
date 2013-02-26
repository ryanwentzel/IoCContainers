using System;
using System.Collections.Generic;

namespace IoCContainers.Core
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        Product Find(Func<Product, bool> predicate);
    }
}
