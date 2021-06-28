using System.Collections.Generic;
using System.Text;

namespace DotnetDesignPatterns.Structural.Flyweight.TextFormatting
{
    public class BetterFormattedText
    {
        private readonly string _plainText;
        private readonly List<TextRange> _formatting = new List<TextRange>();

        public BetterFormattedText(string plainText)
        {
            _plainText = plainText;
        }

        public TextRange GetRange(int start, int end)
        {
            var range = new TextRange {Start = start, End = end};
            _formatting.Add(range);
            return range; 
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < _plainText.Length; i++)
            {
                char c = _plainText[i];

                foreach (var range in _formatting)
                {
                    if (range.Covers(i) && range.Capitalise)
                    {
                        c = char.ToUpperInvariant(c);
                    }
                }

                stringBuilder.Append(c);
            }
            
            return stringBuilder.ToString();
        }

        public class TextRange
        {
            public int Start, End;
            public bool Capitalise, Bold, Italic;

            public bool Covers(int position)
                => position >= Start && position <= End;
        }
    }
}