using System;

namespace DotnetDesignPatterns.Creational.Prototype.PrototypeFactoryFolder
{
    [Serializable]
    public class Address
    {
        public string StreetAddress, City;
        public int Suite;

        public Address(string streetAddress, string city, int suite)
        {
            StreetAddress = streetAddress;
            City = city;
            Suite = suite;
        }

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}," +
                   $" {nameof(City)}: {City}," +
                   $" {nameof(Suite)}: {Suite}";
        }
    }
}