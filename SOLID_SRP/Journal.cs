using System;
using System.Collections.Generic;
using System.IO;

namespace SOLID_SRP
{
    public class Journal
    {
        private readonly List<string> _entries = new List<string>();

        public void AddEntry(string text) => _entries.Add(text);

        public void RemoveEntries(int index)
        {
            if (index < _entries.Count && index >= 0)
                _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries);
        }

        // public void Save(string filename, bool overwrite = false)
        // {
        //     File.WriteAllText(filename, ToString());
        // }
    }
}