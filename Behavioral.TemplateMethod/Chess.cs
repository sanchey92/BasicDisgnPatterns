using System;

namespace Behavioral.TemplateMethod
{
    public class Chess : Game
    {
        private int _turn = 1;
        private const int _maxTurn = 10;

        public Chess() : base(2)
        {
        }

        protected override void Start()
        {
            Console.WriteLine($"Starting a game of chess with " +
                              $"{numbersOfPlayers} players");
        }

        protected override void TakeTurn()
        {
            Console.WriteLine($"Turn {_turn++} taken by player {currentPlayer}");
            currentPlayer = (currentPlayer + 1) % numbersOfPlayers;
        }

        protected override bool HaveWinner => _turn == _maxTurn;
        protected override int WinningPlayer => currentPlayer;
    }
}