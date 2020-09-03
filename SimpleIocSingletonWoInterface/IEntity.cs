using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public interface IEntity
    {
        // In C# 7.3 this private is not alowed, then I'd rather have the GetId() 
        //string Id { get; private set; }

        string GetId();
        bool FromText(string text);
        string ToText(string text);
    }
}
