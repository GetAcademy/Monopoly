namespace Monopoly.Places
{
    public class Property : Place
    {
        private int _price;

        public Property(string name, int price) : base(name)
        {
            _price = price;
        }
    }
}
