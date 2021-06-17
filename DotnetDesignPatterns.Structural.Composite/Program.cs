using System;
using System.Collections.Generic;
using DotnetDesignPatterns.Structural.Composite.Example;

namespace DotnetDesignPatterns.Structural.Composite
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var singleValue = new SingleValue {Value = 11};
            var otherValues = new ManyValues();
            otherValues.Add(22);
            otherValues.Add(33);

            var newList = new List<IValueContainer> {singleValue, otherValues};
            Console.WriteLine(newList.Sum());
        }
    }
}