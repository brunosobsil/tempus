using System;
namespace Tempus.Data.Model
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }

        public Usuario(string login, string email, string senha, string nome)
        {
            this.Login = login;
            this.Email = email;
            this.Senha = senha;
            this.Nome = nome;
        }
    }
}
