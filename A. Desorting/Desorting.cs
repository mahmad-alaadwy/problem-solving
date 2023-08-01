using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


/*
 * 

the bellow code is program.cs 

//Console.WriteLine("enter the number of iterations \n");


using proplems_solved.A._Desorting;

int Iterations = Convert.ToInt32(Console.ReadLine());

int[] answers = new int[Iterations]; 

for(int i = 0;i < Iterations; i++)
{
    //Console.WriteLine("enter the number of items in the array \n");
    int n = Convert.ToInt32(Console.ReadLine());

   // Console.WriteLine("enter the array to check it \n");
    int[] array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

    var Desort=new Desorting(n,array);
    answers[i] = Desort.findMinimumOperationsToMakeItUnsorted();
}

foreach(int i in answers)
{
    Console.WriteLine(i);
}





*/


namespace proplems_solved.A._Desorting
{
    //this class should take the array and return the number of operations 
    //required to make it unsorted 


    //to solve it first need to :
    //1 find the two elements most near to each other 
    //2 seconed divide the difference by two and its the answer
    //using proplems_solved.A._Desorting;


    class Desorting
    {
        private int[] _arr;
        private int[] differences;

        public Desorting(int n, int[] arr)
        {
            _arr = arr;
            differences = new int[n - 1];
        }

        public void findDeiffs()
        {
            for (var i = 0; i < differences.Length; i++)
            {
                differences[i] = _arr[i + 1] - _arr[i];
            }
        }

        public int findMIn(int[] arr)
        {
            var minIdex = 0;

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIdex])
                {
                    minIdex = i;
                }
            }
            return minIdex;
        }
        public int findMinimumOperationsToMakeItUnsorted()
        {
            findDeiffs();

            foreach (var i in differences)
            {
                if (i < 0)
                    return 0;
            }

            int minIndex = findMIn(differences);
            int minValue = differences[minIndex];
            int MInNumberOfOpertions = (int)(minValue / 2);
            MInNumberOfOpertions += 1;

            return MInNumberOfOpertions;
        }
    }
}
