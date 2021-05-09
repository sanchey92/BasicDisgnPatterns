using System;

namespace SOLID_SRP
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("Test data 1");
            journal.AddEntry("Test data 2");
            Console.WriteLine(journal);

            var persistenceManager = new PersistenceManager();
            var filename = "example.txt";
            persistenceManager.Save(filename, journal);
        }
    }
}