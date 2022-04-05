namespace Basics.Constructors
{
    public class Constructors
    {
        public abstract class ConstructorBase
        {
            public int Value { get; set; }

            public ConstructorBase()
            {
                Value = -5;
            }
        }

        public abstract class BaseCustomConstructorWithNoDefault
        {
            public int Value { get; set; } = -5;

            public BaseCustomConstructorWithNoDefault(int x)
            {
                Value += x;
            }
        }

        public class BaseParametrizedWithDefault
        {
            public int Value { get; set; } = -5;

            public BaseParametrizedWithDefault()
            {
                Value += 3;
            }

            public BaseParametrizedWithDefault(int x)
            {
                Value += x;
            }
        }

    }
}