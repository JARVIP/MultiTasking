using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiTasking.MultiThreading
{
    internal class SimultaneousLaunchOfTwoMethod
    {
        internal static void Run()
        {
            Thread thr1 = new Thread(Method1);
            Thread thr2 = new Thread(Method2);
            thr1.Start();
            thr2.Start();
        }

        static void Method1()
        {
            for (int I = 0; I <= 10; I++)
            {
                Console.WriteLine("Method1 is : {0}", I);

                if (I == 5)
                {
                    Thread.Sleep(600);
                }
            }
        }

        static void Method2()
        {
            for (int J = 0; J <= 10; J++)
            {
                Console.WriteLine("Method2 is : {0}", J);
            }
        }
    }
}
