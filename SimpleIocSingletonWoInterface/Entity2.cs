﻿using System;

namespace SimpleIocSingletonWoInterface
{
    public class Entity2 : IEntity
    {
        public Entity2(string id, string text)
        {
            $"Entity2.Constructor Id:{id} Text:{text}".DP();
        }

        public bool FromText(string text)
        {
            $"Entity2.FromText-{text}".DP();
            return true;
        }

        public string GetId()
        {
            $"Entity2.GetId".DP();
            return "Entity2.GetId";
        }

        public string ToText(string text)
        {
            $"Entity2.ToText".DP();
            return "Entity2.ToText";
        }
    }
}
