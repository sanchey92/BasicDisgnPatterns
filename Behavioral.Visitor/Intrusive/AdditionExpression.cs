using System.Text;

namespace Behavioral.Visitor.Intrusive
{
    public class AdditionExpression : Expression
    {
        private Expression _left, _right;

        public AdditionExpression(Expression left, Expression right)
        {
            _left = left;
            _right = right;
        }

        public override void Print(StringBuilder stringBuilder)
        {
            stringBuilder.Append('(');
            _left.Print(stringBuilder);
            stringBuilder.Append('+');
            _right.Print(stringBuilder);
            stringBuilder.Append(')');
        }
    }
}