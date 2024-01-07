

//using proplems_solved.A_Team;
//var iterations = int.Parse(Console.ReadLine());
//int numberOfSubmitedProblems = 0;
//for (int i = 0; i < iterations; i++)
//{
//    int[] input = new int[3];
//    input = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
//    numberOfSubmitedProblems += Team.IsImplemented(input[0], input[1], input[2]);
//}
//Console.WriteLine(numberOfSubmitedProblems);



namespace proplems_solved.A_Team
{
    public static class Team
    {
        public static int IsImplemented(int player1, int player2, int player3)
        {
            if (player1 * player2 > 0)
            {
                return 1;
            }

            else if (player1 * player3 > 0)
            {
                return 1;
            }

            else if (player2 * player3>0)
            {
                return 1;
            }

            return 0;
        }
    }
}

