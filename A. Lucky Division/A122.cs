
//A122.PrintYesIfItsAlmostLuckyNumber(Console.ReadLine());

namespace proplems_solved.A._Lucky_Division
{
    public static class A122
    {
        public static void PrintYesIfItsAlmostLuckyNumber(string input)
        {
            if (int.TryParse(input, out int inputNumber))
            {
                Console.WriteLine(IsLuckyNumber(inputNumber) ? "YES" : "NO");
            }
            else
            {
                Console.WriteLine("please enter a valid number ");
            }
        }
        private static bool IsLuckyNumber(int number)
        {
            if (!(number < 4) && 
                (number % 4 == 0 || number % 7 == 0 || number % 47 == 0 || number % 74 == 0 
                || number % 447 == 0 || number % 774 == 0 || number % 477 == 0 || number % 744 == 0))
            {
                return true;
            }
            else { return false; }
        }
    }
}
