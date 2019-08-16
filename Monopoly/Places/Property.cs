using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
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
            else if(Game.Instance.CurrentPlayer != Owner) actions.Add(new PayRentAction());

            return actions;
        }
    }
}
