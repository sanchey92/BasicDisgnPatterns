using System;
using Behavioral.Mediator.Exercise;

namespace Behavioral.Mediator
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var mediator = new Exercise.Mediator();
            var p1 = new Participant(mediator);
            var p2 = new Participant(mediator);
            
            p1.Say(2);
            
            Console.WriteLine(p1.Value);
            Console.WriteLine(p2.Value);
            
            p2.Say(4);

            Console.WriteLine(p1.Value);
            Console.WriteLine(p2.Value);
        }
    }
}