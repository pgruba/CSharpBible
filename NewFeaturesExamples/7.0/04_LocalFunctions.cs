using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesExamples._70
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#local-functions
    /// Many designs for classes include methods that are called from only one location. 
    /// These additional private methods keep each method small and focused. Local functions enable you to declare methods inside the context of another method. 
    /// Local functions make it easier for readers of the class to see that the local method is only called from the context in which it is declared.
    /// There are two common use cases for local functions: public iterator methods and public async methods.
    /// Both types of methods generate code that reports errors later than programmers might expect.
    /// In iterator methods, any exceptions are observed only when calling code that enumerates the returned sequence.In async methods, any exceptions are only observed when the returned Task is awaited.
    /// The following example demonstrates separating parameter validation from the iterator implementation using a local function:
    /// </summary>
    public class LocalFunctions
    {
        public static IEnumerable<char> AlphabetSubset(char start, char end)
        {
            if (start < 'a' || start > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(start), message: "start must be a letter");
            if (end < 'a' || end > 'z')
                throw new ArgumentOutOfRangeException(paramName: nameof(end), message: "end must be a letter");

            if (end <= start)
                throw new ArgumentException($"{nameof(end)} must be greater than {nameof(start)}");

            return alphabetSubsetImplementation();

            IEnumerable<char> alphabetSubsetImplementation()
            {
                for (var c = start; c < end; c++)
                    yield return c;
            }
        }
    }
}
