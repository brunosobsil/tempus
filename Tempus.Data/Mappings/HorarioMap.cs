using System;
using FluentNHibernate.Mapping;
//using Tempus.Data.Model;
namespace Tempus.Data.Model
{
    public class HorarioMap : ClassMap<Horario>
    {
        public HorarioMap()
        {
            Table("Horario");
            Id(x => x.DiaDaSemana);
            Map(x => x.Entrada1);
            Map(x => x.Saida1);
            Map(x => x.Entrada2);
            Map(x => x.Saida2);
            Map(x => x.Entrada3);
            Map(x => x.Saida3);
        }
    }
}
