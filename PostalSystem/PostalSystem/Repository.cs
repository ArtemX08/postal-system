using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; 
namespace PostalSystem
{
    public class Repository<T> : IEnumerable<T> where T : IEntity
    {
        private List<T> _items = new List<T>();

        public void Add<U>(U item) where U : T
        {
            _items.Add(item);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public IEnumerable<T> Filter(Func<T, bool> filter)
        {
            return _items.Where(filter);
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