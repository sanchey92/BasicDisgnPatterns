using System;
using DotnetDesignPatterns.Structural.Flyweight.TextFormatting;

namespace DotnetDesignPatterns.Structural.Flyweight
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var formattedText = new FormattedText("This is a brave new world");
            formattedText.Capitalise(10, 15);
            Console.WriteLine(formattedText);

            var bft = new BetterFormattedText("This is a brave new world");
            bft.GetRange(10, 15).Capitalise = true; 
            Console.WriteLine(bft);
        }
    }
}