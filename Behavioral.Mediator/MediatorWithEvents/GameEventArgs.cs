using System;

namespace Behavioral.Mediator.MediatorWithEvents
{
    public abstract class GameEventArgs : EventArgs
    {
        public abstract void Print();
    }
}