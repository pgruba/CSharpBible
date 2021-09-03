using System;

namespace NewFeaturesExamples._70
{
    public class ExpressionBodiedMembers
    {
        public ExpressionBodiedMembers(string value)
            => this.Value = value;

        ~ExpressionBodiedMembers()
            => Console.WriteLine("Finalized!!");

        private string value;

        public string Value
        {
            get => value;
            set => this.value = value ?? "Default Value";
        }

    }
}