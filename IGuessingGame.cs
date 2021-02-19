using System;
using System.Collections.Generic;
using System.Text;

namespace CIKuppgift3
{
    public interface IGuessingGame
    {
        // Properties of a guessing game
        int Guess { get; set; }
        int TotalPoints { get; set; }
        int Turn { get; }
        bool IsCorrect { get; set; }
    }
}