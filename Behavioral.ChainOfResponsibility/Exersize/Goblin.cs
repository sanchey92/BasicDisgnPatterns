using System;

namespace Behavioral.ChainOfResponsibility.Exersize
{
    public class Goblin : Creature
    {
        public override void Query(object source, StatQuery sq)
        {
            if (ReferenceEquals(source, this))
            {
                switch (sq.Statistic)
                {
                    case Statistic.Attack:
                        sq.Result += _baseAttack;
                        break;
                    case Statistic.Defense:
                        sq.Result += _baseDefense;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                if (sq.Statistic == Statistic.Defense)
                    sq.Result++;
            }
        }

        public override int Defense
        {
            get
            {
                var q = new StatQuery {Statistic = Statistic.Defense};
                foreach (var creature in _game.Creatures)
                {
                    creature.Query(this, q);
                }

                return q.Result;
            }
        }

        public override int Attack
        {
            get
            {
                var q = new StatQuery {Statistic = Statistic.Attack};
                foreach (var creature in _game.Creatures)
                {
                    creature.Query(this, q);
                }

                return q.Result;
            }
        }

        public Goblin(Game game) : base(game, 1, 1) {}

        protected Goblin(Game game, int baseAttack, int baseDefense) : base(game, baseAttack, baseDefense)
        { }
    }
}