using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Mathy
{
    public class MiniMaxSum
    {
        /// <summary>
        /// Solution for https://www.hackerrank.com/challenges/mini-max-sum/problem
        /// </summary>
        public MiniMaxSum() { }

        public string Run()
        {
            List<int> arr = new List<int>();
            arr.Add(256741038);
            arr.Add(623958417);
            arr.Add(467905213);
            arr.Add(714532089);
            arr.Add(938071625);
            List<long> longs = new List<long>();
            foreach (int i in arr)
            {
                longs.Add(i);
            }
            long min = longs.OrderBy(x => x).Take(4).Sum();
            long max = longs.OrderByDescending(x => x).Take(4).Sum();
            return $"{min} {max}";
        }
    }
}
