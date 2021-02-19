using System;
namespace CIKuppgift3
{
    public class GameOfDice : IDice
    {
        public int Roll => new Dice(Sides).Roll();
        public int Result { get; set; }
        public int Sides { get; set; }

        public GameOfDice(int sides = 6)
        {
            Sides = sides;
            Result = Roll;
        }
        public void RollNext()
        {
            Result = Roll;
        }
    }
}