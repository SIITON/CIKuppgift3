using CIKuppgift3.Extensions;
using System;
using System.Linq;

namespace CIKuppgift3
{
    public class GameOfDice
    {
        private int _defaultSides = 6;
        private int _defaultExtraPoints = 3;
        public int Extrapoints { get; set; }
        public int LastRoll { get; set; }
        public int NewRoll { get; set; }
        public int Sides { get; set; }
        public bool UserIsCorrect { get; private set; }
        public int Turn { get; private set; }
        public bool UserGuessHigher { get; set; }
        public int TotalPoints { get; private set; }

        public GameOfDice(string args)
        {
            switch (args)
            {
                case "user-defined":
                    Sides = LetUserDefineDiceSides();
                    break;
                default:
                    Sides = _defaultSides;
                    break;
            }
            RollDice();
            Turn = 0;
            Extrapoints = _defaultExtraPoints;
            UserIsCorrect = true;
        }

        public void Start()
        {
            var ui = new DiceGUI();
            while (UserIsCorrect)
            {
                RollDice();
                Console.WriteLine($"Dice show {LastRoll}");
                Console.WriteLine("Will the next roll be higher or lower? (H/L)");
                UserGuessHigher = GetUserGuess();
                ui.PrintRandomRolls(Sides);
                ui.PrintNumber(NewRoll);
                CheckGuessAgainstNewRoll();
            }
        }

        public void CheckGuessAgainstNewRoll()
        {
            if (UserGuessHigher == (NewRoll > LastRoll) && NewRoll != LastRoll)
            {
                AddPoints();
                Console.WriteLine($"#{Turn}:\t Correct! You have {TotalPoints} points");
                UserIsCorrect = true;
            }
            else
            {
                Console.WriteLine($"#{Turn}:\t Wrong! Dice show {NewRoll}, previous roll was {LastRoll}");
                UserIsCorrect = false;
            }
        }

        public void AddPoints()
        {
            if (!Turn.IsDivisibleBy3())
            {
                TotalPoints++;
            }
            else
            {
                TotalPoints += Extrapoints;
            }
        }

        private bool GetUserGuess()
        {
            Console.Write($"#{Turn} : ");
            var guess = Console.ReadLine();
            bool result;
            switch (guess)
            {
                case "H":
                    result = true;
                    break;
                case "h":
                    result = true;
                    break;
                case "L":
                    result = false;
                    break;
                case "l":
                    result = false;
                    break;
                default:
                    Console.WriteLine("Couldn't interpret that response, guess by typing 'H' or 'L'. Default guess of lower will be used.");
                    result = false;
                    break;
            }
            return result;
        }

        public void RollDice()
        {
            LastRoll = NewRoll;
            NewRoll = new Random().Next(1, Sides + 1);
            Turn++;
        }

        public void PresentResults()
        {
            Console.WriteLine($"You got {TotalPoints} points");
        }
        private int LetUserDefineDiceSides()
        {
            Console.WriteLine("How many sides should the dice have?");
            var userInput = Console.ReadLine();
            int sides = _defaultSides;
            try
            {
                sides = int.Parse(userInput);
                if (sides <= 0)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input must be a positive integer! Default value will be used.");
            }
            finally
            {
                Console.WriteLine($"Dice has {sides} possibilities/sides");
            }
            return sides;
        }
        public static bool UserWantsToPlay()
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
                    Console.WriteLine("Ok, rage quitting.");
                    result = false;
                    break;
            }
            return result;
        }
    }
}