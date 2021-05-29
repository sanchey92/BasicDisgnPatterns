using System;
using System.Collections.Generic;
using DotnetDesignPatterns.Structural.Adapter.NoCachingAdapter;

namespace DotnetDesignPatterns.Structural.Adapter
{
    public static class Program
    {
        public static readonly List<VectorObject> vectorObjects =
            new List<VectorObject>
            {
                new VectorRectangle(1, 1, 10, 10),
                new VectorRectangle(3, 3, 6, 6)
            };
        
        public static void DrawPoint(Point point)
        {
            Console.Write(".");
        }

        private static void Main(string[] args)
        {
            DrawPoints();
            DrawPoints();
        }

        private static void DrawPoints()
        {
            foreach (var vo in vectorObjects)
            {
                foreach (var line in vo)
                {
                    var adapter = new LineToPointAdapter(line);
                    foreach (var point in adapter)
                    {
                        DrawPoint(point);
                    }
                }
            }
        }
    }
}