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
        }
    }
}
