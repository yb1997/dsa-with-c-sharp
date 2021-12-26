namespace DSAPractice.Algorithms.Sorting
{
    class InsertionSort
    {
        public static void Sort(int[] items)
        {
            for (int i = 1; i < items.Length; i++)
            {
                var target = items[i];

                int j = i - 1;

                for (; j >= 0; j--)
                {
                    if (items[j] > target)
                        items[j + 1] = items[j];
                    else
                        break;
                }

                items[j + 1] = target;
            }
        }
    }
}
