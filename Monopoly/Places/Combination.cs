namespace Monopoly.Places
{
    public class Combination
    {
        private BuildableProperty[] _properties;

        public Combination(params BuildableProperty[] properties)
        {
            _properties = properties;
            foreach (var property in properties)
            {
                property.Combination = this;
            }
        }
    }
}
