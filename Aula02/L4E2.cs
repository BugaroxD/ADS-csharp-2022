// Question 2 -
// Create a program that print an arrays with Foreach.
using System;

public class L4E2 {
    public static void Main (string[] args)
    {
     string[] numbers = { "1", "2", "3" };

        foreach (string number in numbers) {
           Console.WriteLine(number);

        }
    }
}