using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Two
{
	class StaticDemo
	{
		static int count;
		static StaticDemo()
		{
			count = 0;
		}
		public StaticDemo()
		{
			count++;
		}
		public static void displayCount()
		{
			Console.WriteLine("{0} Objects Created So Far!", count);
		}
	}
}
