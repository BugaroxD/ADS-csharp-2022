using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Models;

namespace Controllers
{
    public class SalasController
    {
        public static Sala IncluirSala(
            string Numero,
            string Equipamentos
        )
        {
            if (String.IsNullOrEmpty(Numero))
            {
                throw new Exception("Número é obrigatório");
            }
            return new Sala(Numero, Equipamentos);
        }
        public static Sala AlterarSala(
            int Id,
            string Numero,
            string Equipamentos
        )
        {
            Sala sala = GetSala(Id);

            if (String.IsNullOrEmpty(Numero))
            {
                sala.Numero = Numero;
            }
            sala.Equipamentos = Equipamentos;

            return sala;
        }
        public static Sala ExcluirSala(
            string Id
        )
        {
            Sala sala = GetSala(Id);
            Models.Sala.GetSalas().Remove(sala);
            return sala;

        }
        public static List<Sala> VisualizarSala()
        {
            return Models.Sala.GetSalas();
        }
        public static Sala GetSala(
            int Id
        )
        {
            List<Sala> salasModels = Models.Sala.GetSalas();
            IEnumerable<Sala> salas = from Sala in Sala.GetSalas()
                                      where Sala.Id == Id
                                      select Sala;
            if (sala == null)
            {
                throw new Exception("Sala não existe");
            }
            return sala;
        }
    }
}