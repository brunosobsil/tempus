using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IRelogioService
    {
        public IEnumerable<Relogio> GetAll();
        public Relogio Get(Relogio relogio);
        public Relogio Add(Relogio relogio);
        public void Update(Relogio relogio);
        public void Delete(Relogio relogio);
    }
}
