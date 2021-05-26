namespace DotnetDesignPatterns.Creational.Factories.PerFactory
{
    public class PersonFactory
    {
        private int _id = 0;

        public Person CreatePerson(string name)
        {
            return new Person {Id = _id++, Name = name};
        }
    }
}