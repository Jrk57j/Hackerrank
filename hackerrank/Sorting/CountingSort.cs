using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sorting
{
    /// <summary>
    /// Solution for https://www.hackerrank.com/challenges/countingsort1/problem
    /// </summary>
    public class CountingSort
    {
        public CountingSort() { }

        public List<int> Run()
        {
            List<int> randomArray = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                randomArray.Add(rnd.Next(i, 100));
            }

            List<int> sorted = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                sorted.Insert(i, 0);
            }
            for (int i = 0; i < randomArray.Count; i++)
            {
                sorted[randomArray[i]]++;
            }
            return sorted;
        }
    }
}
