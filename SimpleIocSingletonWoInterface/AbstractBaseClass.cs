using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public abstract class AbstractBaseClass
    {
        public readonly string Id;
        protected AbstractBaseClass(string id, string text)
        {
            Id = id;
            FromText(text);
        }
        
        public  abstract bool FromText(string text);
        public abstract string ToText();

    }
}
