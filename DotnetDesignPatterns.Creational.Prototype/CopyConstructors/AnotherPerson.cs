using System;

namespace DotnetDesignPatterns.Creational.Prototype.CopyConstructors
{
    public class AnotherPerson
    {
        public string[] Names;
        public AnotherAddress Address;

        public AnotherPerson(AnotherPerson other)
        {
            Names = new string[other.Names.Length];
            Array.Copy(other.Names, Names, other.Names.Length);
            Address = new AnotherAddress(other.Address);
        }

        public AnotherPerson(string[] names, AnotherAddress address)
        {
            Names = names;
            Address = address;
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(' ', Names)};" +
                   $" {nameof(Address)} : {Address}";
        }
    }
}