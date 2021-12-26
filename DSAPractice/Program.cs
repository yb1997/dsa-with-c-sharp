using System;
using DSAPractice.Algorithms.Sorting;
using System.Linq;

namespace DSAPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new int[] { 30, 10, 20 };
            //BubbleSort.Sort(items);
            //InsertionSort.Sort(items);
            //SelectionSort.Sort(items);
            var expectedItems = new int[] { 10, 20, 30 };
            CountSort.Sort(items);
            bool isSorted = items.SequenceEqual(expectedItems);
            Console.WriteLine($"isSorted: {isSorted}");

            Console.ReadKey();
        }
    }
}
