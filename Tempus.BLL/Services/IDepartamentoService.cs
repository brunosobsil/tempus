using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IDepartamentoService
    {
        public IEnumerable<Departamento> GetAll();
    }
}
