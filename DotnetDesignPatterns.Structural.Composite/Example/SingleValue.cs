using System.Collections;
using System.Collections.Generic;

namespace DotnetDesignPatterns.Structural.Composite.Example
{
    public class SingleValue : IValueContainer
    {
        public int Value;
        public IEnumerator<int> GetEnumerator()
        {
            yield return Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}