using System;

namespace Day_One
{
	class Program
	{
		static void printSequence()
		{
			for (int i = 1; i <= 5; i++) {
				for (int j = 1; j <= i; j++) {
					Console.Write(i + " ");
				}
				Console.WriteLine();
			}
		}
		static void checkPalindrome(int num)
		{
			String sNum = Convert.ToString(num);
			char[] numArr = sNum.ToCharArray();
			Array.Reverse(numArr);
			if (sNum.Equals(new string(numArr)))
				Console.WriteLine("Number Is a Palindrome!");
			else
				Console.WriteLine("Not a Palindrome!");
		}
		static void evenOddSum()
		{
			long evenSum = 0;
			long oddSum = 0;
			for(int i=0; i<10; i++)
			{
				Console.Write("Input No {0}: ", (i + 1));
				long num=Convert.ToInt64(Console.ReadLine());
				if (num % 2 == 0)
					evenSum += num;
				else
					oddSum += num;
			}
			Console.WriteLine("Sum of Evens: {0} \nSum of Odds: {1}", evenSum, oddSum);
		}

		static void matrixMultiplication()
		{
			int i, j, m, n;
			Console.WriteLine("Enter the Size : ");
			m = Convert.ToInt32(Console.ReadLine());
			int[,] a = new int[m, m];
			Console.WriteLine("Enter the First Matrix");
			for (i = 0; i < m; i++)
			{
				for (j = 0; j < m; j++)
				{
					a[i, j] = int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("First matrix is:");
			for (i = 0; i < m; i++)
			{
				for (j = 0; j < m; j++)
				{
					Console.Write(a[i, j] + "\t");
				}
				Console.WriteLine();
			}
			int[,] b = new int[m, m];
			Console.WriteLine("Enter the Second Matrix");
			for (i = 0; i < m; i++)
			{
				for (j = 0; j < m; j++)
				{
					b[i, j] = int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("Second Matrix is :");
			for (i = 0; i < m; i++)
			{
				for (j = 0; j < m; j++)
				{
					Console.Write(b[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine("Matrix Multiplication is :");
			int[,] c = new int[m, m];
			for (i = 0; i < m; i++)
			{
				for (j = 0; j < m; j++)
				{
					c[i, j] = 0;
					for (int k = 0; k < m; k++)
					{
						c[i, j] += a[i, k] * b[k, j];
					}
				}
			}
			for (i = 0; i < m; i++)
			{
				for (j = 0; j < m; j++)
				{
					Console.Write(c[i, j] + "\t");
				}
				Console.WriteLine();
			}

			Console.ReadKey();
	}
		static void Main(string[] args)
		{
			/* Q1. Identify 2 assemblies in the GAC which have same name but differ in version
			 Ans. Microsoft.DirectX.Direct3DX.1.0.2901 & Microsoft.DirectX.Direct3DX.1.0.2911*/

			//Print the given sequence.
			printSequence();

			//Check for Palindrome.
			checkPalindrome(1234321);
			checkPalindrome(124321);

			//EvenOddSum
			evenOddSum();

			//Matrix Muliplication
			matrixMultiplication();

			Console.ReadLine();

		}
	}
}
