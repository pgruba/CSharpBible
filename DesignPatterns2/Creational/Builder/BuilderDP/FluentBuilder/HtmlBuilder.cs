using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDP.FluentBuilder
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
}
