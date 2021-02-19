using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void Roll_Within_Its_Default_Limits()
        {
            var dice = new Dice();
            for(int i = 0; i < _numberOfRollsPerDiceTest; i++)
            {
                Assert.IsTrue(dice.Roll() <= _default);
            }
        }
        [DataTestMethod]
        [DataRow(10)]
        [DataRow(50)]
        [DataRow(100)]
        public void Roll_Within_Its_Defined_Limits(int sides)
        {
            var dice = new Dice(sides);
            for (int i = 0; i < _numberOfRollsPerDiceTest; i++)
            {
                Assert.IsTrue(dice.Roll() <= sides);
            }
        }
    }
}
