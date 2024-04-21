using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankbullshit
{
	/// <summary>
	/// Solution for https://www.hackerrank.com/challenges/day-of-the-programmer/problem
	/// </summary>
	public class DayOfTheProgrammer
	{
		public DayOfTheProgrammer(){}

		public string Run()
		{
			int year = 2016;
			int dotp = 256;

			int feb;
			if(year == 1918)
			{
				feb = 15;
			}
			else if(year >= 1700 && year < 1918)
			{
				feb = year % 4 == 0 ? 29 : 28;
			}
			else
			{
				if(year % 400 == 0 || ( year % 4 == 0 && year % 100 != 0 ))
				{
					feb = 29;
				}
				else
				{
					feb = 28;
				}

			}

			/*
			 * I'm not a genius or anything but when this fails. I think the hr questions fails. who knows, I should check the docs
			 * bool leap = DateTime.IsLeapYear(year);
			 * feb = leap == true ? 29 : 28;
			 */

			int daysInTheYear = 5 * 31 + 60 + feb;
			int day = dotp - daysInTheYear;
			string date = $"{day}.09.{year}";
			return date;
        }
	}
}
