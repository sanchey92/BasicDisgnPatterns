using System.Collections.Generic;
using System.Linq;

namespace DotnetDesignPatterns.Structural.Flyweight.Users
{
    public class User
    {
        private static List<string> _strings = new List<string>();
        private int[] _names;
        
        public static List<string> Strings => _strings;

        public User(string fullName)
        {
            static int GetOrAdd(string s)
            {
                int index = _strings.IndexOf(s);
                if (index != -1) return index;
                else
                {
                    _strings.Add(s);
                    return _strings.Count - 1;
                }
            }
            
            _names = fullName.Split(' ').Select(GetOrAdd).ToArray();
        }

        public string FullName
            => string.Join(" ", _names.Select(i => _strings[i]));
    }
}