using System;
using System.Linq;

namespace DSAPractice.Algorithms.Sorting
{
    class CountSort
    {
        /// <summary>
        /// Sorts an array in linear time - <b>d(n + k)</b> <br/>
        /// where <b>d</b> is number of digits of largest number, <b>n</b> is number of items<br/> 
        /// and <b>k</b> means largest number
        /// </summary>
        /// <param name="items"></param>
        public static void Sort(int[] items)
        {
            Sort(items, ValueToCountOccurencesFor);
        }

        /// <inheritdoc cref="Sort(int[])"/>
        /// <exception cref="ArgumentNullException"></exception>
        /// <param name="Val"></param>
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
