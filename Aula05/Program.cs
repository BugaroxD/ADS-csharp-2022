using System;
using Models;
using Views;
using Controllers;

namespace Zoo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Zoológico Selva Mágica!");
            int opt = 0;
            do
            {
                Console.WriteLine(
                    "Digite a operação que deseja realizar: \n"
                    + "[1] Cadastrar Leão\n"
                    + "[2] Alterar Leão\n"
                    + "[3] Visualizar Leão\n"
                    + "[4] Excluir Leão\n"
                    + "[5] Visualizar Leões\n"
                    + "[0] Sair\n"
                );
                try
                {
                    opt = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    opt = 99;
                }

                switch (opt)
                {
                    case 0:
                        Console.WriteLine("Obrigado por utilizar nosso sistema!");
                        break;
                    case 1:
                        try
                        {
                            Console.WriteLine("Criar leão: ");
                            Console.WriteLine($"Leão criado: \n");
                            LyonViews.InsertLyonV();
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Alterar leão: ");
                            Console.WriteLine($"Leão alterado: \n");
                            LyonViews.UpdateLyonV();
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Visualizar leão: ");
                            LyonViews.FindLyonV();
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Excluir leão: ");
                            Console.WriteLine($"Leão excluído: \n");
                            LyonViews.DeleteLyonV();
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err.Message);
                        }
                        break;
                    case 5:
                        try
                        {

                            Console.WriteLine("Visualizar Leões: ");
                            LyonViews.PrintAllLyonsV();
                        }
                        catch (Exception err)
                        {
                            Console.WriteLine(err.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Operação inválida tente novamente");
                        break;
                }
            } while (opt != 0);
        }
    }
}

