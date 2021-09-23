using System;

namespace Behavioral.Observer.Observer.Events
{
    public class Person
    {
        public event EventHandler<FallsIllEventArgs> FallsIll;

        public void CatchACold()
        {
            FallsIll?.Invoke(
                this,
                new FallsIllEventArgs
                {
                    Address = "123 London Road"
                });
        }
    }
}