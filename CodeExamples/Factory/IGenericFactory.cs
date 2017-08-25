using System;

namespace CodeExamples.Factory
{
    internal interface IGenericFactory<K, T> where K : IComparable
    {
        T Create();
    }
}
