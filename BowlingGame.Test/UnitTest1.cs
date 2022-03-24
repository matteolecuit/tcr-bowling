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
    }
}