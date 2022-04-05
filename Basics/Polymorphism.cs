using System;

namespace Basics
{
    public abstract class PolymorphismBase
    {
        public virtual string GetFoo() => "PolymorphismBase:Foo";

        public virtual string GetBoo() => "PolymorphismBase:Boo";

        public string GetCoo() => "PolymorphismBase:Coo";
    }

    public sealed class DerivedPolymorphism : PolymorphismBase
    {
        public override string GetFoo() => "DerivedPolymorphism:Foo";

        public new string GetBoo() => "DerivedPolymorphism:Boo";

        public string GetCoo() => "DerivedPolymorphism:Coo";
    }
}
