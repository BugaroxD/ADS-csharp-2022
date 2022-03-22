// Question 2 -
// Create a program that receives a number and indicate the month it represents.
using System;
					
public class L2E2
{
	public static void Main()
	{
		int mes;

    Console.WriteLine("Digite o mês");

    mes = Convert.ToInt32(Console.ReadLine());

    switch (mes) {

      case 1:
        Console.WriteLine("Jan");
        break;

      case 2:
        Console.WriteLine("Fev");
        break;

      case 3:
        Console.WriteLine("Mar");
        break;

      case 4:
        Console.WriteLine("Abr");
        break;

      case 5:
        Console.WriteLine("Mai");
        break;

      case 6:
        Console.WriteLine("Jun");
        break;

      case 7:
        Console.WriteLine("Jul");
        break;

      case 8:
        Console.WriteLine("Ago");
        break;

      case 9:
       Console.WriteLine("Set");
        break;

      case 10:
        Console.WriteLine("Out");
        break;

      case 11:
        Console.WriteLine("Nov");
        break;

      case 12:
        Console.WriteLine("Dez");
        break;

    }
  }
}