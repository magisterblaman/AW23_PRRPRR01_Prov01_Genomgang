using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_Prov01_Genomgång {
	internal class Program {
		static void PrintMessage(string message) {
			Console.WriteLine(message);
		}

		static double Multiply(double a, double b) {
			return a * b;
		}

		static string GetWaterState(int waterTemp) {
			if (waterTemp < 0) {
				return "solid";
			} else if (waterTemp >= 100) {
				return "gas";
			} else {
				return "liquid";
			}
		}

		static void Main(string[] args) {
			//int[] childAges = new int[4] {
			//	3, 4, 8, 11
			//};

			//// Uppgift 5
			//Console.WriteLine("Nu är jag riktigt taggad på att få skriva lite kod");

			//// Uppgift 6
			//int birthYear = 2004;
			//int age = 20;
			//Console.WriteLine(birthYear + age);

			//// Uppgift 7
			//string firstName;
			//string lastName;

			//firstName = Console.ReadLine();
			//lastName = Console.ReadLine();

			//Console.WriteLine("Du heter " + firstName + " " + lastName);

			//// Uppgift 8
			//Console.WriteLine("Hur lång är du?");
			//string userHeightInput = Console.ReadLine();
			//int userHeight = int.Parse(userHeightInput);
			//Console.WriteLine("Om man kapar av dina ben blir du " + (userHeight / 2) + "cm lång");

			//// Uppgift 9
			//for (int i = 1; i <= 30; i++) {
			//	Console.WriteLine(i);
			//}

			// Uppgift 10
			string[] passwords = new string[] {
				"password",
				"monkey",
				"qwerty",
				"letmein",
				"admin",
				"starwars",
			};

			for (int i = 0; i < passwords.Length; i++) {
				passwords[i] += "123";
			}

			for (int i = 0; i < passwords.Length; i++) {
				Console.WriteLine(passwords[i]);
			}

			// Uppgift 11
			PrintMessage("Snart klar!");

			// Uppgift 12
			Console.WriteLine(Multiply(70, 6));

			// Uppgift 13

		}
	}
}
