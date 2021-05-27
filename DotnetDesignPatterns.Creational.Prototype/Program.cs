using System;
using DotnetDesignPatterns.Creational.Prototype.CopyThroughSerialization;

namespace DotnetDesignPatterns.Creational.Prototype
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Foo foo = new Foo
            {
                Stuff = 42,
                Whatever = "abc",
                Bar = new Bar {Value = 321}
            };

            var foo2 = Extensions.DeepCopyXml(foo);
            foo2.Whatever = "xyz";
            foo2.Bar.Value = 1000;

            Console.WriteLine(foo);
            Console.WriteLine(foo2);
        }
    }
}