using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Four
{
	class Contact
	{
		public int ContactNo { get; set; }
		public string ContactName { get; set; }
		public string CellNo { get; set; }

		public Contact(int contactNo, string contactName, string cellNo)
		{
			ContactNo = contactNo;
			ContactName = contactName;
			CellNo = cellNo;
		}
	}
}
