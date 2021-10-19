using System;

namespace Behavioral.State.Classic
{
    public class OffState : State
    {
        public OffState()
        {
            Console.WriteLine("Turned light off");
        }

        public override void On(Switch sw)
        {
            Console.WriteLine("Turning light on...");
            sw.State = new OnState(); 
        }
    }
}