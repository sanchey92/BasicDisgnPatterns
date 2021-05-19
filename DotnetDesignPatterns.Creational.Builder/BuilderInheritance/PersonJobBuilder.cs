namespace DotnetDesignPatterns.Creational.Builder.BuilderInheritance
{
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<SELF>
        where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorkAs(string position)
        {
            person.Position = position;
            return (SELF) this;
        }
    }
}