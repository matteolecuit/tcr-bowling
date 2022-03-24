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
        public void TestShouldContinueTurn()
        {
            var game = new Game();
            var continueTurn1 = game.ShouldContinueTurn(10, 0);
            var continueTurn2 = game.ShouldContinueTurn(10, 1);
            var continueTurn3 = game.ShouldContinueTurn(10, 2);
            var continueTurn4 = game.ShouldContinueTurn(0, 1);
            Assert.IsTrue(continueTurn1);
            Assert.IsTrue(continueTurn2);
            Assert.IsFalse(continueTurn3);
            Assert.IsFalse(continueTurn4);
        }
    }
}