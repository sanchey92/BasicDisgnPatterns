using System;
using DotnetDesignPatterns.Structural.Proxy.Exersize;

namespace DotnetDesignPatterns.Structural.Proxy
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person {Age = 10};
            var responsiblePerson = new ResponsiblePerson(person);

            Console.WriteLine(responsiblePerson.Drive());
            responsiblePerson.Age = 20;
            Console.WriteLine(responsiblePerson.Drink());
        }
    }
}