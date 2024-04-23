using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankbullshit.Conversions
{
    public class TimeConversion
    {
        /// <summary>
        /// Solution for https://www.hackerrank.com/challenges/time-conversion/problem
        /// </summary>
        public TimeConversion() { }

        public string Run()
        {

            string h12 = "07:05:45PM";
            //string h24 = "07:05:45";

            string dateTimeStr = string.Empty;
            if (h12.ToLower().Contains("m"))
            {
                var dateTime = DateTime.Parse(h12);
                dateTimeStr = dateTime.ToString("HH:mm:ss");
            }
            else
            {
                var dateTime = DateTime.Parse(h12);
                dateTimeStr = dateTime.ToString("hh:mm:sstt");
            }
            return dateTimeStr;
        }
    }
}
