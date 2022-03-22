using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Models;

namespace Controllers
{
    public class PacienteController
    {
        public static Paciente IncluirPaciente(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            DateTime DataNascimento
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
            if (DataNascimento == null || DataNascimento > DateTime.Now)
            {
                throw new Exception("Data de Nascimento inválida");
            }

            return new Paciente(Nome, Cpf, Fone, Email, DataNascimento);
        }
        public static Paciente AlterarPaciente(
            int Id,
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            DateTime DataNascimento
        )
        {
            Paciente paciente = GetPaciente(Id);

            if (!String.IsNullOrEmpty(Nome))
            {
                paciente.Nome = Nome;
            }
            if (!String.IsNullOrEmpty(Cpf))
            {
                paciente.Cpf = Cpf;
            }
            if (!String.IsNullOrEmpty(Fone))
            {
                paciente.Fone = Fone;
            }
            if (!String.IsNullOrEmpty(Email))
            {
                paciente.Email = Email;
            }
            if (!String.IsNullOrEmpty(Email))
            {
                paciente.Email = Email;
            }
            if (DataNascimento > DateTime.Now)
            {
                throw new Exception("Data de Nascimento inválida");
            }
            if (DataNascimento == null)
            {
                paciente.DataNascimento = DataNascimento;
            }

            return paciente;

        }
        public static Paciente ExcluirPaciente(
            string Id
        )
        {
            Paciente paciente = GetPaciente(Id);
            Paciente.RemoverPaciente(paciente);
            return paciente;

        }
        public static List<Paciente> VisualizarPaciente()
        {
            return Paciente.GetPaciente();
        }
        public static Paciente GetPaciente(
            int Id
        )
        {
            List<Paciente> PacientesModels = Models.Paciente.GetPacientes();
            IEnumerable<Paciente> paciente = from paciente in Paciente.GetPacientes()
                                             where Paciente.Id == Id
                                             select Paciente;
            if (paciente == null)
            {
                throw new Exception("Paciente não existe");
            }
            return paciente;
        }
    }
}