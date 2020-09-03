using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public interface IFunctionRepository<T> where T : IEntity
    {
        void Add(string id, string text);
    }
}
