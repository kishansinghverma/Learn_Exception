using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
	abstract class Employee
	{
		private int EmpId;
		public int empId
		{
			get { return EmpId; }
		}
		private string EmpName;
		public string empName
		{
			get { return EmpName; }
		}

		public Employee(int empId, string empName)
		{
			EmpId = empId;
			EmpName = empName;
		}

		public abstract void ComputeSalary();
	}
}
