using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Four
{
	class Trainer : Employee, ICab, IShuttle
	{
		public Trainer(int empId, string empName) : base(empId, empName){}

		void ICab.deRegister(string EmpName)
		{
			Console.WriteLine("Employee {0} deregistered from Cab", EmpName);
		}

		void ICab.register(string empName)
		{
			Console.WriteLine("Employee {0} registered to Cab", EmpName);
		}
		void IShuttle.deRegister(string EmpName)
		{
			Console.WriteLine("Employee {0} deregistered from Shuttle", EmpName);
		}

		void IShuttle.register(string empName)
		{
			Console.WriteLine("Employee {0} registered to Shuttle", EmpName);
		}
	}
}
