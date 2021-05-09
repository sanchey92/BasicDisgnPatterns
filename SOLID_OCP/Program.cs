using System;

namespace SOLID_OCP
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Red, Size.Large);

            Product[] products = {apple, tree, house};

            var productFilter = new ProductFilter();
            Console.WriteLine("Green Products (old): ");
            foreach (var product in productFilter.FilterByColor(products, Color.Green))
                Console.WriteLine($" - {product.Name} is green");

            var betterFiler = new BetterFilter();
            Console.WriteLine("Large Products:");
            var largeSpecification = new SizeSpecification(Size.Large);
            foreach (var product in betterFiler.Filter(products, largeSpecification))
                Console.WriteLine($" - {product.Name} is Large");
        }
    }
}