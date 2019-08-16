using System.Collections.Generic;
using Monopoly.Actions;

namespace Monopoly.Places
{
    public class Place
    {
        public string Name { get; }

        public Place(string name)
        {
            Name = name;
        }

        public virtual IEnumerable<Action> GetActions()
        {
            return new Action[] { };
        }
    }
}
