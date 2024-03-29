﻿using System.Linq;

namespace Monopoly.Places
{
    public class Combination
    {
        private BuildableProperty[] _properties;

        public Combination(params BuildableProperty[] properties)
        {
            _properties = properties;
            foreach (var property in properties)
            {
                property.Combination = this;
            }
        }

        public bool IsAllOwnedBy(Player owner)
        {
            return _properties.All(p => p.Owner == owner);
        }
    }
}
