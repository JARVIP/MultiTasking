using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiTasking.MultiThreading
{
    internal class ProtectingSharedResource
    {
        private int _count = 0;
        private object _lockObject = new object();

        public int Count { get { return _count; } }
        public ProtectingSharedResource(int count)
        {
            _count = count;
        }

        /// <summary>
        /// Lock
        /// </summary>
        internal void IncrementCount()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                lock (_lockObject)
                {
                    _count++;
                }
            }
        }

        /// <summary>
        /// Monitor
        /// </summary>
        internal void PrintNumbers()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter into the critical section");
            Monitor.Enter(_lockObject);
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(_lockObject);
                Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical section");
            }
        }

        private static Mutex mutex = new Mutex();

        internal void MutexDemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter Critical Section for processing");
            try
            {
                mutex.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");
                Thread.Sleep(2000);
                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is Completed its task");
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}
