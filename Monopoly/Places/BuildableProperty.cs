using System.Collections.Generic;
using System.Linq;
using Monopoly.Actions;

namespace Monopoly.Places
{
    public class BuildableProperty : Property
    {
        public Combination Combination { get; set; }

        public BuildableProperty(string name, int price) : base(name, price)
        {

        }

        public override IEnumerable<Action> GetActions()
        {
            var actions = base.GetActions().ToList();
            if (Game.Instance.CurrentPlayer == Owner
                && Combination.IsAllOwnedBy(Owner))
                actions.Add(new BuildAction());
            return actions;
        }
    }
}
