// Question 6 -
// Create a program that lists a two integers.

using System;
using System.Collections.Generic;

public class L4E6s
 {
    public static void Main(string[] args)
     {

        List<string> a = new List<string>() { "9", "8", "7", "6", "5" };
        List<string> b = new List<string>() { "4", "3", "2", "1", "0" };
        a.AddRange(b);

        Console.Write("a e b unidos dão: ");
        Console.WriteLine(String.Join(",", a));
    }
}