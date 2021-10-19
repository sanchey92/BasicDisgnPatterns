using System;

namespace Behavioral.State.Classic
{
    public class OnState : State
    {
        public OnState()
        {
            Console.WriteLine("Light turned on");
        }

        public override void Off(Switch sw)
        {
            Console.WriteLine("Turning light off...");
            sw.State = new OffState();
        }
    }
}