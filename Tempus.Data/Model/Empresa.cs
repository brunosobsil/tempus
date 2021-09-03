using System;
using System.Collections.Generic;

namespace Tempus.Data.Model
{
    public class Empresa
    {
        public virtual int Id { get; set; }
        public virtual string RazaoSocial { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual string Responsavel { get; set; }
        public virtual DateTime DataLiberacao { get; set; }
        public virtual string Logo { get; set; }
        public virtual IEnumerable<Usuario> Usuarios { get; set; }

        public Empresa(int Id, string RazaoSocial, string CNPJ, string Responsavel, IEnumerable<Usuario> usuarios)
        {
            this.Id = Id;
            this.RazaoSocial = RazaoSocial;
            this.CNPJ = CNPJ;
            this.Responsavel = Responsavel;
            this.Usuarios = usuarios;
        }

        public Empresa() { }

    }
}
