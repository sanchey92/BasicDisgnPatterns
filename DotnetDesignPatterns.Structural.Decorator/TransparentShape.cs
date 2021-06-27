namespace DotnetDesignPatterns.Structural.Decorator
{
    public class TransparentShape : Shape
    {
        private Shape _shape;
        private float _transparency;

        public TransparentShape(Shape shape, float transparency)
        {
            _shape = shape;
            _transparency = transparency;
        }

        public override string AsString
            => $"{_shape.AsString} has " +
               $"{_transparency * 100.0f}% transparency";
    }
}