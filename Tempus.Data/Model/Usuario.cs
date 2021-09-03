using System;
using System.Collections.Generic;

namespace Tempus.Data.Model
{
    public class Usuario
    {
        public virtual string Login { get; set; }
        public virtual string Email { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Nome { get; set; }
        public virtual IEnumerable<Empresa> Empresas { get; set; }

        public Usuario(string login, string email, string senha, string nome, IEnumerable<Empresa> empresas)
        {
            this.Login = login;
            this.Email = email;
            this.Senha = senha;
            this.Nome = nome;
            this.Empresas = empresas;
        }

        public Usuario() { }
    }
}
