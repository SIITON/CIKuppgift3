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
            while (UserWantsToPlay()); 
        }

        private static bool UserWantsToPlay()
        {
            Console.WriteLine("Play again? (Y/n)");
            var userInput = Console.ReadLine();
            var result = false;
            switch (userInput)
            {
                case "Y":
                    result = true;
                    break;
                case "y":
                    result = true;
                    break;
                case "N":
                    result = false;
                    break;
                case "n":
                    result = false;
                    break;
                default:
                    Console.WriteLine("?? Whatever, shutting down");
                    result = false;
                    break;
            }
            return result;
        }
    }
}
