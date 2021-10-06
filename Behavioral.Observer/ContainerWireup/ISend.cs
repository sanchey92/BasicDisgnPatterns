using System;

namespace Behavioral.Observer.ContainerWireup
{
    public interface ISend<TEvent> where TEvent : IEvent
    {
        event EventHandler<TEvent> Sender;
    }
}