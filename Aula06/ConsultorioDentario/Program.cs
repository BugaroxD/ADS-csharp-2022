using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsultorioDentario
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("[============Bem Vindo============]");
            Console.WriteLine("1  | Incluir Dentista        |");
            Console.WriteLine("2  | Incluir Paciente        |");
            Console.WriteLine("3  | Incluir Sala            |");
            Console.WriteLine("4  | Incluir Agendamento     |");
            Console.WriteLine("5  | Alterar Dentista        |");
            Console.WriteLine("6  | Alterar Paciente        |");
            Console.WriteLine("7  | Alterar Sala            |");
            Console.WriteLine("8  | Alterar Agendamento     |");
            Console.WriteLine("9  | Excluir Dentista        |");
            Console.WriteLine("10 | Excluir Paciente        |");
            Console.WriteLine("11 | Excluir Sala            |");
            Console.WriteLine("12 | Excluir Agendamento     |");
            Console.WriteLine("13 | Visualizar Dentista     |");
            Console.WriteLine("14 | Visualizar Paciente     |");
            Console.WriteLine("15 | Visualizar Sala         |");
            Console.WriteLine("16 | Visualizar Agendamento  |");

            int opt = 0;

            do{ 
                try
                    {
                         opt = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        opt = 99;
                    }
                    
                switch (opt)
                {
                    case 0:
                    {
                        break;
                    }
                    case 1:
                    {
                        break;
                    }
                    case 2:
                    {
                        break;
                    }
                    case 3:
                    {
                        break;
                    }
                    case 4:
                    {
                        break;
                    }
                    case 5:
                    {
                        break;
                    }
                    case 6:
                    {
                        break;
                    }
                    case 7:
                    {
                        break;
                    }
                    case 8:
                    {
                        break;
                    }
                    case 9:
                    {
                        break;
                    }
                    case 10:
                    {
                        break;
                    }
                    case 11:
                    {
                        break;
                    }
                    case 12:
                    {
                        break;
                    }
                    case 13:
                    {
                        break;
                    }
                    case 14:
                    {
                        break;
                    }
                    case 15:
                    {
                        break;
                    }
                    case 16:
                    {
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Operação Inválida");
                        break;
                    }
                }
            }
        }
    }
}
