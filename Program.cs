using System;

namespace CIKuppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play guess the dice");
            do
            {
                var game = new GameOfDice();
                game.Start();
                game.PresentResults();
            }
            while (GameOfDice.UserWantsToPlay()); 
        }
    }
}
