using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Matrix
{
    public class FlippingTheMatrix
    {
        //Soltuion for https://www.hackerrank.com/challenges/flipping-the-matrix/problem
        public FlippingTheMatrix() { }

        public int Run()
        {
            List<List<int>> matrix = new List<List<int>>();
            List<int> l1 = new List<int> { 1, 2 };
            List<int> l2 = new List<int> { 3, 4 };
            matrix.Add(l1);
            matrix.Add(l2);

            var countMinusOne = matrix.Count - 1;
            int result = 0;
            for (int i = 0; i < matrix.Count / 2; i++)
            {
                for (int j = 0; j < matrix.Count / 2; j++)
                {
                    var list = new List<int> { matrix.ElementAt(i).ElementAt(j),
                    matrix.ElementAt(i).ElementAt(countMinusOne - j),
                    matrix.ElementAt(countMinusOne - i).ElementAt(j),
                    matrix.ElementAt(countMinusOne - i).ElementAt(countMinusOne -j) };
                    result += list.Max();
                }
            }
            return result;
        }
    }
}
