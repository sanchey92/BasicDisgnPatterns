namespace Behavioral.Mediator.MediatorWithEvents
{
    public class Player
    {
        private string _name;
        private Game _game;
        private int _goalsScored = 0 ;

        public Player(string name, Game game)
        {
            _name = name;
            _game = game;
        }

        public void Score()
        {
            _goalsScored++;
            var args = new PlayerScoredEventArgs(_name, _goalsScored);
            _game.Fire(args);
        }
    }
}