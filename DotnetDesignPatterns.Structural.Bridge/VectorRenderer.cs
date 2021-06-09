using System;

namespace DotnetDesignPatterns.Structural.Bridge
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing circle of radius {radius}");
        }
    }
}