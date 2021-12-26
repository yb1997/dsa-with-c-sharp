using System;
using System.Linq;

namespace DSAPractice.Algorithms.Sorting
{
    class CountSort
    {
        public static void Sort(int[] items)
        {
            int max = items.Max();
            var count = new int[max + 1];
            var output = new int[items.Length];

            Array.ForEach(items, num => ++count[num]);

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            Array.ForEach(items, num =>
            {
                var index = count[num] - 1;
                output[index] = num;
            });

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = output[i];
            }
        }
    }
}
