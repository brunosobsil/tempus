using System;
using FluentNHibernate.Mapping;

namespace Tempus.Data.Model
{
    public class ApontamentoMap : ClassMap<Apontamento>
    {
        public ApontamentoMap()
        {

            Table("Apontamento");
            Id(x => x.Id);
            Map(x => x.Data);
            References(x => x.Funcionario)
                .Column("Matricula")
                .Not.LazyLoad()
                .Fetch.Join()
                .NotFound.Ignore();
            Map(x => x.Entrada1);
            Map(x => x.Saida1);
            Map(x => x.Entrada2);
            Map(x => x.Saida2);
            Map(x => x.Entrada3);
            Map(x => x.Saida3);
            References(x => x.Justificativa)
                .Not.LazyLoad()
                .Fetch.Join()
                .NotFound.Ignore();
        }
    }
}