using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Two
{
	class Calculator
	{
		public static float AddTwoNumbers(float m, float n)
		{
			return m + n;
		}
		public static float SubtractTwoNumbers(float m, float n)
		{
			return m - n;
		}
		public static float MultiplyTwoNumbers(float m, float n)
		{
			return m * n;
		}
		public static float DivideTwoNumbers(float m, float n)
		{
			try
			{
				return m / n;
			}catch(DivideByZeroException ex)
			{
				return 0;
			}
		}
	}
}
