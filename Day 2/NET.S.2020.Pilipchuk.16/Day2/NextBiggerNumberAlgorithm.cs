using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class NextBiggerNumberAlgorithm
    {
        private HashSet<int> possibleNumbers;

        private void SetAllPossibleNumbers(List<int> digits, string currNumber = "")
        {
            if (digits.Count == 0)
            {
                possibleNumbers.Add(int.Parse(currNumber));
                return;
            }

            for (int i = 0; i < digits.Count; i++)
            {
                List<int> newDigits = new List<int>(digits);
                newDigits.RemoveAt(i);
                SetAllPossibleNumbers(newDigits, currNumber + digits[i].ToString());
            }
        }

        public int FindNextBiggerNumber(int number)
        {
            possibleNumbers = new HashSet<int>();
            SetAllPossibleNumbers(GetDigitsFromNumber(number));

            int min = int.MaxValue;
            foreach (int item in possibleNumbers)
            {
                if (item > number && item < min)
                {
                    min = item;
                }
            }

            Console.WriteLine(DateTime.Now);
            if (min == int.MaxValue)
                return -1;
            return min;
        }

        private List<int> GetDigitsFromNumber(int number)
        {
            List<int> digits = new List<int>();
            int digitToAdd;
            while (number > 0)
            {
                digitToAdd = number % 10;
                number /= 10;
                digits.Insert(0, digitToAdd);
            }
            return digits;
        }
    }
}
