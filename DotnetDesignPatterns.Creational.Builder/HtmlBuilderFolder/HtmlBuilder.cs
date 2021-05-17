namespace DotnetDesignPatterns.Creational.Builder.HtmlBuilderFolder
{
    public class HtmlBuilder
    {
        private readonly string _rootName;
        protected HtmlElement Root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            _rootName = rootName;
            Root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            Root.Elements.Add(element);
            return this;
        }

        public override string ToString() => Root.ToString();

        public void Clear()
        {
            Root = new HtmlElement {Name = _rootName};
        }

        public HtmlElement Build() => Root;
    }
}