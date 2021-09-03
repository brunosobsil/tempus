using System;
using FluentNHibernate.Mapping;
//using Tempus.Data.Model;
namespace Tempus.Data.Model
{
    public class FuncaoMap : ClassMap<Funcao>
    {
        public FuncaoMap()
        {
            Table("Funcao");
            Id(x => x.Codigo).Column("Codigo");
            Map(x => x.Descricao).Column("Descricao");
        }
    }
}
