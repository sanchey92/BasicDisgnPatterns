using System.Text;

namespace Behavioral.Strategy.DynamicStrategy
{
    public class MarkdownListStrategy : IListStrategy
    {
        public void Start(StringBuilder stringBuilder)
        {
        }

        public void End(StringBuilder stringBuilder)
        {
        }

        public void AddListItem(StringBuilder stringBuilder, string item)
        {
            stringBuilder.AppendLine($"* {item}");
        }
    }
}