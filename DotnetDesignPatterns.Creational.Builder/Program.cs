using System;
using DotnetDesignPatterns.Creational.Builder.HtmlBuilderFolder;

namespace DotnetDesignPatterns.Creational.Builder
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder
                .AddChild("li", "Hello")
                .AddChild("li", "World!");
            
            Console.WriteLine(builder.ToString());
        }
    }
}