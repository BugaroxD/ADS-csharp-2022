using System;
public class Bhaskar 
{
  public static void Main(String[] args) 
  {
    int a = 1;
    int b = -1;
    int c = -6;

    int delta = (b * b) - (4 * a * c);
    if (dekta <= 0 ){
      Console.WriteLine("O valor de delta é negativo.")
    }
    double x = (-b + Math.Sqrt(delta)) / (2 * a);
    double xL = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine(x);
    Console.WriteLine(xL);
    Console.WriteLine(delta);
  }
}