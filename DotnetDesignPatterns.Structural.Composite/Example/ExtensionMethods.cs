using System.Collections.Generic;

namespace DotnetDesignPatterns.Structural.Composite.Example
{
    public static class ExtensionMethods
    {
        public static int Sum(this List<IValueContainer> containers)
        {
            var result = 0;
            foreach (var container in containers)
            foreach (var i in container)
                    result += i;

            return result;
        }
    }
}