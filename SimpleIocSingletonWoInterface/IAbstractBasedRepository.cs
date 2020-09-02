using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public interface IAbstractBasedRepository<T> where T:AbstractBaseClass
    {
        void TestMethod(string text);
    }
}
