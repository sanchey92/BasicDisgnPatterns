namespace DotnetDesignPatterns.Structural.Decorator.Exersize
{
    public class Bird
    {
        public int Age { get; set; }

        public string Fly() => Age < 10 ? "flying" : "to old";
    }
}