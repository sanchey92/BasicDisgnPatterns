﻿using System;
using System.Collections.Generic;
using DotnetDesignPatterns.Structural.Adapter.AdapterWithCaching;

namespace DotnetDesignPatterns.Structural.Adapter
{
    public static class Program
    {
        private static readonly List<VectorObject> vectorObjects = new List<VectorObject>
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
            Draw();
            Draw();
        }
        
        private static void Draw()
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