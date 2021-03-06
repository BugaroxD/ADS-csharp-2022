using System;
using System.Collections.Generic;

namespace Models
{
    public class Agendamento
    {
        public static int ID = 0;
        private static List<Agendamento> Agendamentos = new List<Agendamento>();
        public int Id { set; get; }
        public int IdPaciente { set; get; }
        public int IdDentista { set; get; }
        public int IdSala { set; get; }
        public DateTime Data { set; get; }
        public string Procedimento { set; get; }

        public Agendamento(
            int Id,
            int IdPaciente,
            int IdDentista,
            int IdSala,
            DateTime Data,
            string Procedimento
        ) : this(++ID, IdPaciente, IdDentista, IdSala, Data, Procedimento)
        {
        }
        private Agendamento(
            int Id,
            int IdPaciente,
            int IdDentista,
            int IdSala,
            DateTime Data,
            string Procedimento
        )
        {
            this.Id = Id;
            this.IdPaciente = IdPaciente;
            this.IdDentista = IdDentista;
            this.IdSala = IdSala;
            this.Data = Data;
            this.Procedimento = Procedimento;

            Agendamentos.Add(this);
        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nPaciente: {this.IdPaciente}"
                + $"\nDentista: {this.IdDentista}"
                + $"\nSala: {this.Sala}"
                + $"\nData: {this.Data}"
                + $"\nProcedimento: {this.Procedimento}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Agendamento.ReferenceEquals(obj, this))
            {
                return false;
            }
            Agendamento it = (Agendamento)obj;
            return it.Id == this.Id;
        }

        public static List<Agendamento> GetAgendamentos()
        {
            return Agendamentos;
        }
    }
}
