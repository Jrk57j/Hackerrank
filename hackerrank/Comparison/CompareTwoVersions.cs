using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankbullshit.Comparison
{
    public class CompareTwoVersions
    {
        /// <summary>
        /// Solution for https://www.geeksforgeeks.org/compare-two-version-numbers/
        /// </summary>
        public CompareTwoVersions() { }

        public int Run()
        {
            string version1 = "2.1.0";
            string version2 = "2.0.1";
            // vnum stores each numeric 
            // part of version 
            int vnum1 = 0, vnum2 = 0;

            // loop until both string are 
            // processed 

            for (int i = 0; i < version1.Length; i++)
            {
                vnum1 *= 10 + (version1[i] - '0');
            }

            for (int i = 0; i < version2.Length; i++)
            {
                vnum2 *= 10 + (version2[i] - '0');
            }

            if (vnum1 > vnum2)
                return 1;
            if (vnum2 > vnum1)
                return -1;
            if (vnum1 == vnum2)
            {
                return 0;
            }
            return 0;
        }
    }
}
