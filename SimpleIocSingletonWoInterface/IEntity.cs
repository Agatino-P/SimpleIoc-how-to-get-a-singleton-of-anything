using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public interface IEntity
    {
        string GetId();
        bool FromText(string text);
        string ToText(string text);
    }
}
