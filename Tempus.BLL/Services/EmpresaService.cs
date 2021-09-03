using System.Collections.Generic;
using Tempus.Data.Model;
using Tempus.Data.Repository;

namespace Tempus.BLL.Services
{
    public class EmpresaService : IEmpresaService
    {
        IEmpresaRepository empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            this.empresaRepository = empresaRepository;
        }


        public IEnumerable<Empresa> GetAll()
        {
            return this.empresaRepository.GetAll();
        }
    }
}
