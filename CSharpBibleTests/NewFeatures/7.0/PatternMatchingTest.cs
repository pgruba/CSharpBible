using System.Collections.Generic;
using NewFeaturesExamples._7._0;
using Xunit;

namespace CSharpBibleTests.NewFeatures._7._0
{
    public class PatternMatchingTest
    {
        private IList<object> sequence = new List<object>();
        private PatternMatching patternMatching = new PatternMatching();

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] {
                29, new List<object>()
                    { 1, -5, 10, new List<int>() { 5, 6, 7 }, 0, }, },
        };

        [Theory]
        [MemberData(nameof(Data))]
        public void SumPositiveNumber_Returns_Sum(int expected, IEnumerable<object> input)
        {
            Assert.Equal(expected, patternMatching.SumPositiveNumbers(input));
        }
    }
}