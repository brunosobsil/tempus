using System.Collections.Generic;
using Tempus.Data.Model;

namespace Tempus.BLL.Services
{
    public interface IEmpresaService
    {
        public IEnumerable<Empresa> GetAll();
        public Empresa Get(int id);
        public Empresa GetByCNPJ(string cnpj);
        public Empresa Add(Empresa empresa);
        public void Update(Empresa empresa);
        public void Delete(Empresa empresa);
    }
}
