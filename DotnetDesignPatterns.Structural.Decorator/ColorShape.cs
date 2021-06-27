namespace DotnetDesignPatterns.Structural.Decorator
{
    public class ColorShape : Shape
    {
        private Shape _shape;
        private string _color;

        public ColorShape(Shape shape, string color)
        {
            _shape = shape;
            _color = color;
        }

        public override string AsString
            => $"{_shape.AsString} has the color {_color}";
    }
}