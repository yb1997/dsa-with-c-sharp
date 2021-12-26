using System;
using System.Linq;

namespace DSAPractice.Algorithms.Sorting
{
    class CountSort
    {
        public static void Sort(int[] items)
        {
            Sort(items, ValueToCountOccurencesFor);
        }

        public static void Sort(int[] items, Func<int, int> Val)
        {
            if (Val is null) throw new ArgumentNullException(nameof(Val));

            int max = items.Max();
            var count = new int[max + 1];
            var output = new int[items.Length];

            Array.ForEach(items, num => ++count[Val(num)]);

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            Array.ForEach(items, num =>
            {
                var index = count[Val(num)] - 1;
                output[index] = num;
                --count[Val(num)];
            });

            Array.Copy(output, items, items.Length);
        }

        static int ValueToCountOccurencesFor(int val)
        {
            return val;
        }
    }
}
