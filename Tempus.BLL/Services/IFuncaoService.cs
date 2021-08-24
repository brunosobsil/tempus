using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IFuncaoService
    {
        public IEnumerable<Funcao> GetAll();
    }
}
