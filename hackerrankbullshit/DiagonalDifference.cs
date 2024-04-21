using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankbullshit
{
	public class DiagonalDifference
	{
		/// <summary>
		/// Solution for https://www.hackerrank.com/challenges/diagonal-difference/problem
		/// This literally only works in their IDE. I know why, the first array needs to have 0's populated for it to work.
		/// </summary>
		public DiagonalDifference() { }

		public int Run()
		{
			List<List<int>> arr = new List<List<int>>();
			List<int> list = new List<int>{ 3 };
			arr.Add(list);

			List<int> list2 = new List<int>{ 11, 2, 4 };
			arr.Add(list2);

			List<int> list3 = new List<int>{ 4, 5, 6 };
			arr.Add(list3);

			List<int> list4 = new List<int>{ 10, 8, -12};
			arr.Add(list4);

			int r = 0;
			int l = 0;

			for(int i = 0; i < arr.Count; i++)
			{
				r += arr[i][i];
				l += arr[i][arr.Count - 1 - i];
			}

			int sum = Math.Abs(r - l);

			return sum;

		}
	}
}
