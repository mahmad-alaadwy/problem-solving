using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proplems_solved.D._Balanced_Round
{
    class BalancedRound
    {
        private int _n { get; set; }
        private int _k { get; set; }
        private List<int> _Problems { get; set; }
        private List<int> _Diffs { get; set; }
        private bool _flag { get; set; }
        public int _Count { get; set; }


        public BalancedRound(int n,int k,int[] proplems) 
        {
            _n=n;
            _k=k;
            _Diffs=new List<int>();
            _flag=false;
            _Count=0;
            _Problems = new List<int>();

            for(int i=0;i<n;i++)
            {
                _Problems.Add(proplems[i]) ;
            }
        }

        public void findDiffs()
        {
            if (_Problems.Count > 1)
            {
                for (var i = 0; i < _Problems.Count - 1; i++)
                {
                    _Diffs.Add(_Problems[i] - _Problems[i+1]);
                }
            }
        }

        public void findDiffsGtK()
        {
            findDiffs();

            if (_flag|| _Diffs.Count==0)
            {
                return;
            }

            for(int i = 0; i < _Problems.Count; i++)
            {
                if (_Diffs[i] > 0)
                {
                    if (_Diffs[i] > _k)
                    {
                        _Problems.RemoveAt(i);
                        _Count += 1;
                        findDiffsGtK();
                    }
                }
                else
                {
                    if (Math.Abs(_Diffs[i]) > _k)
                    {
                        _Problems.RemoveAt(i-1);
                        _Count += 1;
                        findDiffsGtK();
                    }
                }
            }
            _flag = true;
        }

        public int val()
        {
            findDiffsGtK();
            int count = _Count;
            return count;
        }
    }
}
