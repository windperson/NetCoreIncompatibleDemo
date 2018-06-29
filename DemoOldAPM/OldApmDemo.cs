using System;
using System.Threading;
using System.Threading.Tasks;

namespace DemoOldAPM
{
    public class OldApmDemo
    {
        private delegate int AsyncDelegate(int input, TimeSpan waitTimeSpan);
        public void DoOldApm()
        {
            try
            {
                AsyncDelegate asyncDelegate = AsyncWaitThenReturn;

                IAsyncResult asyncResult = asyncDelegate.BeginInvoke(123, new TimeSpan(0, 0, 1), ar =>
                {
                    var result = asyncDelegate.EndInvoke(ar);
                    Console.WriteLine("result=" + result);
                }, null);

                SpinWait.SpinUntil(() => asyncResult.IsCompleted);

                Console.WriteLine("Async Delegate Finished.");

            }
            catch (PlatformNotSupportedException ex)
            {
                Console.WriteLine("PlatformNotSupportedException=" + ex);
            }
        }

        private static int AsyncWaitThenReturn(int x, TimeSpan waitTime)
        {
            Task.Delay(waitTime).Wait();
            return x;
        }
    }
}
