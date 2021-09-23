using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.Data.Repository
{
    public interface IRelogioRepository
    {
        IEnumerable<Relogio> GetAll();
        Relogio Get(Relogio relogio);
        Relogio Add(Relogio relogio);
        void Update(Relogio relogio);
        void Delete(Relogio relogio);
    }
}
