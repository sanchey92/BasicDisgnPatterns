using System;
using System.Text;

namespace Behavioral.Visitor.Intrusive
{
    public static class IntrusiveSolution
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

            var stringBuilder = new StringBuilder();
            expression.Print(stringBuilder);
            Console.WriteLine(stringBuilder);
        }
    }
}