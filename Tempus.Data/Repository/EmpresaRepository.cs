using System;
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

        public Empresa GetById(int id)
        {
            Empresa empresa = null;
            IList<Empresa> result = this.session.QueryOver<Empresa>().Where(e => e.Id == id).List();
            if (result.Count > 0)
            {
                empresa = result[0];
            }

            return empresa;
        }

        public Empresa GetByCNPJ(string CNPJ)
        {
            Empresa empresa = null;
            IList<Empresa> result = this.session.QueryOver<Empresa>().Where(e => e.CNPJ == CNPJ).List();
            if (result.Count > 0)
            {
                empresa = result[0];
            }

            return empresa;
        }

        public Empresa Include(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public void Update(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public void Delete(Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
