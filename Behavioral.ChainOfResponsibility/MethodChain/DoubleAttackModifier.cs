using System;

namespace Behavioral.ChainOfResponsibility.MethodChain
{
    public class DoubleAttackModifier : CreatureModifier
    {
        public DoubleAttackModifier(Creature creature) : base(creature)
        { }

        public override void Handle()
        {
            Console.WriteLine($"Doubling {_creature.Name}'s attack");
            _creature.Attack *= 2;
            base.Handle();
        }
    }
}