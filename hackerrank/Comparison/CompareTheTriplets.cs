using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Comparison
{
    public class CompareTheTriplets
    {
        /// <summary>
        /// Solution for https://www.hackerrank.com/challenges/compare-the-triplets/problem
        /// </summary>
        public CompareTheTriplets() { }

        public List<int> Run()
        {
            List<int> a = new List<int>() { 17, 28, 30 };
            List<int> b = new List<int>() { 99, 16, 8 };
            List<int> answerArry = new();
            int aa = 0, bb = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aa++;
                }
                else if (b[i] > a[i])
                {
                    bb++;
                }
                else
                {
                    continue;
                }
            }
            answerArry.Add(aa);
            answerArry.Add(bb);
            return answerArry;

        }

    }
}
