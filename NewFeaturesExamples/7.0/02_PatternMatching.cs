using System;
using System.Collections.Generic;

namespace NewFeaturesExamples._7._0
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#pattern-matching
    /// Match expression can be any NON-NULL expression!
    /// </summary>
    public class PatternMatching
    {
        public int SumPositiveNumbers(IEnumerable<object> sequence)
        {
            int sum = 0;
            foreach (var i in sequence)
            {
                switch (i)
                {
                    case 0:
                    break;

                    case IEnumerable<int> childSequence:
                    {
                        foreach (var item in childSequence)
                            sum += (item > 0) ? item : 0;
                        break;
                    }
                    case int n when n > 0:
                        sum += n;
                        break;
                    case int n when n > 5:
                        sum += n;
                        break;
                    case int n when n < 0:
                        break;
                    case null:
                        throw new NullReferenceException("Null found in sequence");
                    default:
                        throw new InvalidOperationException("Unrecognized type");
                }
            }
            return sum;
        }
    }
}