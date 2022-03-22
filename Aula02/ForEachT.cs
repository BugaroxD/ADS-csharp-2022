using System;
public class ForEachT 
{
    public static void Main(string[] parametros) 
    {
        int valor = 10;
        string[] array = new string[valor];

        array[0] = "J";
        array[1] = "E";
        array[2] = "F";
        array[3] = "F";
        array[4] = "E";
        array[5] = "R";
        array[6] = "S";
        array[7] = "O";
        array[8] = "N";
        array[9] = "L";

       
        Console.WriteLine("Foreach String");
        foreach (string posicao in array3)
        {
            Console.WriteLine(posicao);
        }
    }
}
    
