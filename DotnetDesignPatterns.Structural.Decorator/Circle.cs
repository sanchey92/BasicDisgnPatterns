namespace DotnetDesignPatterns.Structural.Decorator
{
    public sealed class Circle : Shape
    {
        private float _radius;

        public Circle()
        {
            
        }
        
        public Circle(float radius)
        {
            _radius = radius;
        }

        public void Resize(float factor)
        {
            _radius *= factor;
        }

        public override string AsString
            => $"A circle of radius {_radius}";
    }
}