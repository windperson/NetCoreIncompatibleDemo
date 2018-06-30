using System;
using DemoOldAPM;

namespace NetFramework35Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press any key to begin trying Old Delgate based APM operation on .Net Framework 3.5");
            Console.ReadKey();
            var oldApm = new OldApmDemo();

            oldApm.DoOldApm();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}