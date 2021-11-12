namespace Behavioral.Visitor.Classic
{
    public class ExpressionCalculator : IExpressionVisitor
    {
        public double Result;
        public void Visit(DoubleExpression doubleExpression)
        {
            Result = doubleExpression.Value;
        }

        public void Visit(AdditionExpression additionExpression)
        {
            additionExpression.Left.Accept(this);
            var a = Result;
            additionExpression.Right.Accept(this);
            var b = Result;
            Result = a + b;
        }
    }
}