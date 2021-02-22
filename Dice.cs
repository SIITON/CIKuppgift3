using System;

namespace CIKuppgift3
{
    public class Dice
    {
        public int _sides;
        public Dice(int sides = 6)
        {
            _sides = sides;
        }

        public int Roll()
        {
            return new Random().Next(1, _sides + 1);
        }
    }
}