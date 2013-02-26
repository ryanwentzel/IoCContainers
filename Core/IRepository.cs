using System;
using System.Collections.Generic;

namespace IoCContainers.Core
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> GetAll();

        T Find(Func<T, bool> predicate);

        void Add(T item);

        void Remove(int id);
    }
}
