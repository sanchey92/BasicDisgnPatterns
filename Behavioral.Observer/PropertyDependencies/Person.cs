using System;

namespace Behavioral.Observer.PropertyDependencies
{
    public class Person : PropertyNotificationSupport
    {
        private int _age;
        
        public int Age
        {
            get => _age;
            set => SetValue(value, ref _age);
        }

        private bool _citizen;

        public bool Citizen
        {
            get => _citizen;
            set => SetValue(value, ref _citizen);
        }

        private readonly Func<bool> _canVote;
        public bool CanVote => _canVote();

        public Person()
        {
            _canVote = Property(nameof(CanVote),
                () => Age >= 16 && Citizen);
        }
    }
}