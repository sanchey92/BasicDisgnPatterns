namespace Behavioral.ChainOfResponsibility.BrokerChain
{
    public class BrokerDoubleAttackModifier : BrokerCreatureModifier
    {
        public BrokerDoubleAttackModifier(Game game, BrokerCreature creature) 
            : base(game, creature)
        { }

        protected override void Handle(object sender, Query q)
        {
            if (q.CreatureName == _creature.Name &&
                q.WhatToQuery == Query.Argument.Attack)
            {
                q.Value *= 2;
            }
        }
    }
}