using System;
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
            Assert.IsTrue(nombre >= 0);
        }

        [TestMethod]
        public void TestShouldContinueTurn()
        {
            var game = new Game();
            var continueTurn1 = game.ShouldContinueTurn(10, 0);
            var continueTurn2 = game.ShouldContinueTurn(10, 1);
            var continueTurn3 = game.ShouldContinueTurn(0, 1);
            Assert.IsTrue(continueTurn1);
            Assert.IsFalse(continueTurn2);
            Assert.IsFalse(continueTurn3);
        }

        [TestMethod]
        public void TestDraw()
        {
            var game = new Game();
            var score = game.Draw();
            
            Console.WriteLine(score);
            Assert.IsTrue(score.score <=10 && score.score >=0);
            if (score.turn == 0)
            {
                Assert.IsTrue(score.score == 0);
            }
            Assert.IsTrue(score.turn == 0 || score.turn == 1);
        }
    }
}