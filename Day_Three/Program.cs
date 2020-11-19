using System;

namespace Day_Three
{
	class Program
	{
		static void Main(string[] args)
		{
			//Regular Class
			//RegularCustomer customer = new RegularCustomer(101, "Kishan", "Cash");
			//Console.WriteLine("EmpID: {0}\nCustomer Name: {1}\nPayment: {2}", customer.CustId, customer.CustName, customer.Payment);

			//Participant Class
			Participant participant = new Participant(101, "Kishan", 100, 20, 10);
			participant.ComputeSalary();
			Console.ReadKey();
		}
	}
}
