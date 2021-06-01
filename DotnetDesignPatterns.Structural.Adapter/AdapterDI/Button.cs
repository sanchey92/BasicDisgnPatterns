using System;

namespace DotnetDesignPatterns.Structural.Adapter.AdapterDI
{
    public class Button
    {
        private ICommand _command;
        private string _name;

        public Button(ICommand command, string name)
        {
            _command = command;
            _name = name;
        }

        public void Click()
        {
            _command.Execute();
        }

        public void PrintMe()
        {
            Console.WriteLine($"I am a button called {_name}");
        }
    }
}