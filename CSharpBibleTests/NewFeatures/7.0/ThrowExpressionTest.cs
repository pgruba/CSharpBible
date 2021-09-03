using System;
using NewFeaturesExamples._70;
using Xunit;

namespace CSharpBibleTests.NewFeatures._7._0
{
    public class ThrowExpressionTest
    {
        private ThrowExpression te;

        public ThrowExpressionTest()
        {
            te = new ThrowExpression();
        }

        [Theory]
        [InlineData("value")]
        [InlineData(null)]
        public void DontKnow(string value)
        {
            if (value == null)
            {
                Assert.Throws<ArgumentNullException>(() => te.ExpressionName = value);
            }
            else
            {
                te.ExpressionName = value;
                Assert.Equal(value, te.ExpressionName);
            }
        }
    }
}