using System;
using System.Collections;
using System.Collections.Generic;

namespace PostalSystem
{
    public delegate bool GenericFilterDelegate<T>(T item);

    public class Repository<T> : IEnumerable<T> where T : IEntity
    {
        private List<T> _items = new List<T>();

        public void Add<U>(U item) where U : T
        {
            _items.Add(item);
        }

        public IEnumerable<T> Filter(GenericFilterDelegate<T> filter)
        {
            foreach (var item in _items)
            {
                if (filter(item))
                {
                    yield return item;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}