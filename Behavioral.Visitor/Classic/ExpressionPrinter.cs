using System.Text;

namespace Behavioral.Visitor.Classic
{
    public class ExpressionPrinter : IExpressionVisitor
    {
        private readonly StringBuilder _stringBuilder = new StringBuilder();
        
        public void Visit(DoubleExpression doubleExpression)
        {
            _stringBuilder.Append(doubleExpression.Value);
        }

        public void Visit(AdditionExpression additionExpression)
        {
            _stringBuilder.Append('(');
            additionExpression.Left.Accept(this);
            _stringBuilder.Append('+');
            additionExpression.Right.Accept(this);
            _stringBuilder.Append(')');
        }

        public override string ToString()
        {
            return _stringBuilder.ToString();
        }
    }
}