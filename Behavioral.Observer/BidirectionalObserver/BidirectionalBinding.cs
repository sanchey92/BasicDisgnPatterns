using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace Behavioral.Observer.BidirectionalObserver
{
    public class BidirectionalBinding : IDisposable
    {
        private bool _disposed;
        
        public void Dispose()
        {
            _disposed = true;
        }

        public BidirectionalBinding(
            INotifyPropertyChanged first,
            Expression<Func<object>> firstProperty,
            INotifyPropertyChanged second,
            Expression<Func<object>> secondProperty)
        {
            if (firstProperty.Body is not MemberExpression firstExpression ||
                secondProperty.Body is not MemberExpression secondExpression) return;
            
            if (firstExpression.Member is not PropertyInfo firstProp ||
                secondExpression.Member is not PropertyInfo secondProp) return;
           
            first.PropertyChanged += (sender, args) =>
            {
                if (!_disposed)
                {
                    secondProp.SetValue(second, firstProp.GetValue(first));
                }
            };
            second.PropertyChanged += (sender, args) =>
            {
                if (!_disposed)
                {
                    firstProp.SetValue(first, secondProp.GetValue(second));
                }
            };
        }
    }
}