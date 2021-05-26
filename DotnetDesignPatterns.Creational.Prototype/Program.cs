using System;
using DotnetDesignPatterns.Creational.Prototype.ICloneableIsBad;

namespace DotnetDesignPatterns.Creational.Prototype
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var john = new Person(
                new[] {"John", "Smith"},
                new Address("London Road", 123));

            var jane = (Person) john.Clone();
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 333;
            
            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}