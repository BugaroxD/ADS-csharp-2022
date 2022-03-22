// Question 3 - 
// Create a program that receives two numeric values as input from the Main class and calculate the basic operations with them.

using System;

class L3E3
{
    public static void Main()
    {
        Console.WriteLine("Exercise 03");
        int num1 = 2;
        int num2 = 3;
            
        int soma = num1 + num2;
        int multi = num1 * num2;
        int div = num1 / num2;
        int sub = num1 - num2;
        Console.WriteLine("Soma de num1 + num2: " + soma);
        Console.WriteLine("Multiplicação de num1 + num2: " + multi);
        Console.WriteLine("Divisão de num1 + num2: " + div);
        Console.WriteLine("Subtração de num1 + num2: " + sub);
    }
}