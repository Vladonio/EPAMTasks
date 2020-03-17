using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class FindNthRootAlgorithm
    {

        //Xk+1 = Xk * (1 - (1 - (A / Xk^n)) / n);
        public double FindNthRoot(double x, double n, double e)
        {
            var x0 = x / n; //начальное предположение
            var x1 = x0 * (1 - (1 - (x / Math.Pow(x0, n))) / n);
            while (Math.Abs(x1 - x0) > e)
            {
                x0 = x1;
                x1 = x0 * (1 - (1 - (x / Math.Pow(x0, n))) / n);
            }
            return Math.Round(x1, 3);
        }
    }
}
