using System;
using Behavioral.ChainOfResponsibility.MethodChain;

namespace Behavioral.ChainOfResponsibility
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var goblin = new Creature("Goblin", 1, 1);
            Console.WriteLine(goblin);

            var root = new CreatureModifier(goblin);

            root.Add(new NoBonusesModifier(goblin));
            root.Add(new DoubleAttackModifier(goblin));
            // root.Add(new DoubleAttackModifier(goblin));
            root.Add(new IncreaseDefenseModifier(goblin)) ;
            
            root.Handle();
            Console.WriteLine(goblin);
        }
    }
}