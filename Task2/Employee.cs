using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Employee
	{
		public string FirstName { get; set; }
		public string LastName { get;  set; }
		public string Position { get; set; }
		public int Experience { get; set; }


		public Employee(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}
		public void CalculateSalaryAndTax(out double salary, out double tax)
		{
			double baseSalary = 10000;
			double experienceMultiplier = 1 + 0.05 * Experience; 
			double positionMultiplier = Position.ToLower() switch
			{
				"manager" => 1.5,
				"developer" => 1.2,
				"designer" => 1.1,
				
			};

			salary = baseSalary * experienceMultiplier * positionMultiplier;
			tax = salary * 0.2; 
		}

		public void DisplayEmployeeInfo()
		{
			CalculateSalaryAndTax(out double salary, out double tax);

			Console.WriteLine($"Співробітник: {FirstName} {LastName}");
			Console.WriteLine($"Посада: {Position}");
			Console.WriteLine($"Оклад: {salary:C2}");
			Console.WriteLine($"Податковий збір: {tax:C2}");
		}
	}

}

