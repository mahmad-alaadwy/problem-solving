using System.Numerics;

namespace proplems_solved.A._Calculating_Function
{
    public static class _486problemA
    {
        public static int PrintFOfNum(string input)
        {
            if (BigInteger.TryParse(input, out BigInteger number))
            {
                Console.WriteLine(FOfNumber(number));
            }
            else
            {
                throw new Exception("please enter a valid number");
            }
            return 0;
        }

        private static BigInteger FOfNumber(BigInteger number)
        {
            BigInteger largestEvenLessThanN = number % 2 == 0 ? number : number - 1;
            BigInteger sumEven = largestEvenLessThanN / 2 * (largestEvenLessThanN / 2 + 1);
            BigInteger largestOddLessThanN = number % 2 == 1 ? number : number - 1;
            BigInteger sumOdd = (largestOddLessThanN / 2 + 1) * (largestOddLessThanN / 2 + 1);
            return sumEven - sumOdd;
        }
    }
}
