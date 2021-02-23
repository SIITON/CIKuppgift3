using System;
using System.Collections.Generic;
using System.Linq;
using CIKuppgift3.Extensions;

namespace CIKuppgift3
{
    public class GameOfDice : IDice, IGuessingGame
    {
        public IEnumerable<int> Roll => new Dice(Sides).Roll();
        public IEnumerable<int> Result { get; set; }
        public int Sides { get; set; }
        public IEnumerable<int> Guess { get; set; }
        public int TotalPoints { get; set; }
        public int Turn { get; set; }
        public bool IsCorrect { get; set; }



        public GameOfDice()
        {
            Sides = LetUserDefineDiceSides();
            Result = Roll;
            IsCorrect = true;
            Turn = 1;
    }
        public void RollNext()
        {
            Result = Roll;
            Turn++;
        }
        public void Start()
        {
            var ui = new DiceGUI();
            Console.WriteLine("Guess the roll!");
            while (IsCorrect)
            {
                GetUserInput();
                ui.PrintRandomRolls(Sides);
                ui.PrintNumber(Result);
                CheckInputAgainstResult();
                RollNext();
            }
        }

        private void CheckInputAgainstResult()
        {
            int result; int guess;
            if (Int32.TryParse(string.Join("", Enumerable.ToArray(Result)), out result) && Int32.TryParse(string.Join("", Enumerable.ToArray(Guess)), out guess))
            {
                if (!(Guess.SequenceEqual(Result)))
                {
                    Console.WriteLine($"#{Turn}: {guess}\t Wrong! Dice show {result}"); //Enumerable.ToArray(Result)
                    IsCorrect = false;
                }
                else
                {
                    if (!Turn.IsDivisibleBy3())
                    {
                        TotalPoints++;
                    }
                    else
                    {
                        TotalPoints += 3;
                    }
                    Console.WriteLine($"\t Correct! {TotalPoints} points");
                }
            }
            else
            {
                Console.WriteLine("Game broke, sry");
            }
            
            
        }

        public void PresentResults()
        {
            Console.WriteLine($"You got {TotalPoints} points");
        }

        private void GetUserInput()
        {
            Console.Write($"#{Turn} : ");
            try
            {
                var input = Console.ReadLine();
                Guess = input.Select(x => int.Parse(x.ToString()));
            }
            catch (OverflowException)
            {
                Console.WriteLine("That number is way too high...");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You gotta guess something!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Hey! That's not a number");
            }
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
                    Console.WriteLine("?? Whatever, shutting down");
                    result = false;
                    break;
            }
            return result;
        }
    }
}