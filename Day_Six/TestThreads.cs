using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Day_Six
{
	class TestThreads
	{
		static List<int> numbers = new List<int>();

		public static void AddNumbers()
		{
			for(int i=1; i<=5; i++)
			{
				numbers.Add(i);
				Thread.Sleep(500);
			}
		}

		public static void ReadNumbers()
		{
			foreach(int x in numbers)
			{
				Console.WriteLine(x);
				Thread.Sleep(500);
			}
		}
	}
}
