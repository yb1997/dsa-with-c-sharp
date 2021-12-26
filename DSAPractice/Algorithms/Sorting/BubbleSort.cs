namespace DSAPractice.Algorithms.Sorting
{
    class BubbleSort
    {
        private static void Swap(int[] items, int x, int y) 
        {
            int temp = items[x];
            items[x] = items[y];
            items[y] = temp;
        }
        public static void Sort(int[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                var isSwapped = false;
                for (int j = 1; j < items.Length; j++)
                {
                    if (items[j] < items[j - 1])
                    {
                        Swap(items, j, j - 1);
                        isSwapped = true;
                    }
                }
                if (!isSwapped) break;
            }
        }
    }
}
