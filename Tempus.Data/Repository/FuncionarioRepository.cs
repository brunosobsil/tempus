using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        ISession session;

        public FuncionarioRepository(ISession session)
        {
            this.session = session;
        }

        public IEnumerable<Funcionario> GetAll()
        {
            return this.session.QueryOver<Funcionario>().List<Funcionario>();
        }
        public IEnumerable<Funcionario> GetByEmpresa(Empresa emp)
        {
            return this.session.QueryOver<Funcionario>().Where(f => f.Empresa == emp).List<Funcionario>();
        }
        public IEnumerable<Funcionario> GetByEmpresaAtivos(Empresa emp)
        {
            return this.session.QueryOver<Funcionario>().Where(f => f.Empresa == emp && f.Demissao == null).List<Funcionario>();
        }
        public IEnumerable<Funcionario> GetByEmpresaAndDepartamento(Empresa emp, Departamento dep)
        {
            return this.session.QueryOver<Funcionario>().Where(f => f.Empresa == emp && f.Departamento == dep).List<Funcionario>();
        }
        public IEnumerable<Funcionario> GetByEmpresaAndDepartamentoAtivos(Empresa emp, Departamento dep)
        {
            return this.session.QueryOver<Funcionario>().Where(f => f.Empresa == emp && f.Departamento == dep && f.Demissao == null).List<Funcionario>();
        }
        public Funcionario Get(Funcionario funcio)
        {
            Funcionario funcionario = null;
            IList<Funcionario> result = this.session.QueryOver<Funcionario>().Where(f => f.Matricula == funcio.Matricula).List();
            if (result.Count > 0)
            {
                funcionario = result[0];
            }

            return funcionario;
        }

        public Funcionario GetByPIS(Funcionario funcio)
        {
            Funcionario funcionario = null;
            IList<Funcionario> result = this.session.QueryOver<Funcionario>().Where(f => f.PIS == funcio.PIS).List();
            if (result.Count > 0)
            {
                funcionario = result[0];
            }

            return funcionario;
        }
        public Funcionario Add(Funcionario funcionario)
        {
            this.session.Save(funcionario);
            return funcionario;
        }
        public void Update(Funcionario funcionario)
        {
            this.session.Update(funcionario);
            this.session.Flush();
        }
        public void Delete(Funcionario funcionario)
        {
            this.session.Delete(funcionario);
            this.session.Flush();
        }
    }
}