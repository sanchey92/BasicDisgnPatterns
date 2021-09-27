using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Behavioral.Observer.Annotations;

namespace Behavioral.Observer.PropertyDependencies
{
    public class PropertyNotificationSupport
        : INotifyPropertyChanged, INotifyPropertyChanging
    {
        private readonly Dictionary<string, HashSet<string>> _affectedBy
            = new Dictionary<string, HashSet<string>>();

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        protected Func<T> Property<T>(string name, Expression<Func<T>> expression)
        {
            Console.WriteLine($"Created computed property for expression {expression}");

            var visitor = new MemberAccessVisitor(GetType());
            visitor.Visit(expression);

            if (visitor.PropertyNames.Any())
            {
                if (!_affectedBy.ContainsKey(name))
                {
                    _affectedBy.Add(name, new HashSet<string>());
                }

                foreach (var propertyName in visitor.PropertyNames)
                {
                    if (propertyName != name)
                    {
                        _affectedBy[name].Add(propertyName);
                    }
                }
            }

            return expression.Compile();
        }

        protected void SetValue<T>(T value, ref T field,
            [CallerMemberName] string propertyName = null)
        {
            if (value.Equals(field)) return;
            OnPropertyChanging(propertyName);
            field = value;
            OnPropertyChanged(propertyName);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            foreach (var affected in _affectedBy.Keys)
            {
                if (_affectedBy[affected].Contains(propertyName))
                {
                    OnPropertyChanged(affected);
                }
            }
        }

        protected virtual void OnPropertyChanging(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}