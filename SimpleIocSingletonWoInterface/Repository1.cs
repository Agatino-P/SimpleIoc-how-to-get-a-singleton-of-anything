using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIocSingletonWoInterface
{
    public class Repository1 : IRepository<Entity1, IEntity>
    {
        public Repository1(string text)
        {
            $"Repository1.Constructor - {text}".DP();
        }

        public bool FromText(string text)
        {
            $"Repository1.FromText- {text}".DP();
            return true;
        }

        public string GetId()
        {
            "Repository1.GetId".DP();
            return "Repository1.GetId";
        }

        public string ToText(string text)
        {
            "Repository1.ToText".DP();
            return "Repository1.ToText";
        }
    }
}
