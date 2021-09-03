using System;
using FluentNHibernate.Mapping;
using Tempus.Data.Model;
namespace Tempus.Data.Mappings
{
    public class EmpresaMap : ClassMap<Empresa>
    {
        public EmpresaMap()
        {
            Table("Empresa");
            Id(x => x.Id);
            Map(x => x.RazaoSocial);
            Map(x => x.CNPJ);
            Map(x => x.Responsavel);
            Map(x => x.DataLiberacao);
            Map(x => x.Logo);
            HasManyToMany(x => x.Usuarios)
                .Table("Usuario_Acesso")
                .ParentKeyColumn("login_usuario")
                .ChildKeyColumn("id_empresa")
                .Inverse();
        }
    }
}
