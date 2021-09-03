using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.SimpleBuilder
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

    public class HtmlElement
    {
        public string Name;

        public string Text;

        public IList<HtmlElement> Elements = new List<HtmlElement>();

        private const int indentSize = 2;

        public HtmlElement()
        {
        }

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            return $"<{Name}>{Text}{string.Join(' ', Elements.Select(q => q.ToString()))}</{Name}>";
        }
    }
}
