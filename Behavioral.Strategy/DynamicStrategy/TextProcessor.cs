using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Strategy.DynamicStrategy
{
    public class TextProcessor
    {
        private StringBuilder _stringBuilder = new StringBuilder();
        private IListStrategy _listStrategy;

        public void SetOutputFormat(OutputFormat format)
        {
            _listStrategy = format switch
            {
                OutputFormat.Markdown => new MarkdownListStrategy(),
                OutputFormat.Html => new HtmlListStrategy(),
                _ => throw new ArgumentOutOfRangeException(nameof(format), format, null)
            };
        }

        public StringBuilder Clear() => _stringBuilder.Clear();

        public override string ToString() => _stringBuilder.ToString();

        public void AppendList(IEnumerable<string> items)
        {
            _listStrategy.Start(_stringBuilder);
            foreach (var item in items)
            {
                _listStrategy.AddListItem(_stringBuilder, item);
            }
            _listStrategy.End(_stringBuilder);
        }
    }
}