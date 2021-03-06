using System.Collections.Generic;

namespace SOLID_OCP
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }
}