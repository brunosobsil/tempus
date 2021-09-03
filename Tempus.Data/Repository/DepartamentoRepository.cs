using System;
using System.Collections.Generic;
using NHibernate;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        ISession session;

        public DepartamentoRepository(ISession session)
        {
            this.session = session;
        }

        public IEnumerable<Departamento> GetAll()
        {
            return this.session.QueryOver<Departamento>().List<Departamento>();
        }

        public Departamento Get(Departamento dep)
        {
            Departamento departamento = null;
            IList<Departamento> result = this.session.QueryOver<Departamento>().Where(d => d.Codigo == dep.Codigo).List();
            if (result.Count > 0)
            {
                departamento = result[0];
            }

            return departamento;
        }

        public Departamento Add(Departamento departamento)
        {
            this.session.Save(departamento);
            return departamento;
        }

        public void Update(Departamento departamento)
        {
            this.session.Update(departamento);
            this.session.Flush();
        }

        public void Delete(Departamento departamento)
        {
            this.session.Delete(departamento);
            this.session.Flush();
        }


    }
}
