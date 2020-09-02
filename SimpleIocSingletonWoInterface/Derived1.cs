using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public class Derived1 : AbstractBaseClass
    {
        public string Text { get; private set; }
        
        public Derived1(string id, string text) : base(id, text)
        {
            Text = text;
        }

        public override bool FromText(string text)
        {
            $"Derived1.FromText {text}".DP();
            return true;
        }

        public override string ToText()
        {
            "Derived1.ToText".DP();
            return $"Derived1.ToText -Id:{Id} Text:{Text}";
        }
    }
}
