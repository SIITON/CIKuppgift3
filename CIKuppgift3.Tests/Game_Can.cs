using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CIKuppgift3.Tests
{
    [TestClass]
    public class Game_Can
    {
        private GameOfDice Game = new GameOfDice("");
        [TestInitialize]
        public void Setup()
        {
            Game.RollDice();
        }
        [TestMethod]
        public void AddExtraPointsAfterThreeCorrectAnswers()
        {
            Assert.AreEqual(1, Game.Turn);
            for(var i = 0; i < 3; i++)
            {
                Game.AddPoints();
                Game.RollDice();
            }
            Assert.AreEqual(4, Game.Turn);
            Assert.AreEqual(5, Game.TotalPoints);
        }
        [DataTestMethod]
        [DataRow(1, 2)]
        [DataRow(5, 10)]
        [DataRow(32, 33)]
        public void Determine_If_User_Is_Correct_When_Guessing_Higher(int lowroll, int highroll)
        {
            Game.LastRoll = lowroll;
            Game.NewRoll = highroll;

            Game.UserGuessHigher = true;
            Game.CheckGuessAgainstNewRoll();
            Assert.IsTrue(Game.UserIsCorrect);
        }
        [DataTestMethod]
        [DataRow(1, 2)]
        [DataRow(5, 10)]
        [DataRow(32, 33)]
        public void Determine_If_User_Is_Correct_When_Guessing_Lower(int lowroll, int highroll)
        {
            Game.LastRoll = highroll;
            Game.NewRoll = lowroll;

            Game.UserGuessHigher = false;
            Game.CheckGuessAgainstNewRoll();
            Assert.IsTrue(Game.UserIsCorrect);
        }
        [DataTestMethod]
        [DataRow(1, 2)]
        [DataRow(5, 10)]
        [DataRow(32, 33)]
        public void Determine_If_User_Is_Wrong_When_Guessing_Higher(int lowroll, int highroll)
        {
            Game.LastRoll = highroll;
            Game.NewRoll = lowroll;
            Game.UserGuessHigher = true;
            Game.CheckGuessAgainstNewRoll();
            Assert.IsFalse(Game.UserIsCorrect);
        }
        [DataTestMethod]
        [DataRow(1, 2)]
        [DataRow(5, 10)]
        [DataRow(32, 33)]
        public void Determine_If_User_Is_Wrong_When_Guessing_Lower(int lowroll, int highroll)
        {
            Game.LastRoll = lowroll;
            Game.NewRoll = highroll;
            Game.UserGuessHigher = false;
            Game.CheckGuessAgainstNewRoll();
            Assert.IsFalse(Game.UserIsCorrect);
        }
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(5)]
        [DataRow(32)]
        public void Determine_If_User_Is_Wrong_When_Roll_Is_Equal(int roll)
        {
            Game.LastRoll = roll;
            Game.NewRoll = Game.LastRoll;

            Game.UserGuessHigher = true;
            Game.CheckGuessAgainstNewRoll();
            Assert.IsFalse(Game.UserIsCorrect);

            Game.UserGuessHigher = false;
            Game.CheckGuessAgainstNewRoll();
            Assert.IsFalse(Game.UserIsCorrect);
        }

    }
}
