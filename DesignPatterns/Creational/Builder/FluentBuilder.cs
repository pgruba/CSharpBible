using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.FluentBuilder
{
    public class HtmlBuilder
    {
        protected readonly string rootName;
        protected HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = $"<{rootName}>";
            root.Name = rootName;
        }

        // Thanks to the fact we return HtmlBuilder from that method - we have implemented fluent builder
        public HtmlBuilder AddChild(string childName, string childText)
        {
            var el = new HtmlElement(childName, childText);
            root.Elements.Add(el);
            return this;
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
