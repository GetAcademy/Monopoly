using System;

namespace Monopoly
{
    public class Die
    {
        private readonly Random _random;

        public Die()
        {
            _random = new Random();
        }

        public int Roll()
        {
            return _random.Next(1, 7);
        }
    }
}
