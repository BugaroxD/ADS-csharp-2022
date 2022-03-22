using System;

namespace Models
{
    public class Pessoa
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public string Cpf { set; get; }
        public string Fone { set; get; }
        public string Email { set; get; }

        public override string ToString()
        {
            return $"ID: {this.Id}\n"
                + $"Nome: {this.Nome}\n"
                + $"C.P.F.: {this.Cpf}\n"
                + $"Telefone: {this.Fone}\n"
                + $"Email: {this.Email}";
        }
        public Pessoa(
            int Id,
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha
        )
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Fone = Fone;
            this.Email = Email;
            this.Senha = Senha;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                if (!Pessoa.ReferenceEquals(this, obj))
                    return false;
            }
            Pessoas it = (Pessoa)obj;
            return it.Id == this.Id;
        }
    }
}
