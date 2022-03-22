using System;
using Controllers;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Views
{
    public class LyonViews
    {
        public static void InsertLyonV()
        {

            Console.WriteLine("Digite o Nome do Leão: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o Tempo de Alimentação do Leão: ");
            int timesToEat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade de Visitantes Atuais: ");
            int visitors = Convert.ToInt32(Console.ReadLine());

            LyonController.InsertLyon(name, timesToEat, visitors);
        }
        public static void UpdateLyonV()
        {
            try
            {
                Console.WriteLine("Digie o Id do Leão:");
                int id = Convert.ToInt32(Console.ReadLine());
                Lyon lyon = LyonController.FindLyon(id);

                Console.WriteLine("Digite o Nome do Leão: [Deixe vazio para manter]");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o Tempo de Alimentação do Leão: [Deixe 0 para manter]");
                int timesToEat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a Quantidade de Visitantes Atuais: ");
                int visitors = Convert.ToInt32(Console.ReadLine());
                LyonController.UpdateLyon(lyon);
            }
            catch (Exception err)
            {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }
        }
        public static void DeleteLyonV()
        {
            try
            {
                Console.WriteLine("Digite o Id do Leão: ");
                id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err)
            {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }
        }
        public static void FindLyonV()
        {
            try
            {
                Console.WriteLine("Digite o Id do Leão: ");
                int id = Convert.ToInt32(Console.ReadLine());
                LyonController.FindLyon(id);
            }
            catch (Exception err)
            {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }
        }
        public static void PrintAllLyonsV()

        {

            Console.WriteLine("Visualizar Leões");

            foreach (Lyon lyon in Controllers.LyonController.PrintAllLyons())

            {

                Console.WriteLine(lyon);

            }

        }
    }
}


