namespace SOLID_OCP
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfied(T item);
    }
}