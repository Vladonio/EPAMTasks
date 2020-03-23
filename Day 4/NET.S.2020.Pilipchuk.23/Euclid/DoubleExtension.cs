using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Euclid
{
    
    public static class DoubleExtension
    {
        public static string GetDoubleInBinary(this double num)
        {
            DoubleStruct newDouble = new DoubleStruct(num);
            long numInLong = newDouble.lng;
            StringBuilder bits = new StringBuilder();
            char sign = '0';
            if (numInLong >> 63 == -1)
            {
                sign = '1';
            }
            long mask = 1L;
            for (int i = 0; i < 63; i++)
            {
                bits.Append((numInLong & mask) >> i).ToString();
                mask = mask << 1;
            }
            StringBuilder result = new StringBuilder();
            foreach (var item in bits.ToString().Reverse())
            {
                result.Append(item);
            }
            return sign.ToString() + result.ToString();
        }


        [StructLayout(LayoutKind.Explicit)]
        private struct DoubleStruct
        {
            [FieldOffset(0)]
            public long lng;
            [FieldOffset(0)]
            public double dbl;

            public DoubleStruct(double b)
            {
                lng = 0;
                dbl = b;
            }
        }

    }

 
}
