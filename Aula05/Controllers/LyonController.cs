using System;
using Models;
using System.Collections.Generic;

namespace Controllers

{
    public class LyonController
    {
        public static Models.Lyon InsertLyon(string name, int timesToEat, int visitors)
        {
            try
            {
                return new Models.Lyon(name, timesToEat, visitors);
            }
            catch (Exception err)
            {
                throw new Exception($"Erro ao digitar informações do leão: {err.Message}");
            }
        }

        public static Models.Lyon UpdateLyon(Lyon lyon)
        {

            if (!String.IsNullOrEmpty(lyon.Name))
            {
                lyon.Name = lyon.Name;
            }

            if (lyon.TimesToEat > 0)
            {
                lyon.TimesToEat = lyon.TimesToEat;
            }
            lyon.Visitors = lyon.Visitors;
            return lyon;
        }

        public static Models.Lyon DeleteLyon()
        {
            int id = 0;
            Lyon lyon;


            lyon = Lyons.Find(lyon => lyon.Id == id);

            if (lyon == null)
            {
                throw new Exception($"Leão não encontrado.");
            }

            Lyons.Remove(lyon);

            return lyon;
        }
        public static Models.Lyon FindLyon(int id)
        {

            Lyon lyonFind;

            lyonFind = Lyon.Lyons.Find(lyonFind => lyonFind.Id == id);



            if (lyonFind == null)
            {

                throw new Exception($"Leão não encontrado.//FIND");

            }
            return lyonFind;
        }
        public static List<Lyon> PrintAllLyons()
        {

            return Lyon.Lyons;

        }
    }
}
