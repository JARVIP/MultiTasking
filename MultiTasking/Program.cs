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

            ResultCallbackDelegate resultCallbackDelegate = new ResultCallbackDelegate(ResultCallBackMethod);

            int number = 10;
            RetrieveDataFromThreadFunction obj = new RetrieveDataFromThreadFunction(number, resultCallbackDelegate);

            Thread t1 = new Thread(new ThreadStart(obj.CalculateSum));

            t1.Start();
            Console.Read();
            #endregion
        }

        public static void ResultCallBackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }
    }
}
