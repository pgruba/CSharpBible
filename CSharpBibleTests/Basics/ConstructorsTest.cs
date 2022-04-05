using Basics.Constructors;
using Xunit;

namespace Test.Basics
{
    public class ConstructorsTest
    {
        private class DefaultConstructor : Constructors.ConstructorBase
        { }

        private class CustomConstructor : Constructors.ConstructorBase {
            public CustomConstructor(int x)
            {
                Value += x;
            }
        }

        [Fact]
        public void Test1()
        {
            DefaultConstructor test = new DefaultConstructor();
            Assert.Equal(-5, test.Value);
        }

        [Fact]
        public void Test2()
        {
            CustomConstructor test = new CustomConstructor(3);
            Assert.Equal(-2, test.Value);
        }
    }
}