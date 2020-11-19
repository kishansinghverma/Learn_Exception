using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
	class Participant : Employee
	{
		private float basic_salary;
		private float HRA;
		private float TA;

		public Participant(int empId, string empName, float basic_salary, float HRA, float TA):base(empId, empName)
		{
			this.basic_salary = basic_salary;
			this.HRA = HRA;
			this.TA = TA;
		}
		public override void ComputeSalary()
		{
			Console.WriteLine("Employee ID: {0}", empId);
			Console.WriteLine("Employee Name: {0}", empName);
			Console.WriteLine("Basic Salary: {0}", this.basic_salary);
			Console.WriteLine("HRA: {0}", this.HRA);
			Console.WriteLine("TA: {0}", this.TA);
			Console.WriteLine("Total Salary: {0}", (basic_salary+HRA+TA));
		}
	}
}
