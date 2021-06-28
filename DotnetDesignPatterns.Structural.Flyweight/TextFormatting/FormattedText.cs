using System;
using System.Text;

namespace DotnetDesignPatterns.Structural.Flyweight.TextFormatting
{
    public class FormattedText
    {
        private readonly string _plainText;
        private readonly bool[] _capitalise;

        public FormattedText(string plainText)
        {
            _plainText = plainText;
            _capitalise = new bool[plainText.Length];
        }

        public void Capitalise(int start, int end)
        {
            for (var i = start; i <= end; i++)
            {
                _capitalise[i] = true;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            
            for (var i = 0; i < _plainText.Length; i++)
            {
                var c = _plainText[i];
                stringBuilder.Append(_capitalise[i] ? Char.ToUpper(c) : c);
            }

            return stringBuilder.ToString();
        }
    }
}