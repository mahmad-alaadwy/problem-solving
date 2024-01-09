

using proplems_solved.A._Bit__;

int numberOfIterations = int.Parse(Console.ReadLine());
int x = 0;
for (int i = 0; i < numberOfIterations; i++)
{
    var statement = Console.ReadLine();
    x = Bit.Execute(statement, x);
}
Console.WriteLine(x);

namespace proplems_solved.A._Bit__
{
    public static class Bit
    {
        public static int Execute(string compiledstatement,int currentValue)
        {
            if (compiledstatement[1] == '+')
                return ++currentValue;

            return --currentValue;
        }
    }
}
