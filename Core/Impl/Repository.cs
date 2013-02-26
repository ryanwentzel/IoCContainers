using System;
using System.Collections.Generic;
using System.Linq;

namespace IoCContainers.Core.Impl
{
    public sealed class Repository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _items;

        public Repository()
        {
            _items = new List<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _items.AsEnumerable();
        }

        public T Find(Func<T, bool> predicate)
        {
            return _items.FirstOrDefault(predicate);
        }

        public void Add(T item)
        {
            if (_items.Any(i => i.Id == item.Id))
            {
                throw new InvalidOperationException("Item with specified Id already exists.");
            }
        }

        public void Remove(int id)
        {
            var index = _items.FindIndex(i => i.Id == id);
            if (index > -1)
            {
                _items.RemoveAt(index);
            }
        }
    }
}
