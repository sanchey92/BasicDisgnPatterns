namespace Behavioral.ChainOfResponsibility.MethodChain
{
    public class CreatureModifier
    {
        protected Creature _creature;
        // singly linked list
        private CreatureModifier _next;

        public CreatureModifier(Creature creature)
        {
            _creature = creature;
        }

        public void Add(CreatureModifier modifier)
        {
            if (_next != null) _next.Add(modifier);
            else _next = modifier;
        }

        public virtual void Handle() => _next?.Handle();
    }
}