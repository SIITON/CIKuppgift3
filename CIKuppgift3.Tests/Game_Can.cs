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
    }
}
