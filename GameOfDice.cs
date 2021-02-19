using System;
using CIKuppgift3.Extensions;
namespace CIKuppgift3
{
    public class GameOfDice : IDice, IGuessingGame
    {
        public int Roll => new Dice(Sides).Roll();
        public int Result { get; set; }
        public int Sides { get; set; }
        public int Guess { get; set; }
        public int TotalPoints { get; set; }
        public int Turn { get; set; }
        public bool IsCorrect { get; set; }

        public GameOfDice(int sides = 6)
        {
            Sides = sides;
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
            Console.WriteLine($"Dice has {Sides} possibilities/sides");
            Console.WriteLine("Guess the roll!");
            while (IsCorrect)
            {
                GetUserInput();
                CheckInputAgainstResult();
                RollNext();
            }
        }

        private void CheckInputAgainstResult()
        {
            if (!(Guess == Result))
            {
                Console.WriteLine($"\t Wrong! Dice show {Result}");
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

        public void PresentResults()
        {
            Console.WriteLine($"You got {TotalPoints} points");
        }

        private void GetUserInput()
        {
            Console.Write($"#{Turn} : ");
            try
            {
                Guess = int.Parse(Console.ReadLine());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("That number is way too high...");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You gotta guess something!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Hey! That's not a number");
            }
        }
    }
}