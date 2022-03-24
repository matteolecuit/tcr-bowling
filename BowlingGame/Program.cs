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

        public bool Turn(int NumberOfTurn, int NumberOfPin)
        {
            return true;
        }

        public int NumberPin(int NumberOfPin)
        {
            return new Random().Next(0, NumberOfPin);
        }

        public bool ShouldContinueTurn(int numberOfRemainingPins, int turn)
        {
            if (turn < 2 && numberOfRemainingPins > 0) return true;
            return false;
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

