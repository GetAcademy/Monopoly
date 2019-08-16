using Monopoly.Place;

namespace Monopoly
{
    public class Board
    {
        private Place.Place[] _places;

        public Board()
        {
            _places = new Place.Place[]
            {
                new Place.Place("Start"),
                new BuildableProperty("Parkveien"),
            };
        }
    }
}
