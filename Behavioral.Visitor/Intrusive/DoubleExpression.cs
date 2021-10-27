using System.Text;

namespace Behavioral.Visitor.Intrusive
{
    public class DoubleExpression : Expression
    {
        private readonly double _value;

        public DoubleExpression(double value)
        {
            _value = value;
        }


        public override void Print(StringBuilder stringBuilder)
        {
            stringBuilder.Append(_value);
        }
    }
}