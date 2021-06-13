using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetDesignPatterns.Structural.Composite.GeometricShapes
{
    public class GraphicsObject
    {
        public virtual string Name { get; set; } = "Group";
        public string Color { get; set; }

        private Lazy<List<GraphicsObject>> _children = 
            new Lazy<List<GraphicsObject>>(() => new List<GraphicsObject>());

        public List<GraphicsObject> Children => _children.Value;

        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);
            return sb.ToString();
        }

        private void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('*', depth))
                .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color}")
                .AppendLine($"{Name}");
            
            foreach (var child in Children)
                child.Print(sb, depth + 1);
        }
    }
}