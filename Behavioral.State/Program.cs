using System;
using Behavioral.State.Classic;

namespace Behavioral.State
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var ls = new Switch();
            ls.On();
            ls.Off();
            ls.Off();
        }
    }
}