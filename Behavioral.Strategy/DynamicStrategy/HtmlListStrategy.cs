using System.Text;

namespace Behavioral.Strategy.DynamicStrategy
{
    public class HtmlListStrategy : IListStrategy
    {
        public void Start(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("<ul>");
        }

        public void End(StringBuilder stringBuilder)
        {
            stringBuilder.AppendLine("</ul>");
        }

        public void AddListItem(StringBuilder stringBuilder, string item)
        {
            stringBuilder.AppendLine($"  <li>{item}</li>");
        }
    }
}