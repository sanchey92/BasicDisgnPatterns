namespace DotnetDesignPatterns.Creational.Prototype.PrototypeFactoryFolder
{
    public class EmployeeFactory
    {
        private static Employee main =
            new Employee(null, new Address("123 East Dr", "London", 0));
        private static Employee aux =
            new Employee(null, new Address("321 East Dr", "Chicago", 0));

        private static Employee newEmployee(Employee proto, string name, int suite)
        {
            var copy = proto.DeepCopy();
            copy.Name = name;
            copy.Address.Suite = suite;
            return copy; 
        }

        public static Employee NewMainOfficeEmployee
            (string name, int suite) => newEmployee(main, name, suite);
        
        public static Employee NewAuxOfficeEmployee
            (string name, int suite) => newEmployee(aux,  name, suite);
    }
}