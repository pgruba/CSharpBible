using Basics.Exceptions;
using System;
using Xunit;

namespace Test.Basics.Exceptions
{
    public class WaitGetAwaiterTest
    {
        [Fact]
        public void AsyncMethod_ThrowsArgumentException_WhenCalledWithWait()
        {
            WaitGetAwaiter instance = new WaitGetAwaiter();
            Assert.Throws<AggregateException>(() => instance.InvokeWithWait());
        }

        [Fact]
        public void AsyncMethod_ThrowsArgumentException_WhenCalledWithGetAwaiter()
        {
            WaitGetAwaiter instance = new WaitGetAwaiter();
            Assert.Throws<ArgumentException>(() => instance.InvokeWithGetAwaiterGetResult());
        }
    }
}