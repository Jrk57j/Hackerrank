using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Mathy
{
    public class PlusMinus
    {
        /// <summary>
        /// Solution for https://www.hackerrank.com/challenges/plus-minus/problem
        /// </summary>
        public PlusMinus() { }

        public string Run()
        {
            List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };

            double pos_cnt = 0;
            double neg_cnt = 0;
            double zeo_cnt = 0;
            int arr_cnt = 0;
            arr_cnt = arr.Count();
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    pos_cnt++;
                }
                else if (item < 0)
                {
                    neg_cnt++;
                }
                else
                {
                    zeo_cnt++;
                }
            }
            var pos = (double)(pos_cnt / arr_cnt);
            var neg = neg_cnt / arr_cnt;
            var zeo = zeo_cnt / arr_cnt;
            return $" {string.Format("{0:0.####}", pos)} \n {string.Format("{0:0.####}", neg)} \n {string.Format("{0:0.####}", zeo)} ";
        }
    }
}
