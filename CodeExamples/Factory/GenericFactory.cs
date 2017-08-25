using System;
using System.Collections.Generic;

namespace CodeExamples.Factory
{
    public class GenericFactory<K, T> where K : IComparable
    {
        Dictionary<K, IGenericFactoryElement> _elements = new Dictionary<K, IGenericFactoryElement>();

        public void Add<V>(K key) where V : T, new()
        {
            _elements.Add(key, new GenericFactoryElement<V>());
        }

        public T Create(K key)
        { 
            if(_elements.ContainsKey(key))
                return (T) _elements[key].New();

            throw new ArgumentException("key not found");
        }
    }
}