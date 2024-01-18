
//using proplems_solved.A._Petya_and_Strings;

//string[] nk = new string[2];
//nk[0] = Console.ReadLine();
//nk[1] = Console.ReadLine();
//Console.WriteLine(Petya_and_Strings.Petya_and_Strings_comparer(nk[0], nk[1]));


namespace proplems_solved.A._Petya_and_Strings
{
    public static class Petya_and_Strings
    {
        public static string Petya_and_Strings_comparer(string st1,string st2)
        {
            int lenth=st1.Length;
            for (int i = 0; i < lenth; i++)
            {
                if (st1[i] == st2[i])
                    continue;
                else if (char.ToLower(st1[i]) == char.ToLower(st2[i]))
                    continue;
                else if (char.ToLower(st1[i]) > char.ToLower(st2[i]))
                    return "1";
                else
                    return "-1";
            }
            return "0";
        }
    }
}
