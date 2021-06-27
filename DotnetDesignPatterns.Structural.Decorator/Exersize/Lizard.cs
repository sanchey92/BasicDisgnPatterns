namespace DotnetDesignPatterns.Structural.Decorator.Exersize
{
    public class Lizard
    {
        public int Age { get; set; }

        public string Crawl() => Age > 1 ? "crawling" : "too young";
    }
}