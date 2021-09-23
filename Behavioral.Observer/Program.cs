using System;
using Behavioral.Observer.Observer.Events;

namespace Behavioral.Observer
{
    public static class Program
    {
        private static void Main()
        {
            var person = new Person();
            person.FallsIll += PersonOnFallsIll;
            person.CatchACold();
            person.FallsIll -= PersonOnFallsIll;
        }

        private static void PersonOnFallsIll(object? sender, FallsIllEventArgs e)
        {
            Console.WriteLine($"Call a doctor to {e.Address}");
        }
    }
}