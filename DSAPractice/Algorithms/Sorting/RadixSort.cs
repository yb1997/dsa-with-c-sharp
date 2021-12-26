using System;
using System.Linq;

namespace DSAPractice.Algorithms.Sorting
{
    class RadixSort
    {
        private static int GetDigit(int num, int place)
        {
            return (num / place) % 10;
        }
        class CountSort
        {
            public static void Sort(int[] items, int place) 
            {
                int size = items.Length;
                int max = items.Max();
                var count = new int[max + 1];
                var output = new int[size];

                Array.ForEach(items, num => ++count[GetDigit(num, place)]);

                for (int i = 1; i < count.Length; i++)
                {
                    count[i] += count[i - 1];
                }

                Array.ForEach(items, num =>
                {
                    int index = count[GetDigit(num, place)] - 1;
                    output[index] = num;
                    --count[GetDigit(num, place)];
                });

                Array.Copy(output, items, size);
            }
        }


        public static void Sort(int[] items)
        {
            int max = items.Max();

            for (int place = 1; max / place > 0; place *= 10)
            {
                CountSort.Sort(items, place);
            }
        }
    }
}
