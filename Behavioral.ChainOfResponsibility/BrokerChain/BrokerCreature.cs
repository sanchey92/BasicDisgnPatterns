namespace Behavioral.ChainOfResponsibility.BrokerChain
{
    public class BrokerCreature
    {
        private readonly Game _game;
        public string Name;
        private int _attack;
        private int _defence;

        public BrokerCreature(Game game, string name, int attack, int defence)
        {
            _game = game;
            Name = name;
            _attack = attack;
            _defence = defence;
        }

        public int Attack
        {
            get
            {
                var q = new Query(Name, Query.Argument.Attack, _attack);
                _game.PerformQuery(this, q);
                return q.Value;
            }
        }

        public int Defense
        {
            get
            {
                var q = new Query(Name, Query.Argument.Defense, _defence);
                _game.PerformQuery(this, q);
                return q.Value;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, " +
                   $"{nameof(Attack)}: {Attack}, " +
                   $"{nameof(Defense)}: {Defense}";
        }
    }
}