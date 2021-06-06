namespace DotnetDesignPatterns.Structural.Adapter.GenericValueAdapter
{
    public abstract class Vector<T, D> 
        where D : IInteger, new()// Example: T = float; D = 3;
    {
        protected T[] data;

        public Vector()
        {
            data = new T[new D().Value];
        }
    }
}