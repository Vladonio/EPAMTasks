using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Euclid
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch elapsedTicks = new Stopwatch();
            double kek = 255.255;
            Console.WriteLine(kek.GetDoubleInBinary());

            EuclidAlgorithms alg = new EuclidAlgorithms();
            Console.WriteLine(alg.EuclidGCD(ref elapsedTicks, 54, 36, 12));
            Console.WriteLine(elapsedTicks.ElapsedTicks);
            
        }
    }
}
