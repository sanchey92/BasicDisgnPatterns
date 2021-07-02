namespace DotnetDesignPatterns.Structural.Proxy.PropertyProxy
{
    public class Creature
    {
        private readonly Property<int> _agility =
            new Property<int>(10, nameof(Agility));

        public int Agility
        {
            get => _agility.Value;
            set => _agility.Value = value;
        }
    }
}