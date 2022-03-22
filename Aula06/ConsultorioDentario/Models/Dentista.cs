using System;
using System.Collections.Generic;

namespace Models
{
    public class Dentista : Pessoa
    {

        public static int ID = 0;
        private static List<Dentista> Dentistas = new List<Dentista>();
        public string Registro { set; get; }
        public double Salario { set; get; }
        public string Especialidade { set; get; }

        public override string ToString()
        {
            return base.ToString()
                + $"\n Registro (CRO)? {this.Registro}"
                + $"\n Salario: R$ {thisSalario}"
                + $"\n Especialidade: {this.Especialidade}";
        }

        public Dentista(
            int Id,
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Registro,
            double Salario,
            string Especialidade,
            string Senha
        ) : this(++ID, Nome, Cpf, Fone, Email, Registro, Salario, Especialidade, Senha)
        {
        }
        private Dentista(
            int Id,
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Registro,
            double Salario,
            string Especialidade,
            string Senha
        ) : base(Id, Nome, Cpf, Fone, Email, Senha)
        {
            this.Registro = Registro;
            this.Salario = Salario;
            this.Especialidade = Especialidade;
            this.Senha = Senha;

            Dentistas.Add(this);
        }

        public static List<Dentista> GetDentistas()
        {
            return Dentistas;
        }
        public static void RemoverDentista(Dentista dentista)
        {
            Dentistas.Remove(dentista);
        }
    }
}
