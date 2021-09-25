using System;
using System.Collections.Generic;

namespace Behavioral.Observer.ObserverInterfaces
{
    public class Person : IObservable<Event>
    {
        private readonly HashSet<Subscription> _subscriptions 
            = new HashSet<Subscription>();

        public void CatchACold()
        {
            foreach (var subscription in _subscriptions)
            {
                subscription.Observer.OnNext(
                    new FallsIllEvent {Address = "123 London Road"});
            }
        }
        
        public IDisposable Subscribe(IObserver<Event> observer)
        {
            var subscription = new Subscription(this, observer);
            _subscriptions.Add(subscription);
            return subscription; // flyweight
        }
        
        private class Subscription : IDisposable
        {
            private Person _person;
            public IObserver<Event> Observer;

            public Subscription(Person person, IObserver<Event> observer)
            {
                _person = person;
                Observer = observer;
            }
        
            public void Dispose()
            {
                _person._subscriptions.Remove(this);
            }
        }
    }
    
    
}