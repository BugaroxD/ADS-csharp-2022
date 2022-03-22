// Question 6 -
// Create a program that receives a number and indicate the month it represents.
using System;
					
public class L2E6
{
    public static void Main(string[] args) 
	{
		int soma = 0;
        for (int i = 1; i <= 500; i++) 
		{
            if (i % 7 == 0 && i % 2 != 0) 
			{
				soma += i;  
            }
        }
		Console.WriteLine(soma);
    }
}