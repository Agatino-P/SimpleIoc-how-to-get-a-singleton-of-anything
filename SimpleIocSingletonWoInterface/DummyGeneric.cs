using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public class DummyGeneric<T, I> where T: I
    {
        public DummyGeneric(string text)
        {
            typeof(T).ToString().DP();
            text.DP();
        }
    }
}
