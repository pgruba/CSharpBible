namespace BuilderDP.SimpleBuilder
{
    public class HtmlBuilder
    {
        // protected member is accessible within its class and by derived class instances
        protected readonly string rootName;

        protected HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = $"<{rootName}>";
            root.Name = rootName;
        }

        // AddChild returns void, that's why it is 'Simple Builder'
        public void AddChild(string childName, string childText)
        {
            var el = new HtmlElement(childName, childText);
            root.Elements.Add(el);
        }

        public override string ToString() => root.ToString();
    }
}