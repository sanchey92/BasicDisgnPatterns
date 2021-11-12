using System;

namespace Behavioral.Visitor.Classic
{
    public static class Solution
    {
        public static void Run()
        {
            var expression = new AdditionExpression(
                new DoubleExpression(1),
                new AdditionExpression(
                    new DoubleExpression(2),
                    new DoubleExpression(3)
                    )
            );

            var expressionPrinter = new ExpressionPrinter();
            expressionPrinter.Visit(expression);
            var expressionCalculator = new ExpressionCalculator();
            expressionCalculator.Visit(expression);
            Console.WriteLine(expressionPrinter);
            Console.WriteLine(expressionCalculator.Result);
        }
    }
}