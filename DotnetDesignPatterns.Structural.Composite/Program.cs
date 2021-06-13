using System;
using DotnetDesignPatterns.Structural.Composite.GeometricShapes;

namespace DotnetDesignPatterns.Structural.Composite
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var drawing = new GraphicsObject {Name = "My Drawing"};
            drawing.Children.Add(new Square{Color = "Red"});
            drawing.Children.Add(new Circle{Color = "Yellow"});

            var group = new GraphicsObject();
            group.Children.Add(new Circle {Color = "Blue"});
            group.Children.Add(new Square {Color = "Blue"});
            
            drawing.Children.Add(group);

            Console.WriteLine(drawing);
        }
    }
}