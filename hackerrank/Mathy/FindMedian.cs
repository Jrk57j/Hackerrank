using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankbullshit.Mathy
{
    public class FindMedian
    {
        /// <summary>
        /// Solution for https://www.hackerrank.com/challenges/find-the-median/problem
        /// </summary>
        public FindMedian() { }

        public int Run()
        {
            List<int> arr = new List<int> { 0, 0, 1, 2, 1 };

            List<int> sorted = new List<int>();
            arr.Sort();
            sorted.AddRange(arr);
            var value = sorted.Count / 2 - 1;
            var median = sorted[value + 1];
            return median;
        }
    }
}
