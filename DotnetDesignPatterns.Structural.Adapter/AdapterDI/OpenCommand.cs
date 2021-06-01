using System;

namespace DotnetDesignPatterns.Structural.Adapter.AdapterDI
{
    public class OpenCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Opening file");
        }
    }
}