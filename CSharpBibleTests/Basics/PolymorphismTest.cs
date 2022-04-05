using Basics;
using Xunit;

namespace Test.Basics
{
    public class PolymorphismTest
    {
        [Fact]
        public void Test1()
        {
            PolymorphismBase instance = new DerivedPolymorphism();
            Assert.Equal("DerivedPolymorphism:Foo", instance.GetFoo());
            Assert.Equal("PolymorphismBase:Boo", instance.GetBoo());
            Assert.Equal("PolymorphismBase:Coo", instance.GetCoo());
        }

        [Fact]
        public void Test2()
        {
            DerivedPolymorphism instance = new DerivedPolymorphism();
            Assert.Equal("DerivedPolymorphism:Foo", instance.GetFoo());
            Assert.Equal("DerivedPolymorphism:Boo", instance.GetBoo());
            Assert.Equal("DerivedPolymorphism:Coo", instance.GetCoo());
        }
    }
}