using System;

namespace Behavioral.Observer.ContainerWireup
{
    public class Logging : IHandle<ButtonPressedEvent>
    {
        public void Handle(object sender, ButtonPressedEvent args)
        {
            Console.WriteLine(
                $"Button clicked {args.NumberOfClicks} times");
        }
    }
}