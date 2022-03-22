using System.Collections.Generic;
using System;

namespace Models
{
    public class Animal
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public Animal(
            int Id,
            string Name
        )
        {
            this.Id = Id;
            this.Name = Name;
        }
    }

    public class Lyon : Animal
    {
        public static List<Lyon> Lyons = new List<Lyon>();
        public static int IdCount = 0;
        public int TimesToEat { set; get; }
        public int Visitors { set; get; }

        public Lyon(
            string Name,
            int TimesToEat,
            int Visitors
        ) : this(++IdCount, Name, TimesToEat, Visitors)
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
    }
}
