using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumberPin()
        {
            var game = new Game();
            var nombre = game.NumberPin(10);
            Assert.IsTrue(nombre > 0);
        }

        [TestMethod]
        public void TestContuneTurn()
        {
            var game = new Game();
            var continueTurn = game.Turn(0, 10);
            Assert.IsTrue(continueTurn);
        }
    }
}