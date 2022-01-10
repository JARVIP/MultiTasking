using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTasking.MultiThreading
{
    internal delegate void ResultCallbackDelegate(int Results);

    internal class RetrieveDataFromThreadFunction
    {
        private int _number;
        private ResultCallbackDelegate _resultCallbackDelegate;

        internal RetrieveDataFromThreadFunction(int number, ResultCallbackDelegate resultCallbackDelagate)
        {
            _number = number;
            _resultCallbackDelegate = resultCallbackDelagate;
        }

        internal void CalculateSum()
        {
            int Result = 0;
            for (int i = 1; i <= _number; i++)
            {
                Result = Result + i;
            }
            if (_resultCallbackDelegate != null)
            {
                _resultCallbackDelegate(Result);
            }
        }
    }
}
