namespace SOLID_OCP
{
    public class SizeSpecification : Specification<Product>
    {
        private readonly Size _size;

        public SizeSpecification(Size size)
        {
            _size = size;
        }
        
        public override bool IsSatisfied(Product item)
        {
            return item.Size == _size;
        }
    }
}