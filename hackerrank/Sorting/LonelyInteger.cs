using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankbullshit.Sorting
{
    public class LonelyInteger
    {
        /// <summary>
        /// Solution for https://www.hackerrank.com/challenges/lonely-integer/problem
        /// </summary>
        public LonelyInteger() { }

        public int Run()
        {
            List<int> arr = new List<int> { 0, 0, 1, 2, 1 };

            Dictionary<int, int> kvp = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count; i++)
            {
                int cnt = 1;
                if (kvp.ContainsKey(arr[i]))
                {
                    kvp[arr[i]]++;
                }
                else
                {
                    kvp.Add(arr[i], cnt);
                }
            }
            int unique = 0;
            foreach (var item in kvp)
            {
                if (item.Value == 1)
                {
                    unique = item.Key;
                }
            }
            return unique;
        }
    }
}
