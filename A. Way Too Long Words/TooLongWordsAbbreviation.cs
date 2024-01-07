
//using proplems_solved.A._Way_Too_Long_Words;

//int iterations = int.Parse(Console.ReadLine());
//for (int i = 0; i < iterations; i++)
//{
//    string inputWord = Console.ReadLine();
//    Console.WriteLine(TooLongWordsAbbreviation.wordAbbreviationIfTooLong(inputWord));
//}

namespace proplems_solved.A._Way_Too_Long_Words
{
    public static class TooLongWordsAbbreviation
    {
        public static string wordAbbreviationIfTooLong(string word)
        {
            int wordLength=word.Length;
            if(wordLength > 10)
            {
                string abbreviation = "";
                abbreviation += word[0];
                abbreviation += wordLength - 2;
                abbreviation += word[wordLength-1];

                return abbreviation;
            }
            return word;
        }
    }
}
