using System.Collections.Generic;

namespace DotnetDesignPatterns.Structural.Flyweight.Exercise
{
    public class Sentence
    {
        private string[] _words;
        private Dictionary<int, WordToken> _tokens = new Dictionary<int, WordToken>();

        public Sentence(string plainText)
        {
            _words = plainText.Split(' ');
        }


        public WordToken this[int index]
        {
            get
            {
                WordToken wt = new WordToken();
                _tokens.Add(index, wt);
                return _tokens[index];
            } 
        }

        public override string ToString()
        {
            var list = new List<string>();

            for (var i = 0; i < _words.Length; i++)
            {
                var word = _words[i];
                if (_tokens.ContainsKey(i) && _tokens[i].Capitalise)
                {
                    word = word.ToUpperInvariant();
                }
                list.Add(word);
            }

            return string.Join(" ", list);
        }
    }
}