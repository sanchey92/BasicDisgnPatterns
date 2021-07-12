using System;

namespace Behavioral.ChainOfResponsibility.BrokerChain
{
    public abstract class BrokerCreatureModifier : IDisposable
    {
        protected Game _game;
        protected BrokerCreature _creature;

        protected BrokerCreatureModifier(Game game, BrokerCreature creature)
        {
            _game = game;
            _creature = creature;
            _game.Queries += Handle;
        }

        protected abstract void Handle(object sender, Query e);
        
        public void Dispose()
        {
            _game.Queries -= Handle;
        }
    }
}