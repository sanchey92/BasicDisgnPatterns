using System;
using System.Collections.ObjectModel;

namespace DotnetDesignPatterns.Structural.Adapter.NoCachingAdapter
{
    public class LineToPointAdapter : Collection<Point>
    {
        private static int _count = 0;

        public LineToPointAdapter(Line line)
        {
            Console.WriteLine($"{++_count} Generating points for line" +
                              $" [{line.Start.X},{line.Start.Y}]" +
                              $" [{line.End.X},{line.End.Y}] (no caching)");

            var left = Math.Min(line.Start.X, line.End.X);
            var right = Math.Max(line.Start.X, line.End.X);
            var top = Math.Min(line.Start.Y, line.End.Y);
            var bottom = Math.Max(line.Start.Y, line.End.Y);

            if (right - left == 0)
            {
                for (var y = top;  y < bottom; ++y)
                {
                    Add(new Point(left, y));
                }
            } else if (line.End.Y - line.Start.Y == 0)
            {
                for (var x = left; x <= right; ++x)
                {
                    Add(new Point(x, top));
                }
            }
        }
    }
}