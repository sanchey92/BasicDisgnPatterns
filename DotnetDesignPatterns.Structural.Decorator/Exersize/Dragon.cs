namespace DotnetDesignPatterns.Structural.Decorator.Exersize
{
    public class Dragon
    {
        private int _age;
        private Bird _bird = new Bird();
        private Lizard _lizard = new Lizard();

        public int Age
        {
            set => _age = _bird.Age = _lizard.Age = value;
            get => _age;
        }

        public string Fly() => _bird.Fly();
        public string Crawl => _lizard.Crawl();

    }
}