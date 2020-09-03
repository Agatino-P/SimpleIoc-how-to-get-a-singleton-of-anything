using System;

namespace SimpleIocSingletonWoInterface
{
    public class Entity1 : IEntity
    {
        public readonly string Id;
        public string Text { get; private set; }

        public Entity1(string id, string text)
        {
            $"Entity1.Constructor Id:{id} Text:{text}".DP();
        }

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
