using System;

namespace DotnetDesignPatterns.Structural.Proxy.PropertyProxy
{
    public class Property<T> where T : new()
    {
        private T _value;
        private readonly string _name;

        public T Value
        {
            get => _value;
            set
            {
                if (Equals(_value, value)) return;
                Console.WriteLine($"Assigning {value} to {_name}");
                _value = value;
            }
        }


        public Property() : this(default(T))
        {
        }

        public Property(T value, string name = "")
        {
            _value = value;
            _name = name;
        }

        public static implicit operator T(Property<T> p) => p.Value;
        public static implicit operator Property<T>(T value) => new Property<T>(value);
    }
}