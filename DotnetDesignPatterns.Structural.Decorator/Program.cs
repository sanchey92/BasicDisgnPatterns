using System;

namespace DotnetDesignPatterns.Structural.Decorator
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var circle = new Circle(2);
            Console.WriteLine(circle.AsString);

            var redCircle = new ColorShape(circle, "red");
            Console.WriteLine(redCircle.AsString);

            var transparentShape = new TransparentShape(redCircle, 0.5f);
            Console.WriteLine(transparentShape.AsString);
        }
    }
}