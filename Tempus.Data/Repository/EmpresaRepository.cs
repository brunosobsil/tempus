using System.Collections.Generic;
using NHibernate;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public class EmpresaRepository : IEmpresaRepository
    {
        ISession session;

        public EmpresaRepository(ISession session)
        {
            this.session = session;
        }

        public IEnumerable<Empresa> GetAll()
        {
            return this.session.CreateCriteria<Empresa>().List<Empresa>();
        }

        public Empresa Get(Empresa emp)
        {
            Empresa empresa = null;
            IList<Empresa> result = this.session.QueryOver<Empresa>().Where(e => e.Id == emp.Id).List();
            if (result.Count > 0)
            {
                empresa = result[0];
            }

            return empresa;
        }

        public Empresa GetByCNPJ(Empresa emp)
        {
            Empresa empresa = null;
            IList<Empresa> result = this.session.QueryOver<Empresa>().Where(e => e.CNPJ == emp.CNPJ).List();
            if (result.Count > 0)
            {
                empresa = result[0];
            }

            return empresa;
        }

        public Empresa Add(Empresa empresa)
        {
            this.session.Save(empresa);
            return empresa;
        }

        public void Update(Empresa empresa)
        {
            this.session.Save(empresa);
            this.session.Flush();
        }

        public void Delete(Empresa empresa)
        {
            this.session.Save(empresa);
            this.session.Flush();
        }
    }
}
