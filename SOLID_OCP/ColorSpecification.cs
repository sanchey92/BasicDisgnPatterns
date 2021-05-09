namespace SOLID_OCP
{
    public class ColorSpecification : Specification<Product>
    {
        private readonly Color _color;

        public ColorSpecification(Color color)
        {
            _color = color;
        }
        
        public override bool IsSatisfied(Product item)
        {
            return item.Color == _color;
        }
    }
}