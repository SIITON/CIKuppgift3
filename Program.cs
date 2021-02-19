using System;

namespace CIKuppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play guess the dice");
            IDice dice = new GameOfDice(LetUserDefineDiceSides());
            Console.WriteLine(dice.Result);
            dice.RollNext();
            Console.WriteLine(dice.Result);


        }

        private static int LetUserDefineDiceSides()
        {
            Console.WriteLine("How many sides should the dice have?");
            var userInput = Console.ReadLine();
            int sides = 6;
            try
            {
                sides = int.Parse(userInput);
                if (sides <= 0)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input must be a positive integer! Default value of six sides will be used.");
            }
            return sides;
        }
    }
}
