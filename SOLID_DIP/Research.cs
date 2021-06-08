using System;
using System.Linq;

namespace SOLID_DIP
{
    public class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has child called {p.Name}");
            }
        }
    }
}