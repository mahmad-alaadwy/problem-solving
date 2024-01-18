using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proplems_solved.B._Fibonaccharsis
{
    class Fibonaccharsis
    {
        public List<int> fabList { get; set; }
        public int _n { get; set; }
        public int _k { get; set; }

        public Fibonaccharsis(int n,int k)
        {
            _n= n;
            _k= k;
        }

        /* 
         * 
         There are 4 valid fibonacci-like sequences for n=22, k=4
            
            [6,8,14,22]
            ,
            [4,9,13,22]
            ,
            [2,10,12,22]
            ,
            [0,11,11,22]
            .

            0   1    2   3   4   5   6   7   8   9   10  11  12  13  14  15  16  17  18  19  20  21 
           []   []   []  []  []  []  []  []  []  []  []  []  []  []  []  []  []   []  []  []  []  [] 
           []   []   []  []  []  []  []  []  []  []  []  []  []  []  []  []  []   []  []  []  []  [] 
           []   []   []  []  []  []  []  []  []  []  []  []  []  []  []  []  []   []  []  []  []  [] 

         */

        public void findFabonachies()
        {
            for(int i=0;i<_n; i++)
            {

            }
        }
    }
}
