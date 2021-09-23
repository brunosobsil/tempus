using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IFuncaoService
    {
        public IEnumerable<Funcao> GetAll();
        public Funcao Get(int codigo);
        public Funcao Add(Funcao funcao);
        public void Update(Funcao funcao);
        public void Delete(Funcao funcao);

    }
}
