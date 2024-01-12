namespace proplems_solved.Algorithms.Sorting
{
    public static class BubbleSort<T> where T : IComparable
    {
        public static T[] Sort(T[] array)
        {
            int length = array.Length;
            bool isNotSorted;

            for (int i = 0; i < length; i++)
            {
                isNotSorted = false;
                for (int j = length - 1; j > i  ; j--)
                {
                    if (array[j].CompareTo(array[j - 1]) < 0)
                    {
                        SwapElements(j - 1, j, array);
                        isNotSorted = true;
                    }
                }
                if (!isNotSorted)
                {
                    return array;
                }
            }
            return array;
        }
        private static void SwapElements(int index1, int index2, T[] containingArray)
        {
            T temp = containingArray[index1];
            containingArray[index1] = containingArray[index2];
            containingArray[index2] = temp;
        }
    }
}
