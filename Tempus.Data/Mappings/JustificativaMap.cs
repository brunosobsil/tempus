using System;
using FluentNHibernate.Mapping;
//using Tempus.Data.Model;
namespace Tempus.Data.Model
{
    public class JustificativaMap : ClassMap<Justificativa>
    {
        public JustificativaMap()
        {
            Table("Justificativa");
            Id(x => x.Codigo);
            Map(x => x.Descricao);
        }
    }
}
