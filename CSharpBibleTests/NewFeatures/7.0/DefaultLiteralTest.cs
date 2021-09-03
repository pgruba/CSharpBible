using NewFeaturesExamples._70;
using Xunit;

namespace CSharpBibleTests.NewFeatures._7._0
{
    public class DefaultLiteralTest
    {
        private DefaultLiteral df;

        public DefaultLiteralTest()
        {
            df = new DefaultLiteral();
        }

        [Fact]
        public void GetDefaultValueOf_ShouldReturn_Integer()
        {
            Assert.Equal(typeof(int).Name, df.GetDefaultValueOf<int>());
        }

        [Fact]
        public void GetDefaultValueOf_ShouldReturn_Null()
        {
            Assert.Equal("null", df.GetDefaultValueOf<string>());
        }

        [Fact]
        public void InitializeArray_ShouldBeOk()
        {
            var coll = df.InitializeArray<int>(4);

            Assert.All(coll, el => el.GetType().Equals(typeof(int)));
            Assert.True(coll.Length == 4);
        }
    }
}