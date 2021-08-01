using System;

namespace Behavioral.Mediator.MediatorWithEvents
{
    public class Coach
    {
        private Game _game;

        public Coach(Game game)
        {
            _game = game;

            _game.Events += (sender, args) =>
            {
                if (args is PlayerScoredEventArgs scored && scored.GoalsScoredSoFar < 3)
                {
                    Console.WriteLine($"Coach says: well done, {scored.PlayerName}");
                }
            };
        }
    }
}