using System.Collections.Generic;
using System.Linq;
using Monopoly.Actions;

namespace Monopoly.Places
{
    public class BuildableProperty : Property
    {
        public Combination Combination { get; set; }
        public int Houses { get; private set; }

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

        public override int GetRent()
        {
            var oneHouseRent = base.GetRent();
            var hasWholeCombination = Combination.IsAllOwnedBy(Game.Instance.CurrentPlayer);
            var combinationFactor = hasWholeCombination ? 2 : 1;
            return oneHouseRent * Houses * combinationFactor;
        }
    }
}
