//string word = Console.ReadLine();
//A58.PrintYesIfContainHello(word);
public static class A58
{
    public static void PrintYesIfContainHello(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            Console.WriteLine("NO");
            return;
        }
        //assuming that the input word is already lower case so no need to convert it
        int lenght = word.Length;
        string hello = "hello";
        int currentChar = 0;
        for (int i = 0; i < lenght; i++)
        {
            if (word[i] == hello[currentChar])
                currentChar++;
            if (currentChar == 5)
            {
                Console.WriteLine("YES");
                return;
            }
        }
        Console.WriteLine("NO");
    }
}
