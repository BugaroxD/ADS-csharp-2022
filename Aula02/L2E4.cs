// Question 4 - 
// Create a program that print the tablet from 0 to 10.
using System;

namespace Table
{
	class L2E4
	{

		public static void Main(string[] args)
		{
			table(10);
			Console.ReadKey(true);
		}
		
		public static void table(int numero)
		{
			for (int x = 1; x <= 10; x++)
			{
				Console.WriteLine(numero + " * " + x + " = " + numero * x);
			}
		}
	}
}