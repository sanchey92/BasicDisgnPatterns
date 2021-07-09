namespace DotnetDesignPatterns.Structural.Proxy.Exersize
{
    public class ResponsiblePerson
    {
        private readonly Person _person;

        public ResponsiblePerson(Person person)
        {
            _person = person;
        }

        public int Age
        {
            get => _person.Age;
            set => _person.Age = value;
        }

        public string Drive()
        {
            if (Age >= 16)
                return _person.Drive();
            return "too young";
        }

        public string Drink()
        {
            if (Age >= 18)
                return _person.Drink();
            return "too young";
        }

        public string DriveAndDrink() => "dead!";
    }
}