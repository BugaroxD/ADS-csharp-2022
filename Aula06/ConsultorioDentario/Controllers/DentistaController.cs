using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Models;

namespace Controllers
{
    public class DentistaController
    {
        public static Dentista IncluirDentista(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Registro,
            double Salario,
            string Especialidade
        )
        {
            if (String.IsNullOrEmpty(Nome))
            {
                throw new Exception("Nome inválido");
            }
            if (String.IsNullOrEmpty(Cpf))
            {
                throw new Exception("Cpf inválido");
            }
            if (String.IsNullOrEmpty(Fone))
            {
                throw new Exception("Telefone inválido");
            }
            if (String.IsNullOrEmpty(Email))
            {
                throw new Exception("Email inválido");
            }
            if (String.IsNullOrEmpty(Registro))
            {
                throw new Exception("Registro inválida");
            }

            return new dentista(Nome, Cpf, Fone, Email, Registro, Salario, Especialidade);
        }
        public static Dentista AlterarDentista(
            int Id,
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Registro,
            double Salario,
            string Especialidade
        )
        {
            Dentista Dentista = GetDentista(Id);

            if (!String.IsNullOrEmpty(Nome))
            {
                Dentista.Nome = Nome;
            }
            if (!String.IsNullOrEmpty(Cpf))
            {
                Dentista.Cpf = Cpf;
            }
            if (!String.IsNullOrEmpty(Fone))
            {
                Dentista.Fone = Fone;
            }
            if (!String.IsNullOrEmpty(Email))
            {
                Dentista.Email = Email;
            }
            if (!String.IsNullOrEmpty(Registro))
            {
                throw new Exception("Registro inválida");
            }

            return dentista;

        }
        public static Dentista ExcluirDentista(
            string Id
        )
        {
            Dentista dentista = GetDentista(Id);
            Dentista.RemoverDentista(dentista);
            return dentista;

        }
        public static List<Dentista> VisualizarDentista()
        {
            return Dentista.GetDentista();
        }
        public static Dentista GetDentista(
            int Id
        )
        {
            Dentista Dentista = from dentista in Dentista.GetDentistas()
                                      where Dentista.Id == Id
                                      select Dentista;
            if (dentista == null)
            {
                throw new Exception("Dentista não existe");
            }
            return dentista;
        }
    }
}