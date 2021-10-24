using System;

namespace Behavioral.Strategy.DynamicStrategy
{
    public static class DynamicStrategySolution
    {
        public static void Run()
        {
            var tp = new TextProcessor();
            tp.SetOutputFormat(OutputFormat.Markdown);
            tp.AppendList(new[] {"foo", "bar", "baz"});
            Console.WriteLine(tp);

            tp.Clear();
            
            tp.SetOutputFormat(OutputFormat.Html);
            tp.AppendList(new[] {"foo", "bar", "baz"});
            Console.WriteLine(tp);

            tp.Clear();
        }
    }
}