using System;

namespace SOLID_LSP
{
    public static class Demo
    {
        public static void UseIt(Rectangle rectangle)
        {
            var width = rectangle.Width;
            rectangle.Height = 10;
            Console.WriteLine($"Expect area of {10 * width}," +
                              $"got {rectangle.Area}");
        }
    }
}