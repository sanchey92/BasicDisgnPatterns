namespace DotnetDesignPatterns.Creational.Prototype.CopyConstructors
{
    public class AnotherAddress
    {
        public string StreetName;
        public int HouseNumber;

        public AnotherAddress(AnotherAddress  address)
        {
            StreetName = address.StreetName;
            HouseNumber = address.HouseNumber;
        }
        
        public AnotherAddress(string streetName, int houseNumber)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)} : {StreetName};" +
                   $" {nameof(HouseNumber)} : {HouseNumber}";
        }
    }
}