namespace NewFeaturesExamples._7._0
{
    public class Tupples
    {
        public double XCord { get; }
        public double YCord { get; }

        /// <summary>
        /// Define tupple with named members of it
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string GetValueOfNamedTuppleLeftHandSide(string first, string second)
        {
            (string FirstWord, string SecondWord) named = (first, second);

            return $"{named.FirstWord}{named.SecondWord}";
        }

        /// <summary>
        /// Define tupple and specify the names of the fields on the right-hand side of the assignment
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public string GetValueOfNamedTuppleRightHandSide(string first, string second)
        {
            var named = (FirstWord: first, SecondWord: second);

            return $"{named.FirstWord}{named.SecondWord}";
        }

        /// <summary>
        /// Return sample tupplse
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public (string Left, string Right) GetLeftRightStringSampleTupple(string one, string two) => (one, two);

        /// <summary>
        /// Returns left element of crated tupple
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public string GetLeftElementFromLeftRightStringSampleTupple(string l, string r)
        {
            (string left, string right) = GetLeftRightStringSampleTupple(l, r);
            return left;
        }
    }

    public class TupplePoint
    {
        public TupplePoint(double x, double y) => (XCord, YCord) = (x, y);

        public double YCord { get; }
        public double XCord { get; }

        public void Deconstruct(out double x, out double y) => (x, y) = (XCord, YCord);

    }
}