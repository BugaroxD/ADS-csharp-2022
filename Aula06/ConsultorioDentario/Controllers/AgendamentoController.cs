using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Models;

namespace Controllers
{
    public class DentistaController
    {
        public static Dentista IncluirAgendamento(
            int Id,
            int IdPaciente,
            int IdDentista,
            int IdSala,
            DateTime Data,
            string Procedimento
        )
        {
            PacienteController.GetPaciente(IdPaciente);
            DentistaController.GetDentista(IdDentista);
            SalaController.GetSala(IdSala);

            if (Data == null || Data < DateTime.Now)
            {
                throw new Exception("Data inválida");
            }

            return new Agendamento(IdPaciente, IdDentista, IdSala, Data, Procedimento);
        }
        public static Dentista AlterarAgendamento(
            int Id,
            int IdPaciente,
            int IdDentista,
            int IdSala,
            DateTime Data,
            string Procedimento
        )
        {
            Agendamento agendamento = GetAgendamento(Id);

            SalasController.GetSala(IdSala);

            if (Data == null || Data < DateTime.Now)
            {
                throw new Exception("Data inválida");
            }
        }
        public static Dentista ExcluirAgendamento(
            string Id
        )
        {
            Agendamento agendamento = GetAgendamento(Id);
            Agendamento.RemoverAgendamento(agendamento);
            return agendamento;
        }
        public static List<Agendamento> VisualizarAgendamento()
        {
            return Agendamento.GetAgendamento();
        }
        public static Agendamento GetAgendamento(
            int Id
        )
        {
            Agendamento agendamento = from agendamento in Agendamento.GetAgendamentos()
                                      where Agendamento.Id == Id
                                      select Agendamento;
            if (agendamento == null)
            {
                throw new Exception("Agendamento não existe");
            }
            return agendamento;
        }
    }
}