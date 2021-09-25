using System;
using System.Reactive.Linq;
using Behavioral.Observer.ObserverInterfaces;

namespace Behavioral.Observer
{
    public class Program : IObserver<Event>
    {
        public Program()
        {
            var person = new Person();
            var sub = person.Subscribe(this);

            //  // person.OfType<FallsIllEvent>()
            //     .Subscribe(args => // OnNext
            //         Console.WriteLine($"We need a doctor to {args.Address}"));

            person.CatchACold();
        }

        public static void Main()
        {
            new Program();
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Event value)
        {
            if (value is FallsIllEvent args)
            {
                Console.WriteLine($"Call doctor to {args.Address}");
            }
        }
    }
}