using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
	internal class User
	{
		public string Login { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public readonly DateTime DateOfSurvey;
		public User(string login, string firstName, string lastName, int age)
		{
			Login = login;
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			DateOfSurvey = DateTime.Now; // Встановлюємо поточну дату та час
		}

		public void DisplayUserInfo()
		{
			Console.WriteLine($"Login: {Login}");
			Console.WriteLine($"Name: {FirstName} {LastName}");
			Console.WriteLine($"Age: {Age}");
			Console.WriteLine($"Date of Survey: {DateOfSurvey.ToShortDateString()}");
		}

	}
}
