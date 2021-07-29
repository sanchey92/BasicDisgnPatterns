using System;
using Behavioral.Mediator.ChatRoom;

namespace Behavioral.Mediator
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var room = new ChatRoom.ChatRoom();
            var john = new Person("John");
            var jane = new Person("Jane");
            var simon = new Person("Simon");
            
            room.Join(john);
            room.Join(jane);
            
            john.Say("Hello, Room!");
            jane.Say("Hello, John!");
            
            room.Join(simon);
            
            simon.Say("Hi everyone");
            
            jane.PrivateMessage("Simon", "Hello Simon");
            
        }
    }
}