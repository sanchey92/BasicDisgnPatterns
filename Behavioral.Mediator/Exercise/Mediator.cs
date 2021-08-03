using System;

namespace Behavioral.Mediator.Exercise
{
    public class Mediator
    {
        public event EventHandler<int> Alert;

        public void Broadcast(object sender, int n)
        {
            Alert?.Invoke(sender, n);
        }
    }
}