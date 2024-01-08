//using proplems_solved.A._Next_Round;

//int[] nk = new int[2];
//nk = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

//int[] scores = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
//Console.WriteLine(NextRound.GetNumberOfPassedContestants(scores, nk[1], nk[0]));


namespace proplems_solved.A._Next_Round
{
    public static class NextRound
    {
        public static int GetNumberOfPassedContestants(int[] scores,int pivot,int length)
        {
            int count = 0;
            for(int i=0;i< length; i++)
            {
                if (scores[i] >= scores[pivot - 1] && scores[i]>0)
                    count++;
            }
            return count;
        }
    }
}
