using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiTasking.MultiThreading
{
    internal class TypesOfThreads
    {
        internal static void RunForegroundThread()
        {
            Thread thr = new Thread(() => Mythread("Foreground"));
            thr.Start();
            Console.WriteLine("Foreground Thread Ends!!");
        }

        internal static void RunBackgroundThread()
        {
            Thread thr = new Thread(() => Mythread("Background"));
            thr.Start();
            thr.IsBackground = true;
            Console.WriteLine("Background Thread Ends!!");
        }

        static void Mythread(string threadType)
        {
            for (int c = 1; c <= 4; c++)
            {

                Console.WriteLine(threadType + " method is in progress " + c);
                Thread.Sleep(1000);
            }
            Console.WriteLine(threadType + " method ends!!");
        }
    }
}
