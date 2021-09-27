using System;
using System.ComponentModel;
using Behavioral.Observer.PropertyDependencies;

namespace Behavioral.Observer
{
    public static class Program
    {
        public static void Main()
        {
            var person = new Person {Age = 15};
            person.Citizen = true;

            person.PropertyChanged += PersonOnPropertyChanged;

            Console.WriteLine("Changing age:");
            person.Age++;
            Console.WriteLine("Changing Citizenship");
            person.Citizen = false;
        }

        private static void PersonOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var person = (Person)sender;
            
            if (e.PropertyName == "CanVote")
            {
                Console.WriteLine($"Voting status changed! ({person.Age})");
            }
        }
    }
}