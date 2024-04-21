using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankbullshit
{
	public class StairCase
	{
		/// <summary>
		/// Solution for https://www.hackerrank.com/challenges/staircase/problem
		/// </summary>
		public StairCase() { }

		public void Run()
		{
			int num = 6;
			int numspaces = num - 1;
			string hash = string.Empty;
			string str = string.Empty;
			StringBuilder sb = new StringBuilder();
			for(int i = 0; i < num; i++)
			{
				hash += "#";
				Console.Write(str.PadLeft(numspaces, ' ') + hash + "\n");
				numspaces--;
			}
		}
	}
}
