using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public class Repository2 : IRepository<Entity2, IEntity>
    {
        public Repository2(string text)
        {
            $"Repository2.Constructor - {text}".DP();
        }

        public bool FromText(string text)
        {
            $"Repository2.FromText- {text}".DP();
            return true;
        }

        public string GetId()
        {
            "Repository2.GetId".DP();
            return "Repository2.GetId";
        }

        public string ToText(string text)
        {
            "Repository2.ToText".DP();
            return "Repository2.ToText";
        }
    }
}
