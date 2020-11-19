using System;

namespace Day_Two
{
	class Program
	{
		static void startCalculator()
		{
			while (true)
			{
				Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Exit");
				Console.WriteLine("Choose Any Option:");
				int op = Convert.ToInt32(Console.ReadLine());
				float res = 0;
				switch (op)
				{
					case 1:
						Console.WriteLine("Input two numbers: ");
						res = Calculator.AddTwoNumbers(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
						Console.WriteLine("Result is {0}", res);
						break;
					case 2:
						Console.WriteLine("Input two numbers: ");
						res = Calculator.SubtractTwoNumbers(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
						Console.WriteLine("Result is {0}", res);
						break;
					case 3:
						Console.WriteLine("Input two numbers: ");
						res = Calculator.MultiplyTwoNumbers(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
						Console.WriteLine("Result is {0}", res);
						break;
					case 4:
						Console.WriteLine("Input two numbers: ");
						res = Calculator.DivideTwoNumbers(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
						Console.WriteLine("Result is {0}", res);
						break;
					case 5:
						return;
					default:
						Console.WriteLine("Invalid Option!");
						break;
				}
			}
		}
		static void calculateSalary()
		{
			Console.WriteLine("Input basic salary: ");
			float salary = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input salary tax: ");
			float tax=(float) Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Total Salary is {0}", Payroll.calculateTotalSalary(salary, tax));
			Console.ReadKey();
		}
		static void Main(string[] args)
		{
			//Calculator App
			//startCalculator();

			//Calculate Salary
			//calculateSalary();

			//Customer Class
			//Customer customer = new Customer(1234, "Kishan", "Agra");
			//customer.displayDetails();

			//Trainer Class
			//Trainer defaultTrainer = new Trainer();
			//Trainer obj1 = new Trainer(101, "Peter", "Dotnet");
			//Trainer obj2 = new Trainer(102, "Angie", "Java");
			//Console.WriteLine("Trainer 1:\nID: {0}\nName: {1}\nTechnology: {2}", defaultTrainer.EmpId, defaultTrainer.EmpName, defaultTrainer.Technology);
			//Console.WriteLine("Trainer 2:\nID: {0}\nName: {1}\nTechnology: {2}", obj1.EmpId, obj1.EmpName, obj1.Technology);
			//Console.WriteLine("Trainer 3:\nID: {0}\nName: {1}\nTechnology: {2}", obj2.EmpId, obj2.EmpName, obj2.Technology);

			//Static Class
			StaticDemo staticDemo1 = new StaticDemo();
			StaticDemo.displayCount();

			StaticDemo staticDemo2 = new StaticDemo();
			StaticDemo staticDemo3 = new StaticDemo();

			StaticDemo.displayCount();

			Console.ReadKey();
		}
	}
}
