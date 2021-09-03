using NewFeaturesExamples._7._0;
using Xunit;

namespace CSharpBibleTests.NewFeatures._7._0
{
    /// <summary>
    /// Tests for Tupples
    /// https://andrewlock.net/creating-parameterised-tests-in-xunit-with-inlinedata-classdata-and-memberdata/
    /// </summary>
    public class TuppleTests
    {
        private NewFeaturesExamples._7._0.Tupples tupples = new NewFeaturesExamples._7._0.Tupples();

        [Theory]
        [InlineData("Welcome", "Niedzwiada")]
        [InlineData("Hello", "Moto")]
        public void GetValueOfNamedTuppleLeftHandSide_Should_Return_Input_Params(string first, string second)
        {
            Assert.Equal($"{first}{second}", tupples.GetValueOfNamedTuppleLeftHandSide(first, second));
        }

        [Theory]
        [InlineData("Welcome", "Niedzwiada")]
        [InlineData("Hello", "Moto")]
        public void GetValueOfNamedTuppleRightHandSide_Should_Return_Input_Params(string first, string second)
        {
            Assert.Equal($"{first}{second}", tupples.GetValueOfNamedTuppleRightHandSide(first, second));
        }

        [Theory]
        [InlineData("Welcome", "Niedzwiada")]
        public void GetLeftElementFromLeftRightStringSampleTupple_Should_Returns_Left_Element(string first, string second)
        {
            Assert.Equal(first, tupples.GetLeftElementFromLeftRightStringSampleTupple(first, second));
        }

        [Theory]
        [InlineData(2, 3)]
        public void TupplePoint_Should_Decouple(double first, double second)
        {
            var tupplePoint = new TupplePoint(first, second);
            (double a, double b) = tupplePoint;

            Assert.Equal(5, a + b);
        }
    }
}