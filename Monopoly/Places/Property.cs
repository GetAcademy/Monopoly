using System.Collections.Generic;
using Monopoly.Actions;

namespace Monopoly.Places
{
    public class Property : Place
    {
        private int _price;
        public Player Owner { get; set; }

        public Property(string name, int price) : base(name)
        {
            _price = price;
        }

        public override IEnumerable<Action> GetActions()
        {
            var actions = new List<Action>();

            if (Owner == null) actions.Add(new BuyAction());
            else actions.Add(new PayRentAction());
            
            return actions;
        }
    }
}
