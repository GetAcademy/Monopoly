using Monopoly.Places;

namespace Monopoly
{
    public class Board
    {
        private Place[] _places;
        private Combination[] _combinations;

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
            var rådhusplassen = new BuildableProperty("Rådhusplassen", 8000);

            _combinations = new Combination[]
            {
                new Combination(parkveien, kirkeveien), 
                new Combination(kongensGate, prinsensGate, øvreSlottsgate), 
                new Combination(nedreSlottsgate, trondheimsveien, nobelsGate), 
                new Combination(grensen, gabelsGate, ringgata), 
                new Combination(bygdøyAlle, skarpsno, slemdal), 
                new Combination(karlJohansGate, stortorget, torggata), 
                new Combination(trosterudveien, pilestredet, sinsen), 
                new Combination(ullevålHageby, rådhusplassen), 
            };
            _places = new Place[]
            {
                new Place("Start"),
                parkveien,
                new Place("Prøv lykken"),
                kirkeveien,
                new Place("Betal skatt"),
                new Property("Oslo S", 4000),
                kongensGate,
                new Place("Sjanse"),
                prinsensGate,
                øvreSlottsgate,
                new Place("Fengsel"),
                nedreSlottsgate,
                new Property("Oslo Lysverker", 3000),
                trondheimsveien,
                nobelsGate,
                new Property("Skøyen stasjon", 4000),
                grensen,
                new Place("Prøv lykken"),
                gabelsGate,
                ringgata,
                new Place("Gratis Parkering"),
                bygdøyAlle,
                new Place("Sjanse"),
                skarpsno,
                slemdal,
                new Property("Grorud stasjon", 4000),
                karlJohansGate,
                stortorget,
                new Property("Vannverket", 3000),
                torggata,
                new Place("De settes i fengsel"),
                trosterudveien,
                pilestredet,
                new Place("Prøv lykken"),
                sinsen,
                new Property("Bryn stasjon", 4000),
                new Place("Sjanse"),
                ullevålHageby,
                new Place("Luksusskatt"),
                rådhusplassen
            };
        }

        public Place Move(int number)
        {
            
        }
    }
}
