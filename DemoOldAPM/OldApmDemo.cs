using System;
using System.Threading;
#if !NET35
using System.Threading.Tasks;

#endif

namespace DemoOldAPM
{
    public class OldApmDemo
    {
        private delegate int AsyncDelegate(int input, TimeSpan waitTimeSpan);

        private readonly TimeSpan _dummyAsyncWaitinTimeSpan = new TimeSpan(0, 0, 5);

        public void DoOldApm()
        {
#if NET35
            Console.WriteLine("Start APM-based async.");
            try
            {
                AsyncDelegate asyncDelegate = FakeAyncMethod;

                IAsyncResult asyncResult = asyncDelegate.BeginInvoke(123, _dummyAsyncWaitinTimeSpan, ar =>
                {
                    var result = asyncDelegate.EndInvoke(ar);
                    Console.WriteLine("result=" + result);
                }, null);

                Console.WriteLine("Wait...");
                do
                {
                    Thread.Sleep(100);
                } while (!asyncResult.IsCompleted);

                Console.WriteLine("Async Delegate Finished.");

            }
            catch (PlatformNotSupportedException ex)
            {
                Console.WriteLine("PlatformNotSupportedException=" + ex);
            }         
#else
            Console.WriteLine("Start Task-based async.");
            var asyncTask = Task<int>.Factory.StartNew(() => FakeAyncMethod(123, _dummyAsyncWaitinTimeSpan));
            Console.WriteLine("Wait...");
            asyncTask.Wait();
            var result = asyncTask.Result;
            Console.WriteLine($"result={result}");
            Console.WriteLine("Task based Async Finished.");
#endif
        }

        private static int FakeAyncMethod(int x, TimeSpan waitTime)
        {
#if NET35 != true
            Task.Delay(waitTime).Wait();
#else
            Thread.Sleep(waitTime);
#endif
            return x;
        }
    }
}