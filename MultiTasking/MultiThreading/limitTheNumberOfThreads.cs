using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiTasking.MultiThreading
{
    internal class LimitTheNumberOfThreads
    {
        private Semaphore semaphore;

        public LimitTheNumberOfThreads()
        {
            semaphore = new Semaphore(2, 3);
        }

        internal void DoSomeTask(object id)
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter into Critical Section for processing");
            try
            {
                //Blocks the current thread until the current WaitHandle receives a signal.   
                semaphore.WaitOne();
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Doing its work");
                Thread.Sleep(5000);
                Console.WriteLine(Thread.CurrentThread.Name + "Exit.");
            }
            finally
            {
                //Release() method to releage semaphore  
                semaphore.Release();
            }
        }
    }
}
