using System.Collections.Generic;

namespace SOLID_DIP
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
} 