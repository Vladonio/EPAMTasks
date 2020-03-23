using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertNumber
            Console.WriteLine("%InsertNumber%");
            InsertNumberAlgorithm insertNumber = new InsertNumberAlgorithm();
            Console.WriteLine(insertNumber.InsertNumber(15, 15, 0, 0));
            Console.WriteLine(insertNumber.InsertNumber(8, 15, 0, 0));
            Console.WriteLine(insertNumber.InsertNumber(8, 31, 3, 8));

            //FindNextBiggerNumber
            Console.WriteLine("%FindNextBiggerNumber%");
            NextBiggerNumberAlgorithm nextBiggerNumber = new NextBiggerNumberAlgorithm();
            Console.WriteLine($"Input:{12}, result: " + nextBiggerNumber.FindNextBiggerNumber(12));
            Console.WriteLine(nextBiggerNumber.FindNextBiggerNumber(513));
            Console.WriteLine(nextBiggerNumber.FindNextBiggerNumber(2017));
            Console.WriteLine(nextBiggerNumber.FindNextBiggerNumber(144));
            Console.WriteLine(nextBiggerNumber.FindNextBiggerNumber(1234126));
            Console.WriteLine(nextBiggerNumber.FindNextBiggerNumber(10));

            //FilterDigit
            Console.WriteLine("%FilterDigit%");
            FilterDigitAlgorithm filterDigit = new FilterDigitAlgorithm();
            var numbers = filterDigit.FilterDigit(7, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 });
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //FindNthRoot
            Console.WriteLine("%FindNthRoot%");
            FindNthRootAlgorithm findNthRoot = new FindNthRootAlgorithm();
            Console.WriteLine(findNthRoot.FindNthRoot(1, 5, 0.0001));
            Console.WriteLine(findNthRoot.FindNthRoot(8, 3, 0.0001));
            Console.WriteLine(findNthRoot.FindNthRoot(0.001, 3, 0.0001));
            Console.WriteLine(findNthRoot.FindNthRoot(0.04100625, 4, 0.0001));
            Console.WriteLine(findNthRoot.FindNthRoot(-0.008, 3, 0.1));
            Console.WriteLine(findNthRoot.FindNthRoot(0.004241979, 9, 0.00000001));

        }

    }
}
