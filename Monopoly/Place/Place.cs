using System.Collections.Generic;

namespace Monopoly.Place
{
    public class Place
    {
        public string Name { get; }

        public Place(string name)
        {
            Name = name;
        }

        public IEnumerable<Action.Action> GetActions()
        {
            return new Action.Action[] { };
        }
    }
}
