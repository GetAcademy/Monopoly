using Monopoly.Places;

namespace Monopoly
{
    public class Board
    {
        private Place[] _places;

        public Board()
        {
            _places = new Place[]
            {
                new Place("Start"),
                new BuildableProperty("Parkveien", 1200),
                new Place("Prøv lykken"),
                new BuildableProperty("Kirkeveien", 1200),
                new Place("Betal skatt"),
                new Place("Betal skatt"),
            };
        }
    }
}
