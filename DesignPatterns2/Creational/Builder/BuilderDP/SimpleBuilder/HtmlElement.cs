using System.Collections.Generic;
using System.Linq;

namespace BuilderDP.SimpleBuilder
{
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