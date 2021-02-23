using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace CIKuppgift3.Tests
{
    [TestClass]
    public class Dice_Can
    {
        public int _default = 6;
        public int _numberOfRollsPerDiceTest = 10;
        [TestMethod]
        public void Initialize_to_default()
        {
            var dice = new Dice();
            Assert.AreEqual(_default, dice._sides);
        }
        [TestMethod]
        public void Roll_Within_Default_Limits()
        {
            var dice = new Dice();
            for(int i = 0; i < _numberOfRollsPerDiceTest; i++)
            {
                Assert.IsTrue(dice.Roll().Sum() <= _default);
            }
        }
        [DataTestMethod]
        [DataRow(2)]
        [DataRow(10)]
        [DataRow(50)]
        [DataRow(100)]
        public void Roll_Within_Defined_Limits(int sides)
        {
            var dice = new Dice(sides);
            var result = new Random();
            
            var sum = 0.0;
            for (int i = 0; i < _numberOfRollsPerDiceTest; i++)
            {
                var num = dice.Roll().Sum();
                Assert.IsTrue(num <= sides);
                Assert.IsTrue(num >= 1);
                sum += num;
            }
            double avg = sum / 10;
            
            Assert.IsTrue(avg > 1);

        }
    }
}
