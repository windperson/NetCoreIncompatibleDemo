using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoOldAPM;

namespace NefFrameworkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to begin run Task based Async on .Net Framework 4.x");
            Console.ReadKey();
            var oldApm = new OldApmDemo();

            oldApm.DoOldApm();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
