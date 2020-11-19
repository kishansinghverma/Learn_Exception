using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Two
{
	class Payroll
	{
		public static float calculateTotalSalary(float salary, float tax)
		{
			return salary - (salary * tax / 100);
		}
	}
}
