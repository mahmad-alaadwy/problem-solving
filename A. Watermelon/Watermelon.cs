
//var inputWatermelonWieght = int.Parse(Console.ReadLine());
//Console.WriteLine(Watermelon.CanBeDevidedIntoTwoEvenWieghts(inputWatermelonWieght));


namespace proplems_solved.A._Watermelon
{
    public static class Watermelon
    {
        public static string CanBeDevidedIntoTwoEvenWieghts(int wieght)
        {
            if ((wieght % 2) % 2 == 0)
            {
                return "YES";
            }
            return "No";
        }
    }
}

