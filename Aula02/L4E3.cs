// Question 3 -
// Create a program that reads 10 double values and saves to an array, then print those values.
using System;

public class L4E2 
{
    public static void Main (string[] args)
    {
      double[] a ;
        a = new double[10];
        
        a[0] = 1.0;
        a[1] = 1.1;
        a[2] = 1.2;
        a[3] = 1.3;
        a[4] = 1.4;
        a[5] = 1.5;
        a[6] = 1.6;
        a[7] = 1.7;
        a[8] = 1.8;
        a[9] = 1.9;

        Console.WriteLine("First: " + a [0]);
        Console.WriteLine("Second: " + a [1]);
        Console.WriteLine("Third: " + a [2]);
        Console.WriteLine("Fourth: " + a [3]);
        Console.WriteLine("Fifth: " + a [4]);
        Console.WriteLine("Sixth: " + a [5]);
        Console.WriteLine("Seventh: " + a [6]);
        Console.WriteLine("Eighth: " + a [7]);
        Console.WriteLine("Ninth: " + a [8]);
        Console.WriteLine("Tenth: " + a [9]);
    }
}
