using System.Collections.Generic;
using System.Linq;

namespace Behavioral.Mediator.ChatRoom
{
    public class ChatRoom
    {
        private List<Person> _people = new List<Person>();

        public void Join(Person p)
        {
            string joinMessage = $"{p.Name} joins the chat";
            Broadcast("room", joinMessage);
            p.Room = this;
            _people.Add(p);
        }

        public void Broadcast(string source, string message)
        {
            foreach (var person in _people.Where(person => person.Name != source))
            {
                person.Receive(source, message);
            }
        }

        public void Message(string source, string destination, string message)
        {
            _people.FirstOrDefault(p => p.Name == destination)
                ?.Receive(source, message);
        }
    }
}