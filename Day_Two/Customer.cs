using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Two
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
		private string custCity;
		public string CustCity
		{
			get { return custCity; }
			set { custCity = value; }
		}

		public Customer(int custId, string custName, string custCity)
		{
			this.custId = custId;
			this.custName = custName;
			this.custCity = custCity;
		}

		public void displayDetails()
		{
			Console.WriteLine("Customer ID: {0}", custId);
			Console.WriteLine("Customer Name: {0}", custName);
			Console.WriteLine("Customer City: {0}", custCity);
		}

	}
}
