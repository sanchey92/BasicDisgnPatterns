using System;
using Behavioral.Iterator.ArrayBackedProperties;

namespace Behavioral.Iterator
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var creature = new Creature
            {
                Strength = 10,
                Intelligence = 11,
                Agility = 12
            };

            Console.WriteLine($"Max stat = {creature.MaxStat}, " +
                              $"avg stat = {creature.AverageStat}, " +
                              $"sum of stats = {creature.SumOfStats}");
        }
    }
}