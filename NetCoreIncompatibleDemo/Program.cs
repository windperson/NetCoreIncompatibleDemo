﻿using System;
using DemoOldAPM;

namespace NetCoreIncompatibleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to begin trying Old Delgate based APM operation on .Net Core");
            Console.ReadKey();
            var oldApm = new OldApmDemo();

            oldApm.DoOldApm();

            Console.WriteLine("Wait....");
            Console.ReadKey();
        }
    }
}
