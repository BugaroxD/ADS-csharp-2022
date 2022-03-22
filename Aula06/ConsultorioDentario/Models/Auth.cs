using System;

namespace Models
{
    public class Auth
    {
        public static Paciente Paciente;
        public static Dentista Dentista;
        public static bool isLogeed;
        public static void Login(
            string Email,
            string Senha
        )
        {
            Paciente paciente = Paciente.GetPacientes()
            .Find(Paciente => Paciente.Email == Email && Paciente.Senha == Senha);

            if (Paciente != null)
            {
                isLogeed = true;
                Paciente = paciente;
                Dentista = null;
            }
            else
            {
                Dentista dentista = Dentista.GetDentistas()
                .Find(Dentista => Dentista.Email == Email && Dentista.Senha == Senha);

                if (dentista != null)
                {
                    isLogeed = true;
                    Dentista = dentista;
                    Paciente = null;
                }
            }
        }

    }
}