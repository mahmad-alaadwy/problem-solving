namespace proplems_solved.Algorithms.Sorting
{
    public static class SelectionSort<T> where T : IComparable
    {
        public static T[] Sort(T[] inputArray)
        {
            int length = inputArray.Length;
            int minimumIndx;

            for (int j = 0; j < length; j++)
            {
                minimumIndx = j;
                for (int i = j; i < length; i++)
                {
                    if (inputArray[i].CompareTo(inputArray[minimumIndx]) <= 0)
                        minimumIndx = i;
                }
                if (minimumIndx != j)
                    SwapElements(minimumIndx, j, inputArray);
            }
            return inputArray;
        }

        private static void SwapElements(int index1, int index2, T[] containingArray)
        {
            T temp = containingArray[index1];
            containingArray[index1] = containingArray[index2];
            containingArray[index2] = temp;
        }
    }
}
