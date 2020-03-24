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
                Console.WriteLine("i must be less or equal than j");
                return 0;
            }
            int maskj1 = 0x7FFFFFFF & ((1 << (j - i + 1)) - 1); //zeroing all high bits after j

            num2 = (num2 & maskj1) << i; //moving bits to position j...i of the first number
            return num1 | num2;
        }
    }
}
