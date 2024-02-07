using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	internal class Program
	{
		private static void Main()
		{
			Dictionary<int, string> employees = new Dictionary<int, string>
			{
				[1] = "Tim",
				[2] = "Sue",
				[3] = "Bob"
			};

			Console.Write("Enter your Employee ID: ");
			string employeeidtext = Console.ReadLine();
			bool isidvalid = int.TryParse(employeeidtext, out int employeeid);
			if ( isidvalid && employeeid > 0 && employeeid < 4 )
			{
				Console.WriteLine($"Welcome {employees[employeeid]}!");
			}
			else
			{
				Console.WriteLine("That is not a valid ID.");
			}

			_ = Console.ReadLine();
		}
	}
}
