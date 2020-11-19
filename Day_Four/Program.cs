using System;

namespace Day_Four
{
	class Program
	{
		static void Main(string[] args)
		{
			//Interface Demo
			//Trainer trainer = new Trainer(101, "Kishan");
			//trainer.Display();
			//IShuttle shuttle = trainer;
			//shuttle.register(trainer.EmpName);

			//ContactManager
			while (true)
			{
				Console.WriteLine("\n1. Add\n2. Display\n3. Modify\n4. DisplayAll\n5. Exit");
				Console.Write("Choose any option: ");
				int option = Convert.ToInt32(Console.ReadLine());
				switch (option)
				{
					case 1:
						Console.WriteLine("Input Contact Name:");
						string name = Console.ReadLine();
						Console.WriteLine("Input Cell No:");
						string cellNo = Console.ReadLine();
						Contact contact = new Contact(ContactManager.getNextCount(), name, cellNo);
						ContactManager.addContact(contact);
						break;

					case 2:
						Console.WriteLine("Input Contact No:");
						int num = Convert.ToInt32(Console.ReadLine());
						ContactManager.DisplayContact(num);
						break;
					case 3:
						Console.WriteLine("Input Contact No:");
						int n = Convert.ToInt32(Console.ReadLine());
						ContactManager.EditContact(n);
						break;
					case 4:
						ContactManager.ShowAllContacts();
						break;
					case 5:
						return;
					default:
						Console.WriteLine("Invalid Choice!\n");
						break;
				}
			}
		}
	}
}
