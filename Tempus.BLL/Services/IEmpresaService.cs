using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IEmpresaService
    {
        public IEnumerable<Empresa> GetAll();
    }
}
