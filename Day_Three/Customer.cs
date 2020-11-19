using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
	class Customer
	{
		private int custId;
		public int CustId
		{
			get { return custId; }
			set { custId = value; }
		}
		private string custName;
		public string CustName
		{
			get { return custName; }
			set { custName = value; }
		}

		public Customer(int custId, string custName)
		{
			this.custId = custId;
			this.custName = custName;
		}
	}
}
