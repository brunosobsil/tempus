using System;
using FluentNHibernate.Mapping;
//using Tempus.Data.Model;

namespace Tempus.Data.Model
{
    public class DepartamentoMap : ClassMap<Departamento>
    {
        public DepartamentoMap()
        {
            Table("Departamento");
            Id(x => x.Codigo);
            Map(x => x.Descricao);
        }
    }
}
