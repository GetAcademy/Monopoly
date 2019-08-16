namespace Monopoly.Places
{
    public class BuildableProperty : Property
    {
        public Combination Combination { get; set; }

        public BuildableProperty(string name, int price) : base(name, price)
        {
            
        }
    }
}
