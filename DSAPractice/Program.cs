using System;
using DSAPractice.Algorithms.Sorting;
using System.Linq;

namespace DSAPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new int[] { 4, 3, 2, 3, 1 };
            var expectedItems = items.ToArray(); 
            Array.Sort(expectedItems);
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
