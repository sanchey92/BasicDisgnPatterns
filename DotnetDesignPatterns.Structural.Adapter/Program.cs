using System;
using DotnetDesignPatterns.Structural.Adapter.Example;

namespace DotnetDesignPatterns.Structural.Adapter
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var square = new Square {Side = 11};
            var adapter = new SquareToRectangleAdapter(square);
            Console.WriteLine(adapter.Area());
        }
    }
}