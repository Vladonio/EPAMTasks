using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class FilterDigitAlgorithm
    {
        public List<int> FilterDigit(int digit, List<int> numbers)
        {
            string strDigit = digit.ToString();
            HashSet<int> numbersToRemove = new HashSet<int>();

            foreach (int num in numbers)
            {
                string strNum = num.ToString();
                if (!strNum.Contains(strDigit))
                {
                    numbersToRemove.Add(num);
                }
            }
            numbers.RemoveAll(numbersToRemove.Contains);

            return numbers;
        }
    }
}
