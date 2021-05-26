namespace DotnetDesignPatterns.Creational.Factories.PerFactory
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"ID: {Id}, Name: {Name}";
    }
}