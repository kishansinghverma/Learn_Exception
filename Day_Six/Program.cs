using System;
using System.Threading;

namespace Day_Six
{
	class Program
	{
		static void Main(string[] args)
		{
			ThreadStart threadStart1 = new ThreadStart(TestThreads.AddNumbers);
			Thread thread1 = new Thread(threadStart1);

			ThreadStart threadStart2 = new ThreadStart(TestThreads.ReadNumbers);
			Thread thread2 = new Thread(threadStart2);

			thread1.Start();
			thread2.Start();

			Thread.Sleep(4000);
			Console.ReadKey();

			//Analysis: The list is mutating while its being read.
			//This produces InvalidOperationException.
			//This happens due the race condition in adding and reading numbers at same time
			//We need to synchronise the same for expected output.
		}
	}
}
