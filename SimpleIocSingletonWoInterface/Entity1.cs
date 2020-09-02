using System;

namespace SimpleIocSingletonWoInterface
{
    public class Entity1 : IEntity
    {
        public bool FromText(string text)
        {
            $"Entity1.FromText-{text}".DP();
            return true;
        }

        public string GetId()
        {
            $"Entity1.GetId".DP();
            return "Entity1.GetId";
        }

        public string ToText(string text)
        {
            $"Entity1.ToText".DP();
            return "Entity1.ToText";
        }
    }
}
