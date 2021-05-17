using System.Collections.Generic;
using System.Text;

namespace DotnetDesignPatterns.Creational.Builder.HtmlBuilderFolder
{
    public class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();

        private const int IndentSize = 2;

        public HtmlElement() { }

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            return ToStringImp(0);
        }

        private string ToStringImp(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', IndentSize * indent);
            sb.Append($"{i}<{Name}>\n");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', IndentSize * (indent + 1)));
                sb.Append(Text);
                sb.Append("\n");
            }

            foreach (var element in Elements)
                sb.Append(element.ToStringImp(indent + 1));

            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }
    }
}