using System.Collections.Generic;
using System.Text;

namespace DotnetDesignPatterns.Creational.Builder.Exercise
{
    public class Class
    {
        public string Name;
        public List<Field> Fields = new List<Field>();

        public Class() { }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Public class {Name}").AppendLine("{");
            
            foreach (var field in Fields)
                stringBuilder.AppendLine($"  {field}");

            stringBuilder.AppendLine("}");
            return stringBuilder.ToString();
        }
    }
}