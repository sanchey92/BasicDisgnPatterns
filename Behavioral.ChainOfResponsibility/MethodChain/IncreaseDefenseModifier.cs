using System;

namespace Behavioral.ChainOfResponsibility.MethodChain
{
    public class IncreaseDefenseModifier : CreatureModifier
    {
        public IncreaseDefenseModifier(Creature creature) : base(creature)
        { }

        public override void Handle()
        {
            if (_creature.Attack <= 2)
            {
                Console.WriteLine($"Increasing {_creature.Name}'s defense");
                _creature.Defense++;
            }
            base.Handle();
        }
    }
}