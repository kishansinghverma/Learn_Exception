using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
	class RegularCustomer: Customer
	{
		private string payment;
		public string Payment
		{
			get { return payment; }
			set { payment = value; }
		}

		public RegularCustomer(int custId, string custName, string payment):base(custId, custName)
		{
			this.payment = payment;
		}
	}
}
