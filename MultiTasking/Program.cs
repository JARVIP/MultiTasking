using MultiTasking.MultiThreading;
using System;
using System.Threading;

namespace MultiTasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SimultaneousLaunchOfTwoMethod.Run();
            //TypesOfThreads.RunForegroundThread();
            //TypesOfThreads.RunBackgroundThread();

            #region PassDataTypeSafeManner
            //int Max = 10;
            //PassDataTypeSafeManner obj = new PassDataTypeSafeManner(Max);
            //Thread T1 = new Thread(new ThreadStart(obj.DisplayNumbers));
            //T1.Start();
            #endregion

            #region RetrieveDataFromThreadFunction

            //ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallBackMethod);

            //int number = 10;
            //RetrieveDataFromThreadFunction obj = new RetrieveDataFromThreadFunction(number, resultCallbackDelegate);

            //Thread t1 = new Thread(new ThreadStart(obj.CalculateSum));

            //t1.Start();
            //Console.Read();
            #endregion

            #region ProtectingSharedResource

            //lock
            ProtectingSharedResource obj = new ProtectingSharedResource(0);
            //Thread t1 = new Thread(obj.IncrementCount);
            //Thread t2 = new Thread(obj.IncrementCount);
            //Thread t3 = new Thread(obj.IncrementCount);
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //t1.Join();
            //t2.Join();
            //t3.Join();
            //Console.WriteLine(obj.Count);
            //Console.Read();

            //monitor

            //Thread[] Threads = new Thread[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Threads[i] = new Thread(obj.PrintNumbers);
            //    Threads[i].Name = "Child Thread " + i;
            //}
            //foreach (Thread t in Threads)
            //{
            //    t.Start();
            //}
            //Console.ReadLine();


            // Mutex

            for (int i = 1; i <= 5; i++)
            {
                Thread threadObject = new Thread(obj.MutexDemo);
                threadObject.Name = "Thread " + i;
                threadObject.Start();
            }
            Console.ReadKey();

            #endregion
        }

        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }
    }
}
