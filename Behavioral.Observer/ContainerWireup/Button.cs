using System;

namespace Behavioral.Observer.ContainerWireup
{
    public class Button : ISend<ButtonPressedEvent>
    {
        public event EventHandler<ButtonPressedEvent> Sender;

        public void Fire(int clicks)
        {
            Sender?.Invoke(this, new ButtonPressedEvent {NumberOfClicks = clicks});
        }
    }
}