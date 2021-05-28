using System;
using DotnetDesignPatterns.Creational.Prototype.PrototypeFactoryFolder;

namespace DotnetDesignPatterns.Creational.Prototype
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var john = EmployeeFactory.NewMainOfficeEmployee("John", 123);
            Console.WriteLine(john);
        }
    }
}