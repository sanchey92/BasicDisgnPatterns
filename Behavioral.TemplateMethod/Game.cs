using System;

namespace Behavioral.TemplateMethod
{
    public abstract class Game
    {
        protected readonly int numbersOfPlayers;
        protected int currentPlayer;

        public void Run()
        {
            Start();
            while (!HaveWinner)
            {
                TakeTurn();
            }

            Console.WriteLine($"Player {WinningPlayer} wins!");
        }

        protected abstract void Start();
        protected abstract void TakeTurn();
        protected abstract bool HaveWinner  { get; }
        protected abstract int WinningPlayer { get; }

        protected Game(int numbersOfPlayers)
        {
            this.numbersOfPlayers = numbersOfPlayers;
        }
    }
}