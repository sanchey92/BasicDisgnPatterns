namespace DotnetDesignPatterns.Creational.Prototype.CopyThroughSerialization
{
    public class Bar
    {
        public uint Value;

        public override string ToString()
        {
            return $"{nameof(Value)}: {Value}";
        }
    }
}