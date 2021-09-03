using System;
using FluentNHibernate.Mapping;
namespace Tempus.Data.Model
{
    public class FuncionarioMap : ClassMap<Funcionario>
    {
        public FuncionarioMap() 
        {
            Table("Funcionario");
            Id(x => x.Matricula);
            Map(x => x.Nome);
            Map(x => x.PIS);
            Map(x => x.CTPS);
            References(x => x.Empresa)
               .Not.LazyLoad()
               .Fetch.Join()
               .NotFound.Ignore();
            References(x => x.Horario)
               .Not.LazyLoad()
               .Fetch.Join()
               .NotFound.Ignore();
            References(x => x.Funcao)
               .Not.LazyLoad()
               .Fetch.Join()
               .NotFound.Ignore();
            References(x => x.Departamento)
               .Not.LazyLoad()
               .Fetch.Join()
               .NotFound.Ignore();
            Map(x => x.Admissao);
            Map(x => x.Demissao);
            Map(x => x.MotivoDemissao);
            
        }
    }
}
