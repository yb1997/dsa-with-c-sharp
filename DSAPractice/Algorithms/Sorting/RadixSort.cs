using System.Linq;

namespace DSAPractice.Algorithms.Sorting
{
    class RadixSort
    {
        private static int GetDigit(int num, int place)
        {
            return (num / place) % 10;
        }

        public static void Sort(int[] items)
        {
            int max = items.Max();

            for (int place = 1; max / place > 0; place *= 10)
            {
                CountSort.Sort(items, num => GetDigit(num, place));
            }
        }
    }
}
