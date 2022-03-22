using System;
using System.Collections.Generic;

namespace Zoologico
{
    class Program
    {
        static void MainOld(string[] args)
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
                            Console.WriteLine($"Leão criado: \n{Lyon.InsertLyon()}");
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
                            Console.WriteLine($"Leão alterado: \n{Lyon.UpdateLyon()}");
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
                            Lyon.FindLyon();
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
                            Console.WriteLine($"Leão excluído: \n{Lyon.DeleteLyon()}");
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
                            Lyon.PrintAllLyons();
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

    class Animal
    {
        protected int Id { set; get; }
        protected string Name { set; get; }

        public Animal(
            int Id,
            string Name
        ) {
            this.Id = Id;
            this.Name = Name;
        }
    }

    class Lyon : Animal
    {
        public static List<Lyon> Lyons = new List<Lyon>();
        public static int IdCount = 0;
        public int TimesToEat { set; get; }
        public int Visitors { set; get; }

        public Lyon(
            string Name,
            int TimesToEat,
            int Visitors
        ): this(++IdCount, Name, TimesToEat, Visitors)
        {
        }

        private Lyon(
            int Id,
            string Name,
            int TimesToEat,
            int Visitors
        ) : base(Id, Name) 
        {
            this.TimesToEat = TimesToEat;
            this.Visitors = Visitors;

            Lyons.Add(this);
        }

        public override string ToString() 
        {
            return $"Id: {base.Id}\n"
                + $"Nome: {base.Name}\n"
                + $"Horas de Alimentação: {this.TimesToEat}\n"
                + $"Visitantes: {this.Visitors}\n";
        }

        public static Lyon InsertLyon() {
            string name = "";
            int timesToEat = 0;
            int visitors = 0;
            try
            {
                Console.WriteLine("Digite o Nome do Leão: ");
                name = Console.ReadLine();
                Console.WriteLine("Digite o Tempo de Alimentação do Leão: ");
                timesToEat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a Quantidade de Visitantes Atuais: ");
                visitors = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception err) 
            {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }

            try
            {
                return new Lyon(name, timesToEat, visitors);
            } catch (Exception err) {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }

        }

        
        public static Lyon UpdateLyon() {
            int id = 0;
            string name = "";
            int timesToEat = 0;
            int visitors = 0;
            Lyon lyon;
            try
            {
                Console.WriteLine("Digite o Id do Leão: ");
                id = Convert.ToInt32(Console.ReadLine());
            } catch (Exception err) {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }

            
            lyon = Lyons.Find(lyon => lyon.Id == id);
            
            if (lyon == null) {
                throw new Exception($"Leão não encontrado.");
            }

            try
            {
                Console.WriteLine("Digite o Nome do Leão: [Deixe vazio para manter]");
                name = Console.ReadLine();
                Console.WriteLine("Digite o Tempo de Alimentação do Leão: [Deixe 0 para manter]");
                timesToEat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a Quantidade de Visitantes Atuais: ");
                visitors = Convert.ToInt32(Console.ReadLine());
            } catch (Exception err) {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }
            
            if (!String.IsNullOrEmpty(name)) {
                lyon.Name = name;
            }
            
            if (timesToEat > 0) {
                lyon.TimesToEat = timesToEat;
            }
            lyon.Visitors = visitors;
            return lyon;
        }

        
        public static Lyon DeleteLyon()
        {
            int id = 0;
            Lyon lyon;
            try
            {
                Console.WriteLine("Digite o Id do Leão: ");
                id = Convert.ToInt32(Console.ReadLine());
            } catch (Exception err) {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }

            lyon = Lyons.Find(lyon => lyon.Id == id);
                
            if (lyon == null) {
                throw new Exception($"Leão não encontrado.");
            }

            Lyons.Remove(lyon);

            return lyon;
        }

        
        public static void FindLyon() {
            int id = 0;
            try
            {
                Console.WriteLine("Digite o Id do Leão: ");
                id = Convert.ToInt32(Console.ReadLine());
            } catch (Exception err) {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }

            Lyon lyon = Lyons.Find(lyon => lyon.Id == id);
            
            if (lyon == null) {
                throw new Exception($"Leão não encontrado.");
            }

            Console.WriteLine(lyon);
        }

        public static void PrintAllLyons() {
            Lyons.ForEach(lyon => {
                Console.WriteLine(lyon);
            });
        }
    }
}
