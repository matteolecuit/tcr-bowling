﻿// See https://aka.ms/new-console-template for more information

namespace BowlingGame
{
    public class TurnAndNumberOfPin
    {
        public int NumberOfPinsRemaining, turn;

        public TurnAndNumberOfPin(int NumberOfPinsRemaining, int turn) {
            this.NumberOfPinsRemaining = NumberOfPinsRemaining;
            this.turn = turn;
        }
    } 
    
    public class Game
    {
        public TurnAndNumberOfPin Draw()
        {
            var response = new TurnAndNumberOfPin(10, 0);
            var should = true;
            while (should)
            {
                
            }
            return response;
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

