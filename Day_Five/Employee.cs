using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Day_Five
{
	[DataContract]
	public class Employee
	{
		[DataMember]
		public int EmployeeId { get; set; }
		[DataMember]
		public string EmployeeName { get; set; }
		[DataMember]
		public Address EmployeeAddress { get; set; }
	}
}
