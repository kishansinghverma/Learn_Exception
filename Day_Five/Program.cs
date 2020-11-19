using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace Day_Five
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee();
			employee.EmployeeName = "Kishan";
			employee.EmployeeId = 101;
			Address address = new Address();
			address.DoorNum = 122;
			address.City = "Agra";
			address.pinCode = "282002";
			address.state = "Uttar Pradesh";
			employee.EmployeeAddress = address;

			//Serialize into JSON File
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Employee));
			using (FileStream fileStream = new FileStream("JsonFile.txt", FileMode.OpenOrCreate, FileAccess.Write))
			{
				serializer.WriteObject(fileStream, employee);
			}

			//Serialize into XML File
			XmlSerializer xMLSerializer = new XmlSerializer(typeof(Employee));
			using(FileStream fileStream=new FileStream("XMLFile.xml", FileMode.OpenOrCreate, FileAccess.Write))
			{
				xMLSerializer.Serialize(fileStream, employee);
			}
			Console.WriteLine("Done");
			Console.ReadKey();
		}
	}
}
