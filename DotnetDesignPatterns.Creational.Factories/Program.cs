using System;

namespace DotnetDesignPatterns.Creational.Factories
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var p = Point.NewCartesianPoint(2, 5);
        }
    }
}