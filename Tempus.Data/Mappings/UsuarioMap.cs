using System;
using FluentNHibernate.Mapping;
//using Tempus.Data.Model;

namespace Tempus.Data.Model
{
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Table("Usuario");
            Id(x => x.Login);
            Map(x => x.Nome);
            Map(x => x.Email);
            Map(x => x.Senha);
            HasManyToMany(x => x.Empresas)
                .Table("Usuario_Acesso")
                .ParentKeyColumn("login_usuario")
                .ChildKeyColumn("id_empresa")
                .LazyLoad()
                .Cascade.SaveUpdate();

        }
    }
}
