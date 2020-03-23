using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclid
{
    public class EuclidAlgorithms
    {

        private int ClassicEuclidGCDAlgorithm(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        private int BinaryEuclidGCDAlgorithm(int a, int b)
        {
            if (a == b)
                return a;
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if ((~a & 1) != 0)
            {
                if ((b & 1) != 0)
                    return BinaryEuclidGCDAlgorithm(a >> 1, b);
                else
                    return BinaryEuclidGCDAlgorithm(a >> 1, b >> 1) << 1;
            }
            if ((~b & 1) != 0)
                return BinaryEuclidGCDAlgorithm(a, b >> 1);
            if (a > b)
                return BinaryEuclidGCDAlgorithm((a - b) >> 1, b);
            return BinaryEuclidGCDAlgorithm((b - a) >> 1, a);
        }

        public int EuclidGCD(ref Stopwatch elapsedTicks, params int[] nums)
        {
            elapsedTicks.Restart();
            int result = ClassicEuclidGCDAlgorithm(nums[0], nums[1]);
            for (int i = 1; i < nums.Length - 1; i ++)
            {
                result = ClassicEuclidGCDAlgorithm(result, nums[i + 1]);
            }
            elapsedTicks.Stop();
            return result;
        }

        public int BinaryEuclidGCD(ref Stopwatch elapsedTicks, params int[] nums)
        {
            elapsedTicks.Restart();
            int result = ClassicEuclidGCDAlgorithm(nums[0], nums[1]);
            for (int i = 1; i < nums.Length - 1; i++)
            {
                result = ClassicEuclidGCDAlgorithm(result, nums[i + 1]);
            }
            elapsedTicks.Stop();
            return result;
        }
    }
}
