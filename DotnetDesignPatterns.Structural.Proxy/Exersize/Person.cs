namespace DotnetDesignPatterns.Structural.Proxy.Exersize
{
    public class Person
    {
        public int Age { get; set; }

        public string Drink() => "drinking";
        public string Drive() => "driving";
        public string DriveAndDrink() => "driving while drunk";
    }
}