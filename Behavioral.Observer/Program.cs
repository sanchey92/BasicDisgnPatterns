using System;
using Behavioral.Observer.BidirectionalObserver;

namespace Behavioral.Observer
{
    public static class Program
    {
        public static void Main()
        {
            var product = new Product { Name = "Book" };
            var window = new Window {ProductName = "Book"};

            using var binding = new BidirectionalBinding(
                product,
                () => product.Name,
                window,
                () => window.ProductName
            );

            product.Name = "Table";

            Console.WriteLine(product);
            Console.WriteLine(window);
        }
    }
}