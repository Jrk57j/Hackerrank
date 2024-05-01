using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Mathy
{
    public class AVeryBigSum
    {
        /// <summary>
        /// Soltuion for https://www.hackerrank.com/challenges/a-very-big-sum/problem
        /// </summary>
        public AVeryBigSum() { }

        public long Run()
        {
            long longSum = 0;
            List<long> longs = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            foreach (long l in longs)
            {
                longSum += l;
            }
            return longSum;
        }

    }
}
