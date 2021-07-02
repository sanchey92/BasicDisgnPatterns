using System;

namespace DotnetDesignPatterns.Structural.Proxy.ProtectionProxy
{
    public class CarProxy : ICar
    {
        private Car _car = new Car();
        private Driver _driver;

        public CarProxy(Driver driver)
        {
            _driver = driver;
        }
        
        public void Drive()
        {
            if (_driver.Age >= 16)
                _car.Drive();
            else
                Console.WriteLine("Driver to young");
        }
    }
}