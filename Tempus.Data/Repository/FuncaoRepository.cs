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

        public Funcao Get(Funcao func)
        {
            Funcao funcao = null;
            IList<Funcao> result = this.session.QueryOver<Funcao>().Where(f => f.Codigo == func.Codigo).List();
            if(result.Count > 0)
            {
                funcao = result[0];
            }

            return funcao;
        }

        public Funcao Add(Funcao funcao)
        {
            this.session.Save(funcao);
            return funcao;
        }

        public void Update(Funcao funcao)
        {
            this.session.Update(funcao);
            this.session.Flush();
        }

        public void Delete(Funcao funcao)
        {
            this.session.Delete(funcao);
            this.session.Flush();
        }
    }
}
