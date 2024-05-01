using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Mathy
{
    public class BirthdayCakeCandles
    {
        public BirthdayCakeCandles() { }

        public int Run()
        {
            List<int> candles = new List<int>() { 4, 4, 1, 3, 6, 6 };

            var max = candles.Max();
            int cnt = 0;
            foreach (var item in candles)
            {
                if (item == max)
                {
                    cnt++;
                }
            }
            return cnt;
            ;
        }
    }
}
