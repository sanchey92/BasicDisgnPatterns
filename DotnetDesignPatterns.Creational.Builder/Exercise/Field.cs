namespace DotnetDesignPatterns.Creational.Builder.Exercise
{
    public class Field
    {
        public string Type, Name;

        public override string ToString() => $"public {Type} {Name}";
    }
}