using System;

namespace DotnetDesignPatterns.Structural.Adapter.AdapterDI
{
    public class SaveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Saving current file");
        }
    }
}