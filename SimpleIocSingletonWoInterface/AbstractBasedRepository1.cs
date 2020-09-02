using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public class AbstractBasedRepository1 : IAbstractBasedRepository<Derived1>
    {
        public AbstractBasedRepository1()
        {
            "AbstractBasedRepository1.Constructor".DP();
        }

        public void TestMethod(string text)
        {
            Derived1 derived1 = new Derived1("I1", "T1");
            $"AbstractBasedRepository1 - text: {text} - {derived1.ToText()}".DP();
        }
    }
}
