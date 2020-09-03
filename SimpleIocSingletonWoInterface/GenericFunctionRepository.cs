using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public class GenericFunctionRepository<T> : IFunctionRepository<T> where T:IEntity
    {
        Func<string, string, T> _factoryFunction;

        public GenericFunctionRepository(Func<string, string, T> factoryFunction)
        {
            _factoryFunction = factoryFunction;
        }

        public void Add(string id, string text)
        {
            _factoryFunction(id, text);
        }
    }
}
