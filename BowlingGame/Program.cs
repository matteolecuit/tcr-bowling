// See https://aka.ms/new-console-template for more information

namespace BowlingGame
{
    public class Game
    {
        public void Draw()
        {
            for (int j = 0; j < 10; j++)
            {
                int pin = 10;
                Console.WriteLine(NumberPin(pin));
            }
        }

        public int NumberPin(int NumberOfPin)
        {
            return new Random().Next(0, NumberOfPin);
        }
    }

    class Program
    {
        static void Main()
        {
            var game = new BowlingGame.Game();
            game.Draw();
        }
    }

}

