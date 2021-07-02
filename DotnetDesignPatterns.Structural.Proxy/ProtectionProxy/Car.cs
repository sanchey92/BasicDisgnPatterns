using System;

namespace DotnetDesignPatterns.Structural.Proxy.ProtectionProxy
{
    public class Car : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Car being driver");
        }
    }
}