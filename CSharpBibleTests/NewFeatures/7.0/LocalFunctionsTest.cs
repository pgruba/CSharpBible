using NewFeaturesExamples._70;
using Xunit;

namespace CSharpBibleTests.NewFeatures._7._0
{
    public class LocalFunctionsTest
    {
        private LocalFunctions lf;

        public LocalFunctionsTest()
        {
            lf = new LocalFunctions();
        }

        [Theory]
        [InlineData('a', 'g')]
        public void ShouldReturnSequence(char start, char end)
        {
            Assert.Equal("a,b,c,d,e,f", string.Join(',', LocalFunctions.AlphabetSubset(start, end)));
        }
    }
}