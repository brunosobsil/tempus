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

        public Empresa Get(int id)
        {
            Empresa empresa = new Empresa();
            empresa.Id = id;
            return this.empresaRepository.Get(empresa);
        }
        public Empresa GetByCNPJ(string cnpj)
        {
            Empresa empresa = new Empresa();
            empresa.CNPJ = cnpj;
            return this.empresaRepository.GetByCNPJ(empresa);
        }

        public Empresa Add(Empresa empresa)
        {
            return this.empresaRepository.Add(empresa);
        }

        public void Update(Empresa empresa)
        {
            this.empresaRepository.Update(empresa);
        }

        public void Delete(Empresa empresa)
        {
            this.empresaRepository.Delete(empresa);
        }
    }
}
