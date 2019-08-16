using Monopoly.Places;

namespace Monopoly
{
    public class Board
    {
        private Place[] _places;

        public Board()
        {
            var parkveien = new BuildableProperty("Parkveien", 1200);
            var kirkeveien = new BuildableProperty("Kirkeveien", 1200);

            var kongensGate = new BuildableProperty("Kongens gate", 2000);
            var prinsensGate = new BuildableProperty("Prinsens gate", 2000);
            var øvreSlottsgate = new BuildableProperty("Øvre Slottsgate", 2400);

            var nedreSlottsgate = new BuildableProperty("Nedre Slottsgate", 2800);
            var trondheimsveien = new BuildableProperty("Trondheimsveien", 2800);
            var nobelsGate = new BuildableProperty("Nobels Gate", 3200);

            var grensen = new BuildableProperty("Grensen", 3600);
            var gabelsGate = new BuildableProperty("Gabels gate", 3600);
            var ringgata = new BuildableProperty("Ringgata", 4000);

            var bygdøyAlle = new BuildableProperty("Bygdøy Allé", 4400);
            var skarpsno = new BuildableProperty("Skarpsno", 4400);
            var slemdal = new BuildableProperty("Slemdal", 4800);

            var karlJohansGate = new BuildableProperty("Karl Johans Gate", 5200);
            var stortorget = new BuildableProperty("Stortorget", 5200);
            var torggata = new BuildableProperty("Torggata", 5600);

            var trosterudveien = new BuildableProperty("Trosterudveien", 6000);
            var pilestredet = new BuildableProperty("Pilestredet", 6000);
            var sinsen = new BuildableProperty("Sinsen", 6400);

            var ullevålHageby = new BuildableProperty("Ullevål Hageby", 7000);
            var rådhusplassen = new BuildableProperty("Rådhusplassen", 0800);


            _places = new Place[]
            {
                new Place("Start"),
                parkveien,
                new Place("Prøv lykken"),
                kirkeveien,
                new Place("Betal skatt"),
                new Property("Oslo S", 4000),
            };
        }
    }
}
