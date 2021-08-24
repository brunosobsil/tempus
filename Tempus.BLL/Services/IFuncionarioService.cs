using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IFuncionarioService
    {
        public IEnumerable<Funcionario> GetAll();
    }
}
