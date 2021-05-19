using DotnetDesignPatterns.Creational.Builder.BuilderInheritance;

namespace DotnetDesignPatterns.Creational.Builder
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var person = Person.New
                .Called("Alexandr")
                .WorkAs("Engineer")
                .Build();
        }
    }
}