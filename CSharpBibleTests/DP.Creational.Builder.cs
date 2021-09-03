using Xunit;
using Builder = DesignPatterns.Creational.Builder;

namespace DesignPatternsTest
{
    public class BuilderTests
    {
        [Fact]
        public void SimpleBuilder_Returns_Correct_HtmlElement()
        {
            Builder.SimpleBuilder.HtmlBuilder hb = new Builder.SimpleBuilder.HtmlBuilder("ul");
            hb.AddChild("li", "Hello");
            hb.AddChild("li", "Niedzwiada");

            Assert.Equal("<ul><li>Hello</li> <li>Niedzwiada</li></ul>", hb.ToString());
        }

        [Fact]
        public void FluentBuilder_Returns_Correct_HtmlElement()
        {
            Builder.FluentBuilder.HtmlBuilder fluentHtmlBuilder =
                new Builder.FluentBuilder.HtmlBuilder("ul");

            fluentHtmlBuilder.AddChild("li", "Hello")
                .AddChild("li", "Niedzwiada");

            Assert.Equal("<ul><li>Hello</li> <li>Niedzwiada</li></ul>", fluentHtmlBuilder.ToString());
        }

        [Fact]
        public void RecursiveGenericsWithFluent_Returns_Complete_Employee_Model()
        {
            var emp = Builder.RecursiveGenericsWithFluentBuilder.EmployeeBuilderDirector.NewEmployee
                .SetName("Pawel")
                .AtPosition("Plumber")
                .WithSalary(3000)
                .InCurrency("pln")
                .Build();

            Assert.Equal("Name: Pawel, Position: Plumber, Salary: 3000pln", emp.ToString());
        }

        [Fact]
        public void ComplexBuilder_Returns_Person()
        {
            var pb = new Builder.ComplexBuilder.PersonBuilder();
            var person = pb.Lives
                .At("Partyzancka")
                .In("Lubartow")
                .WithPostCode("21100")
            .Works
                .At("TI")
                .As("Programmer")
                .Earning(100);

            Builder.ComplexBuilder.Person p = person;

            Assert.Equal("Partyzancka21100LubartowTIProgrammer100", p.ToString());
        }

        [Fact]
        public void BuilderWithParameter_Shoud_Send_Email()
        {
            var ms = new Builder.BuilderWithParameter.MailService();
            var result = ms.SendEmail(mail => mail.From("foo@bar.com")
            .To("bar@baz.com")
            .Body("Hello"));

            Assert.Equal("Email sent to bar@baz.com", result);
        }

        [Fact]
        public void FluentInterfaceInheritance_FlatUssage_Should_Return_Data()
        {
            var pb = Builder.FluentInterfaceInheritance.BuilderDirector.New
                .WorkAs("Plumber")
                .SetName("Name")
                .SetCity("City")
                .Build();

            Assert.Equal("NamePlumberCity", pb.ToString());
        }
    }
}