using System;

namespace Behavioral.Mediator.MediatorWithEvents
{
    public class Game
    {
        public event EventHandler<GameEventArgs> Events;

        public void Fire(GameEventArgs args)
        {
            Events?.Invoke(this, args);
        }
    }
}