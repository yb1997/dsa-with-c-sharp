using System;
using DSAPractice.Algorithms.Sorting;
using System.Linq;

namespace DSAPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new int[] { 40, 30, 20, 30, 10 };
            var expectedItems = new int[] { 10, 20, 30, 30, 40 };
            //BubbleSort.Sort(items);
            //InsertionSort.Sort(items);
            //SelectionSort.Sort(items);
            //CountSort.Sort(items);
            RadixSort.Sort(items);
            var isSorted = items.SequenceEqual(expectedItems);
            Console.WriteLine($"isSorted: {isSorted}");

            Console.ReadKey();
        }
    }
}
