namespace DSAPractice.Algorithms.Sorting
{
    class SelectionSort
    {
        public static void Swap(int[] items, int x, int y)
        {
            int temp = items[x];
            items[x] = items[y];
            items[y] = temp;
        }
        public static void Sort(int[] items)
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                int minElIndex = i;

                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[j] < items[minElIndex])
                        minElIndex = j;
                }
                Swap(items, i, minElIndex);
            }
        }
    }
}
