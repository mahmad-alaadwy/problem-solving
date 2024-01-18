

//using proplems_solved.A._Domino_piling;

//int[] nk = new int[2];
//nk = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

//int NumberOfDominoThatFits = Domino_piling.NumberOfDominoFitInTheBoard(nk[1], nk[0]);
//Console.WriteLine(NumberOfDominoThatFits);


namespace proplems_solved.A._Domino_piling
{
    public static class Domino_piling
    {
        public static int NumberOfDominoFitInTheBoard(int l, int t)
        {
            //each domino fits 2 meters then the number of domino = the area//2;
            int area = l * t;
            return (int)area / 2;
        }
    }
}
