using System;
using FluentNHibernate.Mapping;
//using Tempus.Data.Model;
namespace Tempus.Data.Model
{
    public class RelogioMap : ClassMap<Relogio>
    {
        public RelogioMap()
        {
            Table("Relogio");
            Id(x => x.Numero);
            Map(x => x.IP);
            Map(x => x.Descricao);
            HasOne(x => x.Empresa);
        }
    }
}
