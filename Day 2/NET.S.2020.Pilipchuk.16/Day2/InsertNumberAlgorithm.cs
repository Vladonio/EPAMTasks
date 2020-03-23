using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class InsertNumberAlgorithm
    {
        public int InsertNumber(int num1, int num2, int i, int j)
        {
            if (i > j)
            {
                Console.WriteLine("i must be less than j");
                return 0;
            }

            int maskj = 0x7FFFFFFF & ((1 << (j + 1)) - 1); //зануляем все биты слева от диапазона j-i
            int maski = 0x7FFFFFFF ^ ((1 << i) - 1); //зануляем все биты справа от диапазона j-i

            Console.WriteLine($"MY RESULT: {num1 | (num2 & maskj & maski)}");


            return num1 | (num2 & maskj & maski);
        }
    }
}
