using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Day_Five
{
	[DataContract]
	public class Address
	{
		[DataMember]
		public int DoorNum { get; set; }
		[DataMember]
		public string City { get; set; }
		[DataMember]
		public string state { get; set; }
		[DataMember]
		public string pinCode { get; set; }
	}
}
