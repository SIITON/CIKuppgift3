using System;
using System.Collections.Generic;
using System.Linq;

namespace CIKuppgift3
{
    public class Dice
    {
        public int _sides;
        public Dice(int sides = 6)
        {
            _sides = sides;
        }
        public IEnumerable<int> Roll()
        {
            var num = new Random().Next(1, _sides + 1)
                                  .ToString();
            return num.Select(x => int.Parse(x.ToString()));
        }
    }
}