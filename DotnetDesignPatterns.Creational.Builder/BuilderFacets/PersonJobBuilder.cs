namespace DotnetDesignPatterns.Creational.Builder.BuilderFacets
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder At(string company)
        {
            Person.CompanyName = company;
            return this;
        }
        public PersonJobBuilder(Person person) : base(person) { }

        public PersonJobBuilder AsA(string position)
        {
            Person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int annualIncome)
        {
            Person.AnnualIncome = annualIncome;
            return this;
        }
    }
}