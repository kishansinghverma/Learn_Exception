using System;

namespace Polymorphism
{
	class Program
	{
		public void add(int a, int b)
		{
			Console.WriteLine(a + b);
		}
		public void add(int a, int b, int c)
		{
			Console.WriteLine(a + b+c);
		}
		public void add(int a, double b)
		{
			Console.WriteLine(a + b);
		}
		public double add(double a, int b)
		{
			return a + b;
		}

		static void Main(string[] args)
		{
			new Program().add(5, 6);
			new Program().add(6, 7, 8);
			Console.ReadLine();
		}
	}
}
