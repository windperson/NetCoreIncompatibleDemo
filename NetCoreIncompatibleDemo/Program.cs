﻿using System;
using DemoOldAPM;

namespace NetCoreIncompatibleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to begin run Task based Async on .Net Core");
            Console.ReadKey();
            var oldApm = new OldApmDemo();

            oldApm.DoOldApm();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
