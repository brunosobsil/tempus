using System;
using System.Collections.Generic;
using NHibernate;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public class FuncaoRepository : IFuncaoRepository
    {
        ISession session;

        public FuncaoRepository(ISession session)
        {
            this.session = session;
        }

        public IEnumerable<Funcao> GetAll()
        {
            return this.session.CreateCriteria<Funcao>().List<Funcao>();
        }

        public Funcao GetById(int codigo)
        {
            Funcao funcao = null;
            IList<Funcao> result = this.session.QueryOver<Funcao>().Where(f => f.Codigo == codigo).List();
            if(result.Count > 0)
            {
                funcao = result[0];
            }

            return funcao;
        }

        public Funcao Include(Funcao funcao)
        {
            throw new NotImplementedException();
        }

        public void Update(Funcao funcao)
        {
            throw new NotImplementedException();
        }

        public void Delete(Funcao funcao)
        {
            throw new NotImplementedException();
        }
    }
}
