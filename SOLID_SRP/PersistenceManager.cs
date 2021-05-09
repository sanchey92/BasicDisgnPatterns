using System.IO;

namespace SOLID_SRP
{
    public class PersistenceManager
    {
        private static void Verify(string filename)
        {
            
        }
        
        public void Save(Journal journal, string filename, bool overwrite = false)
        {
            Verify(filename);
            File.WriteAllText(filename, journal.ToString());
        }
    }
}