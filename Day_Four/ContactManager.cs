using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Four
{
	class ContactManager
	{
		private static List<Contact> contacts=new List<Contact>();
		public static void addContact(Contact contact)
		{
			contacts.Add(contact);
		}
		public static void DisplayContact(int contactNo)
		{
			Console.WriteLine("Following Contacts were Found: ");
			foreach (Contact contact in contacts)
			{
				if (contact.ContactNo == contactNo)
				{
					Console.WriteLine("Contact No: {0}\nName: {1}\nCell No: {2}\n", contact.ContactNo, contact.ContactName, contact.CellNo);
				}
			}
		}
		public static void EditContact(int contactNo)
		{
			foreach(Contact contact in contacts)
			{
				if (contact.ContactNo == contactNo)
				{
					Console.WriteLine("Found Contact: {0}, {1}", contact.ContactName, contact.CellNo);
					Console.WriteLine("Input the New Name:");
					string name = Console.ReadLine();
					Console.WriteLine("Input the New Cell No:");
					string cellNo = Console.ReadLine();
					contact.ContactName = name;
					contact.CellNo = cellNo;
				}
			}
		}
		public static void ShowAllContacts()
		{
			foreach(Contact contact in contacts)
			{
				Console.WriteLine("("+contact.ContactNo + ", " + contact.ContactName + ", " + contact.CellNo+")");
			}
		}
		public static int getNextCount()
		{
			return contacts.Count + 1;
		}
	}
}
