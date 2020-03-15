using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%Quick sort algorithm tests%%%\n");
            //QuickSort tests
            int[] array1 = new int[] { 12, 35, 12, -5, 0, 81, -44 };
            int[] array2 = { 10, -10 };
            int[] array3 = { 1 };
            int[] array4 = { };
            QuickSort(array1, 0, array1.Length - 1);
            QuickSort(array2, 0, array2.Length - 1);
            QuickSort(array3, 0, array3.Length - 1);
            QuickSort(array4, 0, array4.Length - 1);

            foreach (int i in array1)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
            foreach (int i in array2)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
            foreach (int i in array3)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
            foreach (int i in array4)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();

            Console.WriteLine("%%%Merge sort algorithm tests%%%\n");
            //MergeSort tests
            array1 = new int[] { 12, 35, 12, -5, 0, 81, -44 };
            array2 = new int[] { 10, -10 };
            array3 = new int[] { 1 };
            array4 = new int[] { };

            array1 = MergeSort(array1);
            array2 = MergeSort(array2);
            array3 = MergeSort(array3);
            array4 = MergeSort(array4);

            foreach (int i in array1)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
            foreach (int i in array2)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
            foreach (int i in array3)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
            foreach (int i in array4)
            {
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
        }

        private static void QuickSort(int[] array, int min, int max)
        {
            if (array.Length == 0)
                return;
            int median = array[max - ((max - min) % 2)];
            int i = min;
            int j = max;
            while (i < j)
            {
                while (array[i] < median)
                    i++;
                while (array[j] > median)
                    j--;
                if (i <= j)
                {
                    Swap(ref array[i], ref array[j]);
                    i++;
                    j--;
                }
            }
            if (j > min)
                QuickSort(array, min, j);
            if (i < max)
                QuickSort(array, i, max);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        private static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            int median = array.Length / 2;

            int[] array1 = GetPartOfArray(array, 0, median);
            int[] array2 = GetPartOfArray(array, median, array.Length - median);

            return Merge(MergeSort(array1), MergeSort(array2));
        }

        /// <summary>
        /// Merge Method for merging and sorting two arrays
        /// </summary>
        private static int[] Merge(int[] array1, int[] array2)
        {
            int ptr1 = 0;
            int ptr2 = 0;
            int[] merged = new int[array1.Length + array2.Length];
            for (int i = 0; i < merged.Length; i++)
            {
                if (ptr1 < array1.Length && ptr2 < array2.Length)
                {
                    if (array1[ptr1] > array2[ptr2])
                    {
                        merged[i] = array2[ptr2++];
                    }
                    else
                    {
                        merged[i] = array1[ptr1++];
                    }
                }
                else
                {
                    if (ptr2 < array2.Length)
                    {
                        merged[i] = array2[ptr2++];
                    }
                    else
                    {
                        merged[i] = array1[ptr1++];
                    }
                }
            }
            return merged;
        }

        private static int[] GetPartOfArray(int[] array, int start, int length)
        {
            int[] resultArray = new int[length];
            for (int i = 0; i < length; i++)
            {
                resultArray[i] = array[i + start];
            }
            return resultArray;
        }
    }
}
