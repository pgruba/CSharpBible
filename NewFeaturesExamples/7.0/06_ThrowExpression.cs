using System;

namespace NewFeaturesExamples._70
{
    public class ThrowExpression
    {
        private string _expresionName;
        public string ExpressionName
        {
            get => _expresionName;
            set => _expresionName = value ??
                throw new ArgumentNullException("ExpressionName can not be null");
        }

        public bool ThrowConditionalOperator(bool isTrue)
            => isTrue ? true :
                throw new ArgumentException("IsTrue cannon be null");

        
    }
}