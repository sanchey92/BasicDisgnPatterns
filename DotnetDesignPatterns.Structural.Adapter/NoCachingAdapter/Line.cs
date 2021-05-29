namespace DotnetDesignPatterns.Structural.Adapter.NoCachingAdapter
{
    public class Line
    {
        public Point Start, End;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}