using System.Collections.Generic;
using NHibernate;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public class RelogioRepository : IRelogioRepository
    {
        ISession session;
        public RelogioRepository(ISession session)
        {
            this.session = session;
        }

        public IEnumerable<Relogio> GetAll()
        {
            return this.session.QueryOver<Relogio>().List<Relogio>();
        }

        public Relogio Get(Relogio rel)
        {
            Relogio relogio = null;
            IList<Relogio> result = this.session.QueryOver<Relogio>().Where(r => r.Numero == rel.Numero).List();
            if (result.Count > 0)
            {
                relogio = result[0];
            }

            return relogio;
        }

        public Relogio Add(Relogio relogio)
        {
            this.session.Save(relogio);
            return relogio;
        }

        public void Update(Relogio relogio)
        {
            this.session.Update(relogio);
            this.session.Flush();
        }

        public void Delete(Relogio relogio)
        {
            this.session.Delete(relogio);
            this.session.Flush();
        }
    }
}
