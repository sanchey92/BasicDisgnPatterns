using System;
using DotnetDesignPatterns.Structural.Proxy.SoACompositeProxy;

namespace DotnetDesignPatterns.Structural.Proxy
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var creatures = new BadCreature[100];
            foreach (var creature in creatures)
            {
                creature.X++; // not memory-efficient
            }

            var creatures2 = new Creatures(100);
            foreach (var creature in creatures2)
                creature.X++;
        }
    }
}