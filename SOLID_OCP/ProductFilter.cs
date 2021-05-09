using System.Collections.Generic;

namespace SOLID_OCP
{
    public class ProductFilter
    {
        public IEnumerable<Product> FilterByColor(
            IEnumerable<Product> products, Color color)
        {
            foreach (var product in products)
            {
                if (product.Color == color)
                    yield return product;
            }
        }
        
        public IEnumerable<Product> FilterBySize(
            IEnumerable<Product> products, Size size)
        {
            foreach (var product in products)
            {
                if (product.Size == size)
                    yield return product;
            }
        }
        
        public IEnumerable<Product> FilterBySizeAndColor(
            IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var product in products)
            {
                if (product.Size == size && product.Color == color)
                    yield return product;
            }
        }
        
        // STATE SPACE EXPLOSION
    }
}