// See https://aka.ms/new-console-template for more information

namespace BowlingGame
{
    public class TurnAndNumberOfPin
    {
        public int score, turn;

        public TurnAndNumberOfPin(int score, int turn)
        {
            this.score = score;
            this.turn = turn;
        }
    }

    public class Game
    {
        public TurnAndNumberOfPin Draw()
        {
            var maxPin = 10;
            var turn = 0;
            var pins = maxPin;
            var should = true;
            while (should)
            {
                pins = NumberPin(pins);
                should = ShouldContinueTurn(pins, turn);
                if (should)
                {
                    turn++;
                }
            }
            Console.WriteLine(turn);
            var response = new TurnAndNumberOfPin((maxPin - pins), turn);
            return response;
        }

        public int NumberPin(int NumberOfPin)
        {
            return new Random().Next(0, NumberOfPin + 1);
        }

        public bool ShouldContinueTurn(int numberOfRemainingPins, int turn)
        {
            if (turn < 1 && numberOfRemainingPins > 0) return true;
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

