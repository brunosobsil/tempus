using System;
namespace Tempus.Data.Model
{
    public class AcessoUsuario
    {
        public Usuario Usuario { get; set; }
        public Empresa Empresa { get; set; }

        public AcessoUsuario(Usuario usuario, Empresa empresa)
        {
            this.Usuario = usuario;
            this.Empresa = empresa;
        }
    }
}
