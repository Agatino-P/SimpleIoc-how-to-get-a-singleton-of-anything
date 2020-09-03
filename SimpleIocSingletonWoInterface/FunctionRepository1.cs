using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public class FunctionRepository1 : IFunctionRepository<Entity1>
    {
        Func<string, string, Entity1> _factoryFunction;

        public FunctionRepository1(Func<string, string, Entity1> factoryFunction)
        {
            _factoryFunction = factoryFunction;
        }

        public void Add(string id, string text)
        {
            _factoryFunction(id,text);
        }
    }
}
