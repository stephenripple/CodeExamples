
namespace CodeExamples.Factory
{
    internal class GenericFactoryElement<T> : IGenericFactoryElement where T : new()
    {
        public object New()
        {
            return new T();
        }
    }
}