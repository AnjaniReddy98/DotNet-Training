﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadProirity
{
    class Program
    {
        public static long Count1, Count2;
        static void Main(string[] args)
        {
           
            Console.WriteLine("The main thread is started");

            Thread T1 = new Thread(IncrementCount1);
            Thread T2 = new Thread(IncrementCount2);

            T1.Start();
            T2.Start();

            T1.Priority = ThreadPriority.Lowest;
            T2.Priority = ThreadPriority.Highest;

            Thread.Sleep(10000);

            T1.Abort();
            T2.Abort();

            T1.Join();
            T2.Join();


            Console.WriteLine("Count1: {0}", Count1);
            Console.WriteLine("Count2: {0}", Count2);

            Console.WriteLine("The main thread is excited");

        }
        public static void IncrementCount1()
        {
            while (true)
            {
                Count1 += 1;
            }
                
        }
        public static void IncrementCount2()
        {
            while (true)
            {
                Count2 += 1;
            }

        }

    }
}
