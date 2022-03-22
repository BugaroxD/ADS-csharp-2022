using System;
using System.Collections.Generic;

namespace ZooNameSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int option;
            int id;
            string nome;

            do
            {
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1. Create Leão");
                Console.WriteLine("2. List Leão");
                Console.WriteLine("3. Update Leão");
                Console.WriteLine("4. Delete Leão");
                Console.WriteLine("0. Sair");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Para criar, digite o id desejado e o nome.");
                        id = Convert.ToInt32(Console.ReadLine());
                        nome = Console.ReadLine();
                        Leao.addLeao(id, nome);
                        break;
                        
                    case 2:
                        Leao.listLeao();
                        break;

                    case 3:
                        Console.WriteLine("Para criar, digite o id desejado e o nome.");
                        id = Convert.ToInt32(Console.ReadLine());
                        nome = Console.ReadLine();
                        Leao.updateLeao(id, nome);

                    case 4:
                        Console.WriteLine("Para deletar, digite o id desejado.");
                        id = Convert.ToInt32(Console.ReadLine());
                        Leao.deleteLeao(id);

                    case 5:
                        break;
                }
            }
            while (option != 0);
        }
    }

    public class Animal
    {
        public int id { get; set; }
        public string nome { get; set; }
        public override string ToString()
        { return "ID: " + id + " Nome: " + nome; }
        public Animal(int id, string nome) { }
    }

    public class Leao : Animal
    {
        public static List<Leao> leoes = new List<Leao>();

        public Leao(int id, string nome) : base(id, nome)
        { }

        public override string ToString()
        {
            return "ID: " + id + " Nome: " + nome;
        }
        public static void addLeao(int id, string nome)
        {
            leoes.Add(new Leao(id, nome) { id = id, nome = nome });
        }
        public static void listLeao()
        {
            foreach (Leao aLeao in leoes)
            {
                Console.WriteLine(aLeao);
            }
        }
        public static void updateLeao(int id, string nome)
        {
            leoes.RemoveAt(id);

            leoes.Insert(2, new Leao(id, nome)
            {
                id = id,
                nome = nome
            });
        }
        public static void deleteLeao(int id)
        {
            leoes.RemoveAt(id);
        }
    }
}
