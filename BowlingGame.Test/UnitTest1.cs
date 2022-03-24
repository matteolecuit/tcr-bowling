using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDraw()
        {
            var game = new Game();
            var nombre = game.Draw();
        }
    }
}