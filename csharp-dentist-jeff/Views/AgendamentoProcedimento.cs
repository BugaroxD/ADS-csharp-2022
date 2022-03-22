using System;
using Controllers;
using Models;

namespace Views
{
    public class AgendamentoProcedimentoView
    {
        public static void InserirAgendamentoProcedimento()
        {
            int AgendamentoId = 0;
            int ProcedimentoId = 0;
            Console.WriteLine("Digite o ID do Agendamento: ");
            try
            {
                AgendamentoId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }

            Console.WriteLine("Digite o ID do Procedimento: ");
            try
            {
                ProcedimentoId = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }

            AgendamentoProcedimentoController.InserirAgendamentoProcedimento(
                AgendamentoId,
                ProcedimentoId
            );
        }


        public static void ExcluirAgendamentoProcedimento()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID do AgendamentoProcedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }

            AgendamentoProcedimentoController.ExcluirAgendamentoProcedimento(
                Id
            );

        }

        public static void ListarAgendamentoProcedimentos()
        {
            foreach (AgendamentoProcedimento item in AgendamentoProcedimentoController.VisualizarAgendamentoProcedimento())
            {
                Console.WriteLine(item);
            }
        }
    }
}