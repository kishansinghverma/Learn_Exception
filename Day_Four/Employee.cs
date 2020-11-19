using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Four
{
	class Employee
	{
		private int empId;
		private string empName;

		public int EmpId { get => empId; set => empId = value; }
		public string EmpName { get => empName; set => empName = value; }

		public Employee(int empId, string empName)
		{
			this.empId = empId;
			this.empName = empName;
		}

		public void Display()
		{
			Console.WriteLine("Emp ID:  {0}", empId);
			Console.WriteLine("Emp Name:  {0}", empName);
		}
	}
}
