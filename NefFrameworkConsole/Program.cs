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
            Console.WriteLine("Press any key to begin trying Old Delgate based APM operation on .Net Framework");
            Console.ReadKey();
            var oldApm = new OldApmDemo();

            oldApm.DoOldApm();

            Console.WriteLine("Wait....");
            Console.ReadKey();
        }
    }
}
