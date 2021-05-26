using System;
using DotnetDesignPatterns.Creational.Factories.PerFactory;

namespace DotnetDesignPatterns.Creational.Factories
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var personFactory = new PersonFactory();
            var person1 = personFactory.CreatePerson("Alexandr");
            var person2 = personFactory.CreatePerson("Anna");
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}