using System;
using System.Threading.Tasks;

namespace Basics.Exceptions
{
    /// <summary>
    /// https://www.codurance.com/publications/2018/12/06/wait-and-getawaiter
    /// </summary>
    public class WaitGetAwaiter
    {
        protected class AsyncMock
        {
            public async Task DoAsync()
            {
                for (int i = 0; i < 4; i++)
                    CheckError(i);

            }

            public void CheckError(int value)
            {
                if (value == 2) throw new ArgumentException();
            }
        }

        /// <summary>
        /// Async method invoked with Wait will throw Aggregate exception overwriting stack trace and hiding the root cause
        /// </summary>
        public void InvokeWithWait()
        {
            AsyncMock am = new AsyncMock();

            am.DoAsync().Wait();
        }

        /// <summary>
        /// Async called with GetAwaiter will remain stack trace and show the root cause. It will throw ArgumentException
        /// </summary>
        public void InvokeWithGetAwaiterGetResult()
        {
            AsyncMock am = new AsyncMock();

            am.DoAsync().GetAwaiter().GetResult();
        }
    }
}