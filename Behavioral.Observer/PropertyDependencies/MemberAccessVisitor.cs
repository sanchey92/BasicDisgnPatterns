using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Behavioral.Observer.PropertyDependencies
{
    public class MemberAccessVisitor : ExpressionVisitor
    {
        private readonly Type _declaringType;
        public readonly IList<string> PropertyNames = new List<string>();

        public MemberAccessVisitor(Type declaringType)
        {
            _declaringType = declaringType;
        }

        public override Expression Visit(Expression nodeExpression)
        {
            if (nodeExpression != null && nodeExpression.NodeType == ExpressionType.MemberAccess)
            {
                var memberExpression = (MemberExpression)nodeExpression;
                if (memberExpression.Member.DeclaringType == _declaringType)
                {
                    PropertyNames.Add(memberExpression.Member.Name);
                }
            }

            return base.Visit(nodeExpression);
        }
    }
}