using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public class Derived2 : AbstractBaseClass
    {
        public string Text { get; private set; }

        public Derived2(string id, string text) : base(id, text)
        {
            Text = text;
        }

        public override bool FromText(string text)
        {
            $"Derived2.FromText {text}".DP();
            return true;
        }

        public override string ToText()
        {
            "Derived2.ToText".DP();
            return $"Derived2.ToText -Id:{Id} Text:{Text}";
        }
    }
}
