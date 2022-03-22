using System;
using System.Collections.Generic;

namespace Models
{
    public class AgendamentoProcedimento
    {

        public static int ID = 0;
        private static List<AgendamentoProcedimento> AgendamentoProcedimentos = new List<AgendamentoProcedimento>();
        public int Id { set; get; }
        public int AgendamentoId { set; get; }
        public Agendamento Agendamento { set; get; }
        public int ProdecimentoId { set; get; }
        public Procedimento Procedimento { set; get; }
        public AgendamentoProcedimento(
            int AgendamentoId,
            int ProdecimentoId
        ) : this(++ID, AgendamentoId, ProdecimentoId)
        {

        }

        private AgendamentoProcedimento(
            int Id,
            int AgendamentoId,
            int ProdecimentoId
        )
        {
            this.Id = Id;
            this.AgendamentoId = AgendamentoId;
            this.ProdecimentoId = ProdecimentoId;
            this.Agendamento = Agendamento.GetAgendamentos().Find(Agendamento => Agendamento.Id == AgendamentoId);
            this.Procedimento = Procedimento.GetProcedimentos().Find(Procedimento => Procedimento.Id == ProdecimentoId);

            AgendamentoProcedimentos.Add(this);
        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nId Agendamento: {this.AgendamentoId}"
                + $"\nId Procedimento: { this.ProdecimentoId + "-" + this.Procedimento.Descricao}";
        }

        public static List<AgendamentoProcedimento> GetAgendamentoProcedimentos()
        {
            return AgendamentoProcedimentos;
        }

        public static void RemoverAgendamentoProcedimento(AgendamentoProcedimento procedimento)
        {
            AgendamentoProcedimentos.Remove(procedimento);
        }
    }
}