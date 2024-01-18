using proplems_solved.Algorithms.Sorting;

namespace proplems_solved.A._Helpful_Maths
{
    public static class AHelpfulMaths
    {
        public static string SumHelper(string expression)
        {
            return GetTheSortedExpression(Sort(GetSummandInts(GetSummands(expression))));
        }
        private static string[] GetSummands(string expression) 
        {
            return expression.Split('+');
        }
        private static int[] GetSummandInts(string[] StrSummands)
        {
            int[] intSummands=new int[StrSummands.Length];
            for(int i=0;i<StrSummands.Length;i++)
            {
                intSummands[i] = int.Parse(StrSummands[i]);
            }
            return intSummands;
        }
        private static int[] Sort(int[] nums)
        {
            BubbleSort<int>.Sort(nums);
            return nums;
        }
        private static string GetTheSortedExpression(int[] numbs)
        {
            string stringExpression = "";
            foreach(int num in numbs)
            {
                stringExpression += num;
                stringExpression += '+';
            }
            //removeing the last "+" and returning the output formated
            return stringExpression.Remove(stringExpression.Length-1);
        }
    }
}
