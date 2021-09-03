namespace NewFeaturesExamples._70
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#default-literal-expressions
    /// Default literal expressions are an enhancement to default value expressions. These expressions initialize a variable to the default value. Where you previously would write:
    /// Func<string, bool> whereClause = default(Func<string, bool>);
    /// You can now omit the type on the right-hand side of the initialization:
    /// Func<string, bool> whereClause = default;
    /// For more information, see the default literal section of the default operator article.
    /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default#default-literal
    /// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/default
    /// </summary>
    public class DefaultLiteral
    {
        public string GetDefaultValueOf<T>()
        {
            var value = default(T);
            return value == null ? "null" : value.GetType().Name;
        }

        public T[] InitializeArray<T>(int length, T initialValue = default)
        {
            if (length < 0)
            {
                throw new System.Exception();
            }            

            var array = new T[length];
            for (var i = 0; i < length; i++)
            {
                array[i] = initialValue;
            }

            return array;
        }
    }
}