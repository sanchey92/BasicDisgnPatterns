namespace Behavioral.Observer.ContainerWireup
{
    public interface IHandle<TEvent> where TEvent : IEvent
    {
        void Handle(object sender, TEvent args);
    }
}