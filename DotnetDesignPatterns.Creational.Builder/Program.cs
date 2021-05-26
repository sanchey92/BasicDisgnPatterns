using System;
using DotnetDesignPatterns.Creational.Builder.Exercise;

namespace DotnetDesignPatterns.Creational.Builder
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var codeBuilder = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int");

            Console.WriteLine(codeBuilder.ToString());
        }
    }
}