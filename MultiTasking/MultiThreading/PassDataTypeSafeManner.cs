using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTasking.MultiThreading
{
    internal class PassDataTypeSafeManner
    {
        int _number;

        internal PassDataTypeSafeManner(int number)
        {
            _number = number;
        }

        public void DisplayNumbers()
        {
            for (int i = 1; i <= _number; i++)
            {
                Console.WriteLine("value : " + i);
            }
        }
    }
}
