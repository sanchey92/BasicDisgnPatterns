
using System;
using Behavioral.ChainOfResponsibility.BrokerChain;

namespace Behavioral.ChainOfResponsibility
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var game = new Game();
            var goblin = new BrokerCreature(game, "Strong Goblin", 2, 2);
            Console.WriteLine(goblin);

            using (new BrokerDoubleAttackModifier(game, goblin))
            {
                Console.WriteLine(goblin);
            }

            Console.WriteLine(goblin);
        }
    }
}