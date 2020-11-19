using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Two
{
	class Trainer
	{
		private int empId;
		public int EmpId
		{
			get { return empId; }
			set { empId = value; }
		}

		private string empName;
		public string EmpName
		{
			get { return empName; }
			set { empName = value; }
		}

		private string technology;
		public String Technology
		{
			get { return technology; }
			set { technology = value; }
		}

		public Trainer()
		{
			this.empId = 0;
			this.empName = "Employee";
			this.technology = "C#";
		}

		public Trainer(int empId, string empName, string technology)
		{
			this.empId = empId;
			this.empName = empName;
			this.technology = technology;
		}
	}
}
